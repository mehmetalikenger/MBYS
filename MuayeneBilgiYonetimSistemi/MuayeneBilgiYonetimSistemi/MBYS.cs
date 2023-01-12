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
    public partial class MBYS : Form
    {
        public MBYS()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MBYS; user Id=postgres; password=12345");

        private void HastalariListele()
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.WhiteSmoke;           

            connection.Open();

            string sorgu = "SELECT hastalar.ad, hastalar.soyad, muayeneler.tarih, muayeneler.zaman FROM hastalar " +
                           "INNER JOIN muayeneler ON hastalar.tc = muayeneler.hasta_tc " +
                            "WHERE muayeneler.durum = 'Oluşturuldu'" +
                            "ORDER BY tarih;";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);
            NpgsqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridHastalar.DataSource = table;

            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HastalariListele();
        }

        private void ilaçBilgileriToolStripMenuItem_Click(object sender, EventArgs e)  { }

        private void btnHastaKaydet_Click(object sender, EventArgs e)
        {
            HastaKaydet hastaKaydet = new HastaKaydet();
            hastaKaydet.Show();
        }

        private void btnMuayeneKaydet_Click(object sender, EventArgs e)
        {
            MuayeneKaydet muayeneKaydet = new MuayeneKaydet();
            muayeneKaydet.Show();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hastaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaBilgileri bilgiler = new HastaBilgileri();
            bilgiler.Show();
        }

        private void dataGridHastalar_CellContentClick(object sender, DataGridViewCellEventArgs e)  { }

        private void listeyiYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastalariListele();
        }

        private void btnMuayeneOlustur_Click(object sender, EventArgs e)
        {
            MuayeneOlustur olustur = new MuayeneOlustur();
            olustur.Show();
        }

        private void ilaçKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IlacKaydet ilac = new IlacKaydet();
            ilac.Show();
        }

        private void reçeteleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceteListesi liste = new ReceteListesi();
            liste.Show();
        }

        private void ilaçBilgileriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            IlacBilgileri bilgiler = new IlacBilgileri();
            bilgiler.Show();
        }

        private void btnMuayeneKayit_Click(object sender, EventArgs e)
        {
            MuayeneKayitlari kayitlar = new MuayeneKayitlari();
            kayitlar.Show();
        }

        private void btnMuayeneIptalEt_Click(object sender, EventArgs e)
        {
            MuayeneIptalEt iptal = new MuayeneIptalEt();
            iptal.Show();
        }
    }
}
