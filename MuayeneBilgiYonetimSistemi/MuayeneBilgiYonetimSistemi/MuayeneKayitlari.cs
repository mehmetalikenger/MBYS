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
    public partial class MuayeneKayitlari : Form
    {
        public MuayeneKayitlari()
        {
            InitializeComponent();
        }

        public static string muayeneTarihi;
        public static DateTime mTarih;

        public bool InputKontrol()
        {
            
            if(txtTC.Text == "")
            {
                MessageBox.Show("TC kimlik no giriniz.");
                return false;
            }
            
            try
            {
                long TC = Convert.ToInt64(txtTC.Text);
            }
            catch
            {
                MessageBox.Show("Geçerli bir TC kimlik numarası giriniz.");
                return false;
            }

            if (!txtTarih.MaskCompleted)
            {
                MessageBox.Show("Tarih giriniz.");
                return false;
            }

            try
            {
                mTarih = DateTime.ParseExact(txtTarih.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                muayeneTarihi = mTarih.ToString("yyyy-MM-dd");
            }
            catch
            {
                MessageBox.Show("Geçerli bir tarih giriniz.");
                return false;
            }

            return true;
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MBYS; user Id=postgres; password=12345");

            connection.Open();

            string sorgu = "SELECT oyku, tani, tedavi FROM muayeneler WHERE (hasta_tc = @tc AND tarih = to_date(:muayeneTarihi, 'YYYY-MM-DD'));";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            if (!InputKontrol())
            {
                connection.Close();
                return;
            }

            command.Parameters.AddWithValue("@tc", Convert.ToInt64(txtTC.Text));
            command.Parameters.AddWithValue("muayeneTarihi", muayeneTarihi);

            NpgsqlDataReader reader = command.ExecuteReader();
            reader.Read();

            if (!reader.HasRows)
            {
                MessageBox.Show("Muayene kaydı bulunamadı.");
                connection.Close();
                return;
            }

            txtOyku.Text = reader["oyku"].ToString();
            txtTani.Text = reader["tani"].ToString();
            txtTedavi.Text = reader["tedavi"].ToString();

            connection.Close();
            return;
        }

        private void MuayeneKayitlari_Load(object sender, EventArgs e)   { }      
    }
}
