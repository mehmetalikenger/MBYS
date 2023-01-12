namespace MuayeneBilgiYonetimSistemi
{
    partial class MBYS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeyiYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridHastalar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMuayeneIptalEt = new System.Windows.Forms.Button();
            this.btnMuayeneKayit = new System.Windows.Forms.Button();
            this.btnMuayeneOlustur = new System.Windows.Forms.Button();
            this.btnHastaKaydet = new System.Windows.Forms.Button();
            this.btnMuayeneKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHastalar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaBilgileriToolStripMenuItem,
            this.reçeteleriListeleToolStripMenuItem,
            this.ilaçKaydetToolStripMenuItem,
            this.ilaçBilgileriToolStripMenuItem,
            this.listeyiYenileToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaBilgileriToolStripMenuItem
            // 
            this.hastaBilgileriToolStripMenuItem.Name = "hastaBilgileriToolStripMenuItem";
            this.hastaBilgileriToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.hastaBilgileriToolStripMenuItem.Text = "Hasta Bilgileri";
            this.hastaBilgileriToolStripMenuItem.Click += new System.EventHandler(this.hastaBilgileriToolStripMenuItem_Click);
            // 
            // reçeteleriListeleToolStripMenuItem
            // 
            this.reçeteleriListeleToolStripMenuItem.Name = "reçeteleriListeleToolStripMenuItem";
            this.reçeteleriListeleToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.reçeteleriListeleToolStripMenuItem.Text = "Reçeteleri Listele";
            this.reçeteleriListeleToolStripMenuItem.Click += new System.EventHandler(this.reçeteleriListeleToolStripMenuItem_Click);
            // 
            // ilaçKaydetToolStripMenuItem
            // 
            this.ilaçKaydetToolStripMenuItem.Name = "ilaçKaydetToolStripMenuItem";
            this.ilaçKaydetToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ilaçKaydetToolStripMenuItem.Text = "İlaç Kaydet";
            this.ilaçKaydetToolStripMenuItem.Click += new System.EventHandler(this.ilaçKaydetToolStripMenuItem_Click);
            // 
            // ilaçBilgileriToolStripMenuItem
            // 
            this.ilaçBilgileriToolStripMenuItem.Name = "ilaçBilgileriToolStripMenuItem";
            this.ilaçBilgileriToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.ilaçBilgileriToolStripMenuItem.Text = "İlaç Bilgileri";
            this.ilaçBilgileriToolStripMenuItem.Click += new System.EventHandler(this.ilaçBilgileriToolStripMenuItem_Click_1);
            // 
            // listeyiYenileToolStripMenuItem
            // 
            this.listeyiYenileToolStripMenuItem.Name = "listeyiYenileToolStripMenuItem";
            this.listeyiYenileToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.listeyiYenileToolStripMenuItem.Text = "Listeyi Yenile";
            this.listeyiYenileToolStripMenuItem.Click += new System.EventHandler(this.listeyiYenileToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // dataGridHastalar
            // 
            this.dataGridHastalar.AllowUserToAddRows = false;
            this.dataGridHastalar.AllowUserToDeleteRows = false;
            this.dataGridHastalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHastalar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHastalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridHastalar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridHastalar.Location = new System.Drawing.Point(227, 88);
            this.dataGridHastalar.Name = "dataGridHastalar";
            this.dataGridHastalar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHastalar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridHastalar.Size = new System.Drawing.Size(356, 340);
            this.dataGridHastalar.TabIndex = 3;
            this.dataGridHastalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHastalar_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMuayeneIptalEt);
            this.panel1.Controls.Add(this.btnMuayeneKayit);
            this.panel1.Controls.Add(this.btnMuayeneOlustur);
            this.panel1.Controls.Add(this.btnHastaKaydet);
            this.panel1.Controls.Add(this.btnMuayeneKaydet);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 389);
            this.panel1.TabIndex = 4;
            // 
            // btnMuayeneIptalEt
            // 
            this.btnMuayeneIptalEt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMuayeneIptalEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuayeneIptalEt.Location = new System.Drawing.Point(17, 220);
            this.btnMuayeneIptalEt.Name = "btnMuayeneIptalEt";
            this.btnMuayeneIptalEt.Size = new System.Drawing.Size(164, 30);
            this.btnMuayeneIptalEt.TabIndex = 5;
            this.btnMuayeneIptalEt.Text = "Muayene İptal Et";
            this.btnMuayeneIptalEt.UseVisualStyleBackColor = false;
            this.btnMuayeneIptalEt.Click += new System.EventHandler(this.btnMuayeneIptalEt_Click);
            // 
            // btnMuayeneKayit
            // 
            this.btnMuayeneKayit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMuayeneKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuayeneKayit.Location = new System.Drawing.Point(17, 168);
            this.btnMuayeneKayit.Name = "btnMuayeneKayit";
            this.btnMuayeneKayit.Size = new System.Drawing.Size(164, 30);
            this.btnMuayeneKayit.TabIndex = 4;
            this.btnMuayeneKayit.Text = "Muayene Kaydı Görüntüle";
            this.btnMuayeneKayit.UseVisualStyleBackColor = false;
            this.btnMuayeneKayit.Click += new System.EventHandler(this.btnMuayeneKayit_Click);
            // 
            // btnMuayeneOlustur
            // 
            this.btnMuayeneOlustur.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMuayeneOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuayeneOlustur.Location = new System.Drawing.Point(17, 66);
            this.btnMuayeneOlustur.Name = "btnMuayeneOlustur";
            this.btnMuayeneOlustur.Size = new System.Drawing.Size(164, 30);
            this.btnMuayeneOlustur.TabIndex = 2;
            this.btnMuayeneOlustur.Text = "Muayene Oluştur";
            this.btnMuayeneOlustur.UseVisualStyleBackColor = false;
            this.btnMuayeneOlustur.Click += new System.EventHandler(this.btnMuayeneOlustur_Click);
            // 
            // btnHastaKaydet
            // 
            this.btnHastaKaydet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHastaKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaKaydet.Location = new System.Drawing.Point(17, 17);
            this.btnHastaKaydet.Name = "btnHastaKaydet";
            this.btnHastaKaydet.Size = new System.Drawing.Size(164, 30);
            this.btnHastaKaydet.TabIndex = 1;
            this.btnHastaKaydet.Text = "Hasta Kaydet";
            this.btnHastaKaydet.UseVisualStyleBackColor = false;
            this.btnHastaKaydet.Click += new System.EventHandler(this.btnHastaKaydet_Click);
            // 
            // btnMuayeneKaydet
            // 
            this.btnMuayeneKaydet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMuayeneKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuayeneKaydet.Location = new System.Drawing.Point(17, 116);
            this.btnMuayeneKaydet.Name = "btnMuayeneKaydet";
            this.btnMuayeneKaydet.Size = new System.Drawing.Size(164, 30);
            this.btnMuayeneKaydet.TabIndex = 3;
            this.btnMuayeneKaydet.Text = "Muayene Kaydet";
            this.btnMuayeneKaydet.UseVisualStyleBackColor = false;
            this.btnMuayeneKaydet.Click += new System.EventHandler(this.btnMuayeneKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Muayene Listesi";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(227, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 50);
            this.panel2.TabIndex = 7;
            // 
            // MBYS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(595, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridHastalar);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MBYS";
            this.Text = "Muayene Bilgi Yönetim Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHastalar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridHastalar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMuayeneKaydet;
        private System.Windows.Forms.Button btnHastaKaydet;
        private System.Windows.Forms.ToolStripMenuItem hastaBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reçeteleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeyiYenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.Button btnMuayeneOlustur;
        private System.Windows.Forms.ToolStripMenuItem ilaçKaydetToolStripMenuItem;
        private System.Windows.Forms.Button btnMuayeneKayit;
        private System.Windows.Forms.Button btnMuayeneIptalEt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

