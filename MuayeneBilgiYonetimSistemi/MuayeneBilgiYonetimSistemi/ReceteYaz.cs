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
    public partial class ReceteYaz : Form
    {
        public ReceteYaz()
        {
            InitializeComponent();
        }


        private bool BosAlanKontrol()
        {
            bool allTextBoxesEmpty = panel1.Controls.OfType<TextBox>().All(t => string.IsNullOrEmpty(t.Text));
            bool allComboBoxesNotSelected = panel1.Controls.OfType<ComboBox>().All(c => c.SelectedIndex == -1);

            if (allComboBoxesNotSelected)
            {
                MessageBox.Show("Lütfen en az 1 ilaç seçiniz.");
                return false;
            }

            if (allTextBoxesEmpty)
            {
                MessageBox.Show("Lütfen adet giriniz.");
                return false;
            }     

            return true;
        }


        private bool ReceteDogrula()
        {
            int nullOlmayanTextBoxSayisi = 0;
            int nullOlmayanComboBoxSayisi = 0;

            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox && ((TextBox)c).Text != "")
                {
                    nullOlmayanTextBoxSayisi++;

                    if(Convert.ToInt32(c.Text) > 3)
                    {
                        MessageBox.Show("Bir ilaç için en fazla 3 adet yazabilirsiniz.");
                        return false;
                    }

                    else if(Convert.ToInt32(c.Text) <= 0)
                    {
                        MessageBox.Show("Lütfen geçerli adet giriniz.");
                        return false;
                    }
                }

                if (c is ComboBox && ((ComboBox)c).Text != "")
                {
                    nullOlmayanComboBoxSayisi++;
                }
            }          

            if(nullOlmayanTextBoxSayisi > nullOlmayanComboBoxSayisi)
            {
                MessageBox.Show("Seçilmeyen ilaçlar için adet grilemez.");
                return false;
            }

            if (nullOlmayanTextBoxSayisi < nullOlmayanComboBoxSayisi)
            {
                MessageBox.Show("Seçtiğiniz ilaçlar için adet belirtiniz.");
                return false;
            }

            return true;
        }


        public bool AyniIlacKontrol(string[] ilacKodlari)
        {
            int i;
            int j;

            for(i = 0; i < 5; i++)
            {
                for(j = i+1; j < 5; j++)
                {
                    if (ilacKodlari[i] == ilacKodlari[j] && ilacKodlari[i] != null)
                    {
                        MessageBox.Show("Aynı ilaç tekrar seçilemez.");
                        return false;
                    }
                }
            }

            return true;
        }


        public string[] IlacKodlariniAl()
        {
            string[] ilacKodlari = new string[5];

            foreach (Control control in panel1.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox comboBox = control as ComboBox;

                    if (comboBox.SelectedIndex == -1)
                    {
                        continue;
                    }

                    string ilac = comboBox.SelectedItem.ToString();

                    int bosluk = ilac.IndexOf(' ');  

                    string ilacKod = ilac.Substring(0, bosluk); //ilaç kodu dışındaki karakterler string içinden siliniyor.
                    
                    int comboBoxIndex = Convert.ToInt32(comboBox.Name[comboBox.Name.Length - 1].ToString());
                    ilacKodlari[comboBoxIndex-1] = ilacKod;
                }
            }

            return ilacKodlari;
        }


        public int[] IlacAdetleriniAl()
        {
            int[] ilacAdetleri = new int[5];

            foreach (Control control in panel1.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;

                    if (textBox.Text == "")
                    {
                        continue;
                    }

                    int kod = Convert.ToInt32(textBox.Text);

                    int textBoxIndex = Convert.ToInt32(textBox.Name[textBox.Name.Length - 1].ToString());

                    ilacAdetleri[textBoxIndex-1] = kod;
                }
            }

            return ilacAdetleri;
        }

        private static long receteKod;
        public static bool ReceteSonucOK { get; set; } = false;

        public bool ReceteSonucOgren()
        {
            return ReceteSonucOK;
        }

        public void ReceteSonucDegistir()
        {
            ReceteSonucOK = false;
        }


        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MBYS; user Id=postgres; password=12345");


        public void ReceteKodunuHastalarTablosunaYaz(long receteKodu, long TCno)
        {
            connection.Open();

            string sorgu = "UPDATE muayeneler SET recete_kodu = " + receteKodu.ToString() + " WHERE hasta_tc = " + TCno + ";";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Reçete kodu yazılamadı.");
                return;
            }

            connection.Close();
        }


        private void ReceteYaz_Load(object sender, EventArgs e)
        {
            connection.Open();

            string sorgu = "SELECT * FROM ilaclar ORDER BY ad";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string barkod = reader.GetString(0);
                string ad = reader.GetString(1);
                string tip = reader.GetString(2);

                string ilac = barkod + " - " + ad + " - " + tip;

                foreach (Control control in panel1.Controls)
                {
                    if (control is ComboBox)
                    {
                        ComboBox comboBox = control as ComboBox;

                        comboBox.Items.Add(ilac);
                    }
                }
            }

            connection.Close();
        }


        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

            if (!ReceteDogrula())
            {
                return;
            }

            if (!BosAlanKontrol())
            {
                return;
            }

            MuayeneKaydet muayene = new MuayeneKaydet();
            long hastaTC = muayene.TCGetir();

            connection.Open();

            string sorgu = "INSERT INTO receteler " +
                           "VALUES(@recete_kodu, to_date(:tarih, 'YYYY-MM-DD'), @hasta_tc, @ilac_1_kod, @ilac_1_adet, @ilac_2_kod, @ilac_2_adet, @ilac_3_kod, @ilac_3_adet, @ilac_4_kod, @ilac_4_adet, @ilac_5_kod, @ilac_5_adet);";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);


            string[] ilacKodlari = IlacKodlariniAl();
            int[] ilacAdetleri = IlacAdetleriniAl();


            if (!AyniIlacKontrol(ilacKodlari))
            {
                connection.Close();
                return;
            }

            unchecked
            {
                Random random = new Random();
                receteKod = random.Next(1, (int)9999999999);
            }

            command.Parameters.AddWithValue("@recete_kodu", receteKod.ToString());
            command.Parameters.AddWithValue("@hasta_tc", hastaTC);

            DateTime now = DateTime.Now;
            string tarih = now.ToString("yyyy-MM-dd");

            command.Parameters.AddWithValue("tarih", tarih);

            string kodParametre;
            string adetParametre;


            for(int i = 0; i < 5; i++)
            {
                for(int j = i+1; j < 5; j++)
                {
                    if (ilacKodlari[i] == null && ilacKodlari[j] != null)
                    {
                        ilacKodlari[i] = ilacKodlari[j];
                        ilacKodlari[j] = null;
                    }

                    if (ilacAdetleri[i] == 0 && ilacAdetleri[j] != 0)
                    {
                        ilacAdetleri[i] = ilacAdetleri[j];
                        ilacAdetleri[j] = 0;
                    }
                }
            }


            for (int i = 1; i <= 5; i++)
            {
                if (ilacKodlari[i-1] == null)
                {
                    kodParametre = "@ilac_" + i + "_kod";
                    command.Parameters.AddWithValue(kodParametre, DBNull.Value);
                }
                else
                {
                    kodParametre = "@ilac_" + i + "_kod";
                    command.Parameters.AddWithValue(kodParametre, ilacKodlari[i - 1]);
                }             

                if (ilacAdetleri[i - 1].ToString() == null)
                {
                    adetParametre = "@ilac_" + i + "_adet";
                    command.Parameters.AddWithValue(adetParametre, DBNull.Value);
                }
                else
                {
                    adetParametre = "@ilac_" + i + "_adet";
                    command.Parameters.AddWithValue(adetParametre, ilacAdetleri[i - 1]);
                }               
            }

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

            MessageBox.Show("Reçete kaydedildi.");
            ReceteSonucOK = true;
            this.Close();
            connection.Close();

            ReceteKodunuHastalarTablosunaYaz(receteKod, hastaTC);
        }
    }
}
