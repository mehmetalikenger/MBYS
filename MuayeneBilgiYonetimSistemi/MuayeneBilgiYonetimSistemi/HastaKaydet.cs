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
using TextBox = System.Windows.Forms.TextBox;

namespace MuayeneBilgiYonetimSistemi
{
    public partial class HastaKaydet : Form
    {
        public HastaKaydet()
        {
            InitializeComponent();
        }


        private bool BosAlanKontrol()
        {
            bool MaskedBoxesEmpty = this.Controls.OfType<MaskedTextBox>().Any(t => t.Text == "");

            bool TextBoxesEmpty = this.Controls.OfType<TextBox>().Any(t => t.Text == "");

            if (MaskedBoxesEmpty)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }

            if (TextBoxesEmpty)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }

            if(cbMedeniDurum.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }

            return true;
        }


        private bool InputKontrol()
        {
            try
            {
                Convert.ToInt64(txtTC.Text);
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir TC kimlik numarası giriniz.");
                return false;
            }

            if(txtTC.Text.Length < 11)
            {
                MessageBox.Show("Lütfen geçerli bir TC kimlik numarası giriniz.");
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
            txtDogumTarihi.Text = "";
            cbMedeniDurum.SelectedItem = null;
        }


        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MBYS; user Id=postgres; password=12345");
        
        public static string dogumTarihi;
        public static DateTime dTarih;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!BosAlanKontrol()) 
            {
                return;
            }

            if (!InputKontrol())
            {
                return;
            }

            connection.Open();

            string sorgu = "INSERT INTO hastalar VALUES(@tc, @ad, @soyad, to_date(:dogum_tarihi, 'YYYY-MM-DD'), @dogum_yeri, @medeni_durum, @telefon, @adres);";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@tc", Convert.ToInt64(txtTC.Text));
            command.Parameters.AddWithValue("@ad", txtAd.Text);
            command.Parameters.AddWithValue("@soyad", txtSoyad.Text);

            try
            {
                dTarih = DateTime.ParseExact(txtDogumTarihi.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                dogumTarihi = dTarih.ToString("yyyy-MM-dd");
            }
            catch
            {
                MessageBox.Show("Geçerli bir tarih giriniz.");
                connection.Close();
                return;
            }

            command.Parameters.AddWithValue("dogum_tarihi", dogumTarihi);
            command.Parameters.AddWithValue("@dogum_yeri", txtDogumYeri.Text);
            command.Parameters.AddWithValue("@medeni_durum", cbMedeniDurum.SelectedItem);
            command.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            command.Parameters.AddWithValue("@adres", txtAdres.Text);

            try
            {

                command.ExecuteNonQuery();
            }
            catch (Npgsql.PostgresException ex)
            {

                if (ex.SqlState == "23505")
                {
                    MessageBox.Show("Girdiğiniz TC kimlik numarası zaten kayıtlı.");
                    connection.Close();
                    return;
                }

                else if (ex.SqlState == "22008")
                {
                    MessageBox.Show("Geçerli bir tarih giriniz.");
                    connection.Close();
                    return;
                }
            }

            MessageBox.Show("Hasta kaydı yapıldı.");
            EkraniSifirla();
            connection.Close();
        }

        private void HastaKaydet_Load(object sender, EventArgs e)  { }

        private void txtDogumTarihi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)  { }
    }
}
