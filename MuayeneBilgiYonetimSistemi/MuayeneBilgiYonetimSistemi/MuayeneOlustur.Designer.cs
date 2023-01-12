namespace MuayeneBilgiYonetimSistemi
{
    partial class MuayeneOlustur
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoxSaat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMuayeneTarihi = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // txtTC
            // 
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC.Location = new System.Drawing.Point(155, 35);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(139, 24);
            this.txtTC.TabIndex = 1;
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlustur.Location = new System.Drawing.Point(219, 191);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 32);
            this.btnOlustur.TabIndex = 3;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Muayene Tarihi:";
            // 
            // cbBoxSaat
            // 
            this.cbBoxSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxSaat.FormattingEnabled = true;
            this.cbBoxSaat.Items.AddRange(new object[] {
            "09:00",
            "09:20",
            "09:40",
            "10:00",
            "10:20",
            "10:40",
            "11:00",
            "11:20",
            "11:40",
            "12:00",
            "13:00",
            "13:20",
            "13:40",
            "14:00",
            "14:20",
            "14:40",
            "15:00",
            "15:20",
            "15:40",
            "16:00",
            "16:20",
            "16:40",
            "17:00"});
            this.cbBoxSaat.Location = new System.Drawing.Point(155, 141);
            this.cbBoxSaat.Name = "cbBoxSaat";
            this.cbBoxSaat.Size = new System.Drawing.Size(139, 26);
            this.cbBoxSaat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Muayene Saati:";
            // 
            // txtMuayeneTarihi
            // 
            this.txtMuayeneTarihi.AsciiOnly = true;
            this.txtMuayeneTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMuayeneTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuayeneTarihi.Location = new System.Drawing.Point(155, 86);
            this.txtMuayeneTarihi.Mask = "00-00-0000";
            this.txtMuayeneTarihi.Name = "txtMuayeneTarihi";
            this.txtMuayeneTarihi.Size = new System.Drawing.Size(139, 24);
            this.txtMuayeneTarihi.TabIndex = 2;
            // 
            // MuayeneOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 254);
            this.Controls.Add(this.txtMuayeneTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBoxSaat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label1);
            this.Name = "MuayeneOlustur";
            this.Text = "Muayene Oluştur";
            this.Load += new System.EventHandler(this.MuayeneOlustur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBoxSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtMuayeneTarihi;
    }
}