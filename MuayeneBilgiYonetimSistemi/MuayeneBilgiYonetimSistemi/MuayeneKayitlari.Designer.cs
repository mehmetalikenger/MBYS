namespace MuayeneBilgiYonetimSistemi
{
    partial class MuayeneKayitlari
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTarih = new System.Windows.Forms.MaskedTextBox();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTedavi = new System.Windows.Forms.TextBox();
            this.txtTani = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOyku = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTarih);
            this.panel1.Controls.Add(this.btnGoruntule);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 66);
            this.panel1.TabIndex = 45;
            // 
            // txtTarih
            // 
            this.txtTarih.AsciiOnly = true;
            this.txtTarih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarih.Location = new System.Drawing.Point(404, 19);
            this.txtTarih.Mask = "00-00-0000";
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(139, 24);
            this.txtTarih.TabIndex = 2;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoruntule.Location = new System.Drawing.Point(570, 16);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(80, 30);
            this.btnGoruntule.TabIndex = 3;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = false;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(280, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Muayene Tarihi:";
            // 
            // txtTC
            // 
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC.Location = new System.Drawing.Point(124, 20);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(135, 22);
            this.txtTC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "TC Kimlik No:";
            // 
            // txtTedavi
            // 
            this.txtTedavi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTedavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTedavi.Location = new System.Drawing.Point(147, 464);
            this.txtTedavi.MaxLength = 500;
            this.txtTedavi.Multiline = true;
            this.txtTedavi.Name = "txtTedavi";
            this.txtTedavi.ReadOnly = true;
            this.txtTedavi.Size = new System.Drawing.Size(561, 122);
            this.txtTedavi.TabIndex = 6;
            // 
            // txtTani
            // 
            this.txtTani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTani.Location = new System.Drawing.Point(147, 295);
            this.txtTani.MaxLength = 250;
            this.txtTani.Multiline = true;
            this.txtTani.Name = "txtTani";
            this.txtTani.ReadOnly = true;
            this.txtTani.Size = new System.Drawing.Size(561, 123);
            this.txtTani.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tedavi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tanı:";
            // 
            // txtOyku
            // 
            this.txtOyku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOyku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOyku.Location = new System.Drawing.Point(147, 131);
            this.txtOyku.MaxLength = 250;
            this.txtOyku.Multiline = true;
            this.txtOyku.Name = "txtOyku";
            this.txtOyku.ReadOnly = true;
            this.txtOyku.Size = new System.Drawing.Size(561, 121);
            this.txtOyku.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Öyküsü:";
            // 
            // MuayeneKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTedavi);
            this.Controls.Add(this.txtTani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOyku);
            this.Controls.Add(this.label5);
            this.Name = "MuayeneKayitlari";
            this.Text = "Muayene Kayıtları";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTedavi;
        private System.Windows.Forms.TextBox txtTani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOyku;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTarih;
    }
}