namespace MuayeneBilgiYonetimSistemi
{
    partial class HastaBilgileri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReceteListele = new System.Windows.Forms.Button();
            this.dataGridReceteler = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHastaSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.cbMedeniDurum = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridIlaclar = new System.Windows.Forms.DataGridView();
            this.btnIlacListele = new System.Windows.Forms.Button();
            this.txtReceteKoduListe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtSilinecekRecete = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceteler)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIlaclar)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // txtTC
            // 
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC.Location = new System.Drawing.Point(160, 21);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(146, 22);
            this.txtTC.TabIndex = 1;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoruntule.Location = new System.Drawing.Point(223, 59);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(83, 32);
            this.btnGoruntule.TabIndex = 2;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = false;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGoruntule);
            this.panel1.Location = new System.Drawing.Point(29, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 109);
            this.panel1.TabIndex = 33;
            // 
            // btnReceteListele
            // 
            this.btnReceteListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReceteListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceteListele.Location = new System.Drawing.Point(258, 220);
            this.btnReceteListele.Name = "btnReceteListele";
            this.btnReceteListele.Size = new System.Drawing.Size(74, 29);
            this.btnReceteListele.TabIndex = 12;
            this.btnReceteListele.Text = "Listele";
            this.btnReceteListele.UseVisualStyleBackColor = false;
            this.btnReceteListele.Click += new System.EventHandler(this.btnReceteListele_Click);
            // 
            // dataGridReceteler
            // 
            this.dataGridReceteler.AllowUserToAddRows = false;
            this.dataGridReceteler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReceteler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReceteler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridReceteler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridReceteler.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridReceteler.Location = new System.Drawing.Point(16, 53);
            this.dataGridReceteler.Name = "dataGridReceteler";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReceteler.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridReceteler.Size = new System.Drawing.Size(317, 150);
            this.dataGridReceteler.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnReceteListele);
            this.panel2.Controls.Add(this.dataGridReceteler);
            this.panel2.Location = new System.Drawing.Point(435, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 265);
            this.panel2.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(137, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "Reçeteler";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtDogumTarihi);
            this.panel3.Controls.Add(this.btnHastaSil);
            this.panel3.Controls.Add(this.btnDuzenle);
            this.panel3.Controls.Add(this.cbMedeniDurum);
            this.panel3.Controls.Add(this.btnKaydet);
            this.panel3.Controls.Add(this.txtAdres);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtTelefon);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtDogumYeri);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtSoyad);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtAd);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(29, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 531);
            this.panel3.TabIndex = 37;
            // 
            // btnHastaSil
            // 
            this.btnHastaSil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHastaSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaSil.Location = new System.Drawing.Point(64, 447);
            this.btnHastaSil.Name = "btnHastaSil";
            this.btnHastaSil.Size = new System.Drawing.Size(79, 29);
            this.btnHastaSil.TabIndex = 46;
            this.btnHastaSil.Text = "Sil";
            this.btnHastaSil.UseVisualStyleBackColor = false;
            this.btnHastaSil.Click += new System.EventHandler(this.btnHastaSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Location = new System.Drawing.Point(160, 447);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(79, 29);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // cbMedeniDurum
            // 
            this.cbMedeniDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedeniDurum.Enabled = false;
            this.cbMedeniDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedeniDurum.FormattingEnabled = true;
            this.cbMedeniDurum.Items.AddRange(new object[] {
            "Bekar",
            "Evli"});
            this.cbMedeniDurum.Location = new System.Drawing.Point(160, 231);
            this.cbMedeniDurum.Name = "cbMedeniDurum";
            this.cbMedeniDurum.Size = new System.Drawing.Size(176, 24);
            this.cbMedeniDurum.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(257, 447);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(79, 29);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdres.Enabled = false;
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(160, 320);
            this.txtAdres.MaxLength = 115;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(176, 102);
            this.txtAdres.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(21, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Adres:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefon.Enabled = false;
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(160, 276);
            this.txtTelefon.MaxLength = 10;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(176, 22);
            this.txtTelefon.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(21, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(21, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Medeni Durumu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(21, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Doğum Yeri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(21, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.Location = new System.Drawing.Point(160, 94);
            this.txtSoyad.MaxLength = 20;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(176, 22);
            this.txtSoyad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Enabled = false;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(160, 50);
            this.txtAd.MaxLength = 30;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(176, 22);
            this.txtAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ad:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridIlaclar);
            this.panel4.Controls.Add(this.btnIlacListele);
            this.panel4.Controls.Add(this.txtReceteKoduListe);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(435, 394);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(352, 296);
            this.panel4.TabIndex = 38;
            // 
            // dataGridIlaclar
            // 
            this.dataGridIlaclar.AllowUserToAddRows = false;
            this.dataGridIlaclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridIlaclar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIlaclar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridIlaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridIlaclar.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridIlaclar.Location = new System.Drawing.Point(16, 123);
            this.dataGridIlaclar.Name = "dataGridIlaclar";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIlaclar.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridIlaclar.Size = new System.Drawing.Size(317, 150);
            this.dataGridIlaclar.TabIndex = 15;
            // 
            // btnIlacListele
            // 
            this.btnIlacListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIlacListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIlacListele.Location = new System.Drawing.Point(269, 68);
            this.btnIlacListele.Name = "btnIlacListele";
            this.btnIlacListele.Size = new System.Drawing.Size(58, 29);
            this.btnIlacListele.TabIndex = 14;
            this.btnIlacListele.Text = "Listele";
            this.btnIlacListele.UseVisualStyleBackColor = false;
            this.btnIlacListele.Click += new System.EventHandler(this.btnIlacListele_Click);
            // 
            // txtReceteKoduListe
            // 
            this.txtReceteKoduListe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceteKoduListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceteKoduListe.Location = new System.Drawing.Point(124, 72);
            this.txtReceteKoduListe.MaxLength = 10;
            this.txtReceteKoduListe.Name = "txtReceteKoduListe";
            this.txtReceteKoduListe.Size = new System.Drawing.Size(127, 22);
            this.txtReceteKoduListe.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(13, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Reçete Kodu: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(114, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Reçete İlaçları";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CadetBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnSil);
            this.panel5.Controls.Add(this.txtSilinecekRecete);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(435, 316);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(352, 54);
            this.panel5.TabIndex = 39;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(269, 13);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(58, 27);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtSilinecekRecete
            // 
            this.txtSilinecekRecete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSilinecekRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSilinecekRecete.Location = new System.Drawing.Point(119, 17);
            this.txtSilinecekRecete.MaxLength = 10;
            this.txtSilinecekRecete.Name = "txtSilinecekRecete";
            this.txtSilinecekRecete.Size = new System.Drawing.Size(132, 22);
            this.txtSilinecekRecete.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(14, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Reçete Kodu: ";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDogumYeri.Enabled = false;
            this.txtDogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDogumYeri.Location = new System.Drawing.Point(160, 184);
            this.txtDogumYeri.MaxLength = 20;
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(176, 22);
            this.txtDogumYeri.TabIndex = 6;
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.AsciiOnly = true;
            this.txtDogumTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDogumTarihi.Enabled = false;
            this.txtDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDogumTarihi.Location = new System.Drawing.Point(160, 141);
            this.txtDogumTarihi.Mask = "00-00-0000";
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(176, 21);
            this.txtDogumTarihi.TabIndex = 5;
            // 
            // HastaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 714);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HastaBilgileri";
            this.Text = "Hasta Bilgileri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceteler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIlaclar)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReceteListele;
        private System.Windows.Forms.DataGridView dataGridReceteler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbMedeniDurum;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtReceteKoduListe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnIlacListele;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtSilinecekRecete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnHastaSil;
        private System.Windows.Forms.DataGridView dataGridIlaclar;
        private System.Windows.Forms.MaskedTextBox txtDogumTarihi;
        private System.Windows.Forms.TextBox txtDogumYeri;
    }
}