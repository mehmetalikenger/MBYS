using Npgsql;
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
    public partial class HastaBilgileri : Form
    {
        public HastaBilgileri()
        {
            InitializeComponent();
        }


        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MBYS; user Id=postgres; password=12345");
        static long TC;


        private bool HastaBilgileriniGoruntule(long TC)
        {
            string sorgu = "SELECT * FROM hastalar WHERE tc = @tc";

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@tc", TC);

            NpgsqlDataReader reader = command.ExecuteReader();
            reader.Read();

            if (!reader.HasRows)
            {
                MessageBox.Show("Hasta bulunamadı.");
                connection.Close();
                return false;
            }

            txtAd.Text = reader["ad"].ToString();
            txtSoyad.Text = reader["soyad"].ToString();
            txtDogumTarihi.Text = DateTime.Parse(reader["dogum_tarihi"].ToString()).ToString("dd.MM.yyyy");
            txtDogumYeri.Text = reader["dogum_yeri"].ToString();


            if (reader["medeni_durum"].ToString() == "Bekar")
            {
                cbMedeniDurum.SelectedIndex = 0;
            }
            else
            {
                cbMedeniDurum.SelectedIndex = 1;
            }

            txtTelefon.Text = reader["telefon"].ToString();
            txtAdres.Text = reader["adres"].ToString();

            connection.Close();

            return true;
        }


        private bool HastaReceteleriniGoruntule(long TC)
        {
            dataGridReceteler.DataSource = null;
            
            connection.Open();

            string sorgu = "SELECT recete_kodu, tarih FROM receteler WHERE hasta_tc = @tc";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@tc", TC);

            NpgsqlDataReader reader = command.ExecuteReader();          

            if (!reader.HasRows)
            {
                connection.Close();
                return false;
            }

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridReceteler.DataSource = table;

            connection.Close();

            return true;
        }


        private void ReceteSil(string receteKodu)
        {
            connection.Open();

            string sorgu = "DELETE FROM receteler WHERE recete_kodu = @receteKodu;";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@receteKodu", receteKodu);

            command.ExecuteNonQuery();

            connection.Close();

            return;
        }


        private bool IlaclariGoruntule(long tc, string receteKod)
        {
            dataGridIlaclar.DataSource = null;
            
            DataTable table = new DataTable();

            for (int i = 1; i <= 5; i++)
            {
                connection.Open();

                string ilacKod = "ilac_" + i + "_kod";
                string ilacAdet = "ilac_" + i + "_adet";

                string sorgu = "SELECT " + ilacKod + " AS kod, ilaclar.ad AS ad, " + ilacAdet + " AS adet FROM receteler " +
                                "INNER JOIN ilaclar ON " + ilacKod + " = ilaclar.kod " +
                                "WHERE (receteler.hasta_tc = @tc AND receteler.recete_kodu = @receteKod);";

                NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

                command.Parameters.AddWithValue("@tc", tc);
                command.Parameters.AddWithValue("@receteKod", receteKod);
                command.Parameters.AddWithValue("@ilacKod", ilacKod);
                command.Parameters.AddWithValue("@ilacAdet", ilacAdet);

                NpgsqlDataReader reader = command.ExecuteReader();

                table.Load(reader);               

                connection.Close();
            }

            if(table.Rows.Count == 0)
            {
                MessageBox.Show("Recete bulunamadi");
                return false;
            }

            dataGridIlaclar.DataSource = table;

            return true;
        }

       
        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {
                MessageBox.Show("TC kimlik numarasını giriniz.");
                return;
            }

            try
            {
                Convert.ToInt64(txtTC.Text);
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir TC kimlik numarası giriniz.");
                return;
            }

            TC = Convert.ToInt64(txtTC.Text);

            if (!HastaBilgileriniGoruntule(TC))
            {       
                return;
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            txtDogumTarihi.Enabled = true;
            txtDogumYeri.Enabled = true;
            cbMedeniDurum.Enabled = true;
            txtTelefon.Enabled = true;
            txtAdres.Enabled = true;
            btnKaydet.Enabled = true;
        }

        private bool BosAlanKontrol()
        {
            bool TextBoxEmpty = panel3.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text));

            if (TextBoxEmpty || !txtDogumTarihi.MaskCompleted)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }

            return true;
        }

        private void EkraniSifirla()
        {
            foreach (Control c in panel3.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }

            txtTC.Text = "";
            txtDogumTarihi.Text = "";
            cbMedeniDurum.SelectedItem = null;
        }

        public static DateTime tarih;
        public static string dogumTarihi;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!BosAlanKontrol())
            {
                return;
            }
            
            string sorgu = "UPDATE hastalar SET ad = @ad, soyad = @soyad, dogum_tarihi = to_date(:dogum_tarihi, 'YYYY-MM-DD'), dogum_yeri = @dogumYeri, medeni_durum = @medeniDurum, telefon = @telefon, adres = @adres " +
                           "WHERE tc = @tc;";

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@tc", TC);
            command.Parameters.AddWithValue("@ad", txtAd.Text);
            command.Parameters.AddWithValue("@soyad", txtSoyad.Text);

            try
            {
                tarih = DateTime.ParseExact(txtDogumTarihi.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                dogumTarihi = tarih.ToString("yyyy-MM-dd");
                
            }
            catch
            {
                MessageBox.Show("Geçerli bir tarih giriniz.");
                connection.Close();
                return;
            }

            if (tarih.Month > 12 || tarih.Day > 31)
            {
                MessageBox.Show("Lütfen geçerli bir tarih giriniz.");
                return;
            }

            command.Parameters.AddWithValue("dogum_tarihi", dogumTarihi);
            command.Parameters.AddWithValue("@dogumYeri", txtDogumYeri.Text);
            command.Parameters.AddWithValue("@medeniDurum", cbMedeniDurum.SelectedItem);
            command.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            command.Parameters.AddWithValue("@adres", txtAdres.Text);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Değişiklikler kaydedildi.");

            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtDogumTarihi.Enabled = false;
            txtDogumYeri.Enabled = false;
            cbMedeniDurum.Enabled = false;
            txtTelefon.Enabled = false;
            txtAdres.Enabled = false;
            btnKaydet.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(txtSilinecekRecete.Text == "")
            {
                MessageBox.Show("Reçete kodunu giriniz.");
                return;
            }
            
            string receteKodu = txtSilinecekRecete.Text;

            ReceteSil(receteKodu);
            HastaReceteleriniGoruntule(TC);
        }

        private void btnIlacListele_Click(object sender, EventArgs e)
        {
            if (txtReceteKoduListe.Text == "")
            {
                MessageBox.Show("Reçete kodunu giriniz.");
                return;
            }

            string receteKodu = txtReceteKoduListe.Text;
            TC = Convert.ToInt64(txtTC.Text);
            
            if(!IlaclariGoruntule(TC, receteKodu)){
                return;
            }
        }

        private void btnReceteListele_Click(object sender, EventArgs e)
        {
            if (!HastaReceteleriniGoruntule(TC))
            {
                return;
            }
        }

        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            if (!BosAlanKontrol())
            {
                return;
            }

            connection.Open();

            string sorgu = "DELETE FROM hastalar WHERE tc = '" + TC + "';";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);
            command.ExecuteNonQuery();

            try
            {
                command.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("İşlem başarısız.");
                return ;
            }

            EkraniSifirla();
            MessageBox.Show("Hasta silindi.");
            connection.Close();
            return;
        }
    }
}
