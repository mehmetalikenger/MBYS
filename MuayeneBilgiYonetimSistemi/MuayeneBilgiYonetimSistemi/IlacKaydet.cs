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
    public partial class IlacKaydet : Form
    {
        public IlacKaydet()
        {
            InitializeComponent();
        }


        private bool BosAlanKontrol()
        {
            bool allTextBoxesEmpty = this.Controls.OfType<TextBox>().Any(t => t.Text == "");

            if (allTextBoxesEmpty)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }

            return true;
        }

        private void EkraniSifirla()
        {
            txtAd.Text = "";
            txtBarkod.Text = "";
            txtTip.Text = "";
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!BosAlanKontrol())
            {
                return;
            }

            NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MBYS; user Id=postgres; password=12345");
            connection.Open();

            string sorgu = "INSERT INTO ilaclar VALUES(@kod, @ad, @tip);";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@kod", txtBarkod.Text);
            command.Parameters.AddWithValue("@ad", txtAd.Text);
            command.Parameters.AddWithValue("@tip", txtTip.Text);

            try
            {

                command.ExecuteNonQuery();
            }
            catch (Npgsql.PostgresException ex)
            {

                if (ex.SqlState == "23505")
                {
                    MessageBox.Show("İlaç zaten kayıtlı.");
                    connection.Close();
                    return;
                }
                else
                {
                    throw;
                }
            }

            MessageBox.Show("İlaç kaydedildi.");
            EkraniSifirla();
            connection.Close();
        }
    }
}
