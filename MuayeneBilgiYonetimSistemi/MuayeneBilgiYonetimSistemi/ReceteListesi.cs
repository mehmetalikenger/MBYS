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
    public partial class ReceteListesi : Form
    {
        public ReceteListesi()
        {
            InitializeComponent();
        }

        public bool InputKontrol()
        {
            if(!txtBaslangicTarihi.MaskCompleted || !txtBitisTarihi.MaskCompleted)
            {
                MessageBox.Show("Tarih giriniz.");
                return false;
            }

            return true;
        }

        public static DateTime bTarih;
        public static string baslangicTarihi;
        public static DateTime sTarih;
        public static string bitisTarihi;

        private void btnListele_Click(object sender, EventArgs e)
        {

            if (!InputKontrol())
            {
                return;
            }

            NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MBYS; user Id=postgres; password=12345");

            connection.Open();

            string sorgu = "SELECT receteler.recete_kodu AS \"Reçete Kodu\", receteler.tarih \"Tarih\", receteler.hasta_tc \"TC\", CONCAT(hastalar.ad, ' ', hastalar.soyad) AS \"Ad Soyad\", " +
                            "ilac_1_kod AS \"İlaç Kodu 1\", ilac_1_adet AS \"Kutu 1\", ilac_2_kod AS \"İlaç Kodu 2\", ilac_2_adet AS \"Kutu 2\", ilac_3_kod AS \"İlaç Kodu 3\", ilac_3_adet AS \"Kutu 3\", ilac_4_kod AS \"İlaç Kodu 4\", ilac_4_adet AS \"Kutu 4\", ilac_5_kod AS \"İlaç Kodu 5\", ilac_5_adet AS \"Kutu 5\" FROM receteler " +
                            "INNER JOIN hastalar ON hasta_tc = tc " +
                            "WHERE tarih >= to_date(:baslangicTarihi, 'YYYY-MM-DD') AND " +
                                                          "tarih <= to_date(:bitisTarihi, 'YYYY-MM-DD') " +
                                                          "ORDER BY tarih;";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            try
            {
                bTarih = DateTime.ParseExact(txtBaslangicTarihi.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                baslangicTarihi = bTarih.ToString("yyyy-MM-dd");
                sTarih = DateTime.ParseExact(txtBitisTarihi.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                bitisTarihi = sTarih.ToString("yyyy-MM-dd");
            }
            catch
            {
                MessageBox.Show("Geçerli bir taih giriniz.");
                connection.Close();
                return;
            }

            command.Parameters.AddWithValue("baslangicTarihi", baslangicTarihi);
            command.Parameters.AddWithValue("bitisTarihi", bitisTarihi);

            try
            {
               NpgsqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                gridReceteler.DataSource = table;
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

            connection.Close();
        }

        private void ReceteListesi_Load(object sender, EventArgs e) {}
    }
}
