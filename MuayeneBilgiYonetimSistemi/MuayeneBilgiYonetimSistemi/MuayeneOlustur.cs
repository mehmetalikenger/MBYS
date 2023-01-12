using Npgsql;
using NpgsqlTypes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MuayeneBilgiYonetimSistemi
{
    public partial class MuayeneOlustur : Form
    {
        public MuayeneOlustur()
        {
            InitializeComponent();
        }

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

            if(!txtMuayeneTarihi.MaskCompleted)
            {
                MessageBox.Show("Tarih girilmeli.");
                return false;
            }

            if(cbBoxSaat.SelectedIndex == -1)
            {
                MessageBox.Show("Saat seçilmedi.");
                return false;
            }

            return true;
        }

        private void EkraniSifirla()
        {
            txtTC.Text = "";
            txtMuayeneTarihi.Text = "";
            cbBoxSaat.SelectedIndex = -1;
        }


        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MBYS; user Id=postgres; password=12345");

        public static string muayeneTarihi;
        public static DateTime mTarih;

        private bool HastaMuayeneOlabilirMi(string tarih)
        {
            connection.Close();
            connection.Open();

            string sorgu1 = "SELECT * FROM muayeneler;";

            NpgsqlCommand command1 = new NpgsqlCommand(sorgu1, connection);
            NpgsqlDataReader reader1 = command1.ExecuteReader();

            if (!reader1.HasRows)         //Hiç satır yoksa
            {
                connection.Close();
                return true;
            }

            connection.Close();
            connection.Open();

            string sorgu2 = "SELECT tarih FROM muayeneler WHERE hasta_tc = " + txtTC.Text + " ORDER BY tarih DESC;";
            NpgsqlCommand command2 = new NpgsqlCommand(sorgu2, connection);
           
            object result = command2.ExecuteScalar();
            DateTime dt = Convert.ToDateTime(result);

            if (dt.ToString("yyyy-MM-dd") != tarih)
            {
                return true;
            }

            EkraniSifirla();
            MessageBox.Show("Muayene kaydı oluşturulamadı. Hasta günde 1 kez muayene olabilir.");
            return false;
        }

        public bool MuayeneZamanKontrol(string muayeneTarihi, TimeSpan muayeneZamani)
        {
            connection.Close();
            connection.Open();

            string sorgu = "SELECT * FROM muayeneler WHERE (tarih = to_date(:muayeneTarihi, 'YYYY-MM-DD') AND zaman = @muayeneZamani);";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("muayeneTarihi", muayeneTarihi);
            command.Parameters.AddWithValue("@muayeneZamani", muayeneZamani);

            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Seçtiğiniz saat dolu.");
                return false;
            }

            return true;         
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {

            if (!InputKontrol())
            {
                connection.Close();
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

            if (mTarih < DateTime.Now)
            {
                MessageBox.Show("Geçmiş tarihler için randevu alamazsınız.");
                return;
            }

            connection.Open();
            string sorgu = "INSERT INTO muayeneler(hasta_tc, tarih, zaman, durum) VALUES(@hasta_tc, to_date(:muayene_tarihi, 'YYYY-MM-DD'), @muayeneZamani, 'Oluşturuldu')";
            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);         

            if (!HastaMuayeneOlabilirMi(muayeneTarihi))
            {
                connection.Close();
                return;
            }

            connection.Close();
            connection.Open();  

            command.Parameters.AddWithValue("@hasta_tc", Convert.ToInt64(txtTC.Text));
            command.Parameters.AddWithValue("muayene_tarihi", muayeneTarihi);

            string zaman = cbBoxSaat.SelectedItem.ToString();           
            TimeSpan muayeneZamani = TimeSpan.Parse(zaman);

            if (!MuayeneZamanKontrol(muayeneTarihi, muayeneZamani))
            {
                connection.Close();
                return;
            }

            connection.Close();
            connection.Open();

            command.Parameters.AddWithValue("@muayeneZamani", NpgsqlDbType.Time, muayeneZamani);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Npgsql.PostgresException ex)
            {
                if (ex.SqlState == "23503")
                {
                    EkraniSifirla();
                    MessageBox.Show("Girdiğiniz TC kimlik numarasına sahip bir hasta bulunamadı.");
                    connection.Close();
                    return;
                }

                else if (ex.SqlState == "22008")
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

            MessageBox.Show("Muayene kaydı oluşturuldu.");
            EkraniSifirla();
            connection.Close();
        }

        private void MuayeneOlustur_Load(object sender, EventArgs e) { }
    }
}
