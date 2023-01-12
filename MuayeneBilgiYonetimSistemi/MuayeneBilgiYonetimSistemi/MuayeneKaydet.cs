using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuayeneBilgiYonetimSistemi
{
    public partial class MuayeneKaydet : Form
    {
        public MuayeneKaydet()
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
                return true;            
            }
            catch
            {
                MessageBox.Show("TC kimlik no hatalı.");
                return false;
            }
        }


        private bool BosAlanKontrol()
        {
            bool TextBoxeEmpty = this.Controls.OfType<TextBox>().Any(t => t.Text == "");

            if (TextBoxeEmpty)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }

            return true;
        }

        private void EkraniSifirla()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }

            txtTC.Text = "";
        }

        public static long TC { get; set; }
        private bool muayeneSonucOk = false;

        public long TCGetir()
        {
            return TC;
        }


        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MBYS; user Id=postgres; password=12345");


        private bool HastaKontrol()
        {
            connection.Open();
            string sorgu2 = "SELECT * FROM muayeneler WHERE hasta_tc = " + txtTC.Text + " AND durum = 'Oluşturuldu'";
            NpgsqlCommand cmd = new NpgsqlCommand(sorgu2, connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows) //Satır varsa
            {
                connection.Close();
                return true;
            }

            MessageBox.Show("Girdiğiniz TC kimlik numarasına sahip bir hasta bulunamadı.");
            connection.Close();
            return false;
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!InputKontrol())
            {
                connection.Close();
                return;
            }

            if (!HastaKontrol())
            {
                connection.Close();
                return;
            }

            if (!BosAlanKontrol())
            {
                connection.Close();
                return;
            }

            connection.Open();

            string sorgu = "UPDATE muayeneler SET hasta_tc = @tc, tarih = to_date(:tarih, 'YYYY-MM-DD'), zaman = NOW(), oyku = @oyku, " +
                            "tani = @tani, tedavi = @tedavi, recete_kodu = NULL, durum = @durum" +
                            " WHERE hasta_tc = @tc;";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@tc", Convert.ToInt64(txtTC.Text));

            DateTime now = DateTime.Now;
            string tarih = now.ToString("yyyy-MM-dd");

            command.Parameters.AddWithValue("tarih", tarih);
            command.Parameters.AddWithValue("@oyku", txtOyku.Text);
            command.Parameters.AddWithValue("@tani", txtTani.Text);
            command.Parameters.AddWithValue("@tedavi", txtTedavi.Text);
            command.Parameters.AddWithValue("@recete_kodu", DBNull.Value);
            command.Parameters.AddWithValue("@durum", "Sonlandırıldı");

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Kayıt başarısız.");
                connection.Close();
                return;
            }

            MessageBox.Show("Muayene sonucu kaydedildi.");
            muayeneSonucOk = true;
            connection.Close();

            ReceteYaz recete = new ReceteYaz();
            recete.ReceteSonucDegistir();
        }


        private void MuayeneKaydet_Load(object sender, EventArgs e)   { }


        private void btnHastaGelmedi_Click(object sender, EventArgs e)
        {
            if (!InputKontrol())
            {
                return;
            }

            if (!HastaKontrol())
            {
                return;
            }

            connection.Open();

            string sorgu = "UPDATE muayeneler SET hasta_tc = @tc, tarih = to_date(:tarih, 'YYYY-MM-DD'), oyku = @oyku, " +
                            "tani = @tani, tedavi = @tedavi, recete_kodu = NULL, durum = @durum" +
                            " WHERE hasta_tc = @tc;";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@tc", Convert.ToInt64(txtTC.Text));

            DateTime now = DateTime.Now;
            string tarih = now.ToString("yyyy-MM-dd");

            command.Parameters.AddWithValue("tarih", tarih);
            command.Parameters.AddWithValue("@oyku", DBNull.Value);
            command.Parameters.AddWithValue("@tani", DBNull.Value);
            command.Parameters.AddWithValue("@tedavi", DBNull.Value);
            command.Parameters.AddWithValue("@recete_kodu", DBNull.Value);
            command.Parameters.AddWithValue("@durum", "Hasta Gelmedi");

            command.ExecuteNonQuery(); 
            MessageBox.Show("Muayene sonucu kaydedildi.");
            connection.Close();
            EkraniSifirla();
        }

        private void btnReceteYaz_Click(object sender, EventArgs e)
        {
            ReceteYaz recete = new ReceteYaz();

            if (!InputKontrol())
            {
                return;
            }

            if (muayeneSonucOk != true)
            {
                MessageBox.Show("Muayene kaydedilmeden reçete yazılamaz.");
                return;
            }

            if (recete.ReceteSonucOgren())
            {
                MessageBox.Show("Aynı hastaya birden fazla reçete yazılamaz.");
                return;
            }
        
            TC = Convert.ToInt64(txtTC.Text);
            recete.Show();
            EkraniSifirla();
        }
    }
}
