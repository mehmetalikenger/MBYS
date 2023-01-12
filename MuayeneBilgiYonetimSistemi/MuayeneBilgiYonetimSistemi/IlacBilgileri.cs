using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuayeneBilgiYonetimSistemi
{
    public partial class IlacBilgileri : Form
    {
        public IlacBilgileri()
        {
            InitializeComponent();
        }


        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MBYS; user Id=postgres; password=12345");

        public void RecetelenenHastalariListele(string kod)
        {
            dataGridIlaclar.DataSource = null;
            
            connection.Open();

            string sorgu2 = "SELECT CONCAT(hastalar.ad, ' ', hastalar.soyad) AS \"Ad Soyad\", hastalar.TC AS \"TC\", " +
                            "receteler.recete_kodu AS \"Recete Kodu\", receteler.tarih AS  \"Tarih\" " +
                            "FROM receteler " +
                            "INNER JOIN hastalar ON " +
                            "receteler.hasta_tc = hastalar.tc " +
                            "WHERE (receteler.ilac_1_kod = @ilacKodu OR " +
                                   "receteler.ilac_2_kod = @ilacKodu OR " +
                                   "receteler.ilac_3_kod = @ilacKodu OR " +
                                   "receteler.ilac_4_kod = @ilacKodu OR " +
                                   "receteler.ilac_5_kod = @ilacKodu);";

            NpgsqlCommand command2 = new NpgsqlCommand(sorgu2, connection);
            command2.Parameters.AddWithValue("@ilacKodu", kod);

            NpgsqlDataReader reader2 = command2.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader2);

            dataGridIlaclar.DataSource = table;

            connection.Close();
        }


        public void IlacBilgileriniGetir(string kod)
        {
            connection.Open();

            string sorgu = "SELECT ad, tip FROM ilaclar WHERE kod = '" + kod + "';";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            reader.Read();

            if (!reader.HasRows)
            {
                MessageBox.Show("İlaç kaydı bulanamadı.");
                connection.Close();
                return;
            }

            txtAd.Text = reader["ad"].ToString();
            txtTip.Text = reader["tip"].ToString();

            connection.Close();
        }


        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            if(txtKod.Text == "")
            {
                MessageBox.Show("İlaç kodunu giriniz.");
                return;
            }
            
            string ilacKodu = txtKod.Text;

            RecetelenenHastalariListele(ilacKodu);

            IlacBilgileriniGetir(ilacKodu);
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();

            string sorgu = "DELETE FROM ilaclar WHERE kod = '" + txtKod.Text + "';";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);
            command.ExecuteNonQuery();

            MessageBox.Show("İlaç silindi");
            connection.Close();

            txtKod.Text = "";
            txtAd.Text = "";
            txtTip.Text = "";
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            txtAd.Enabled = true;
            txtTip.Enabled = true;
            btnKaydet.Enabled = true;        
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {         
            if(txtAd.Text == "" || txtTip.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız.");
                connection.Close();
                return;
            }
            
            connection.Open();

            string sorgu = "UPDATE ilaclar SET ad = @ad, tip = @tip WHERE kod = @kod;";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@kod", txtKod.Text);
            command.Parameters.AddWithValue("@ad", txtAd.Text);
            command.Parameters.AddWithValue("@tip", txtTip.Text);

            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Kaydedildi.");

            txtAd.Enabled = false;
            txtTip.Enabled = false;
            btnKaydet.Enabled = false;

            return;
        }
    }
}
