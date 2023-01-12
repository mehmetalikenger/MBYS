using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuayeneBilgiYonetimSistemi
{
    public partial class MuayeneIptalEt : Form
    {
        public MuayeneIptalEt()
        {
            InitializeComponent();
        }

        public void EkraniSifirla()
        {
            txtMuayeneTarihi.Text = "";
            txtTC.Text = "";
        }

        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MBYS; user Id=postgres; password=12345");

        private bool InputKontrol()
        {
            if (string.IsNullOrEmpty(txtTC.Text))
            {
                MessageBox.Show("TC kimlik no girilmeli.");
                return false;
            }

            try
            {
                Convert.ToInt64(txtTC.Text);
            }
            catch
            {
                MessageBox.Show("TC kimlik no hatalı.");
                return false;
            }

            if (!txtMuayeneTarihi.MaskCompleted)
            {
                MessageBox.Show("Tarih girilmeli.");
                return false;
            }

            return true;
        }

        private bool IleriTarihliMuayeneKaydiBul(string muayeneTarihi)
        {
            connection.Open();

            string sorgu = "SELECT * FROM muayeneler " +
                            "WHERE (hasta_tc = @tc AND tarih = to_date(:muayeneTarihi, 'YYYY-MM-DD') AND durum = 'Oluşturuldu');";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@tc", Convert.ToInt64(txtTC.Text));
            command.Parameters.AddWithValue("muayeneTarihi", muayeneTarihi);

            NpgsqlDataReader reader = command.ExecuteReader();

            reader.Read();

            if (!reader.HasRows)
            {
                MessageBox.Show("Muayene kaydı bulunamadı.");
                return false;
            }

            return true;
        }

        private void IleriTarihliMuayeneIptalEt(string muayeneTarihi)
        {
            connection.Close();
            connection.Open();

            string sorgu = "DELETE FROM muayeneler " +
                            "WHERE (hasta_tc = @tc AND tarih = to_date(:muayeneTarihi, 'YYYY-MM-DD') AND durum = 'Oluşturuldu');";


            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@tc", Convert.ToInt64(txtTC.Text));
            command.Parameters.AddWithValue("muayeneTarihi", muayeneTarihi);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Npgsql.PostgresException ex)
            {
                if (ex.SqlState == "22008")
                {
                    MessageBox.Show("Geçerli bir tarih giriniz.");
                    connection.Close();
                    return;
                }

                else
                {
                    throw;
                }
            }

            MessageBox.Show("Muayene iptal edildi.");
            EkraniSifirla();
            connection.Close();
            return;
        }

       private bool OnDakikaKontrol(string muayeneTarihi)
        {
            connection.Open();

            string sorgu = "SELECT zaman FROM muayeneler " +
                            "WHERE (hasta_tc = @tc AND tarih = to_date(:muayeneTarihi, 'YYYY-MM-DD') AND durum = 'Sonlandırıldı');";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@tc", Convert.ToInt64(txtTC.Text));
            command.Parameters.AddWithValue("muayeneTarihi", muayeneTarihi);

            NpgsqlDataReader reader = command.ExecuteReader();

            reader.Read();

            if (!reader.HasRows)
            {
                MessageBox.Show("Muayene kaydı bulunamadı.");
                return false;
            }

            DateTime muayeneZamani = Convert.ToDateTime(reader["zaman"].ToString());
            int saat = (int)muayeneZamani.Hour;
            int dakika = (int)muayeneZamani.Minute;

            int saatFarki = DateTime.Now.Hour - saat;
            int dakikaFarki = DateTime.Now.Minute - dakika;

            if (saatFarki == 0 && dakikaFarki < 10)
            {
                return true;
            }

            return false;
        }

        private void GecmisZamanliMuayeneIptalEt(string muayeneTarihi)
        {
            connection.Close();
            connection.Open();
            
            string sorgu = "DELETE FROM muayeneler " +
                            "WHERE (hasta_tc = @tc AND tarih = to_date(:muayeneTarihi, 'YYYY-MM-DD') AND durum = 'Sonlandırıldı');";


            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@tc", Convert.ToInt64(txtTC.Text));
            command.Parameters.AddWithValue("muayeneTarihi", muayeneTarihi);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Npgsql.PostgresException ex)
            {
                if (ex.SqlState == "22008")
                {
                    MessageBox.Show("Geçerli bir tarih giriniz.");
                    connection.Close();
                    return;
                }

                else
                {
                    throw;
                }
            }

            MessageBox.Show("Muayene iptal edildi.");       
            connection.Close();
            return;
        }


        private void ReceteSil(string muayeneTarihi)
        {
            connection.Open();

            string sorgu = "DELETE FROM receteler " +
                            "WHERE (hasta_tc = @tc AND tarih = to_date(:muayeneTarihi, 'YYYY-MM-DD'));";


            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@tc", Convert.ToInt64(txtTC.Text));
            command.Parameters.AddWithValue("muayeneTarihi", muayeneTarihi);

            command.ExecuteNonQuery();
            
            connection.Close();
            return;
        }

        public static string muayeneTarihi;
        public static DateTime mTarih;

        private void btnIptal_Click(object sender, EventArgs e)
        {  
            if (!InputKontrol())
            {
                return;
            }

            try
            {
                mTarih = DateTime.ParseExact(txtMuayeneTarihi.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                muayeneTarihi = mTarih.ToString("yyyy-MM-dd");
            }
            catch
            {
                MessageBox.Show("Geçerli bir tarih giriniz.");
                return;
            }

            if (DateTime.Parse(muayeneTarihi) > DateTime.Now)
            {
                if (!IleriTarihliMuayeneKaydiBul(muayeneTarihi))
                {
                    connection.Close();
                    return;
                }

                IleriTarihliMuayeneIptalEt(muayeneTarihi);
                return;
            }

            else if(DateTime.Parse(muayeneTarihi).Day != DateTime.Now.Day)
            {
                MessageBox.Show("Üzerinden 10 dakikadan fazla geçmiş muayeneleri iptal edemezsiniz.");
            }

            else
            {               
                if (!OnDakikaKontrol(muayeneTarihi))
                {
                    connection.Close();
                    return;
                }

                GecmisZamanliMuayeneIptalEt(muayeneTarihi);
                ReceteSil(muayeneTarihi);
                EkraniSifirla();
                return;
            }       
        }

        private void txtMuayeneTarihi_TextChanged(object sender, EventArgs e) {}
    }
}
