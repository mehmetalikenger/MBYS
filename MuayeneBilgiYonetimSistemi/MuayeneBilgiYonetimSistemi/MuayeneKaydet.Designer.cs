namespace MuayeneBilgiYonetimSistemi
{
    partial class MuayeneKaydet
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOyku = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTani = new System.Windows.Forms.TextBox();
            this.txtTedavi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceteYaz = new System.Windows.Forms.Button();
            this.btnHastaGelmedi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(487, 597);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(97, 32);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Öyküsü:";
            // 
            // txtOyku
            // 
            this.txtOyku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOyku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOyku.Location = new System.Drawing.Point(142, 123);
            this.txtOyku.MaxLength = 250;
            this.txtOyku.Multiline = true;
            this.txtOyku.Name = "txtOyku";
            this.txtOyku.Size = new System.Drawing.Size(442, 124);
            this.txtOyku.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tanı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tedavi:";
            // 
            // txtTani
            // 
            this.txtTani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTani.Location = new System.Drawing.Point(142, 280);
            this.txtTani.MaxLength = 250;
            this.txtTani.Multiline = true;
            this.txtTani.Name = "txtTani";
            this.txtTani.Size = new System.Drawing.Size(442, 128);
            this.txtTani.TabIndex = 4;
            // 
            // txtTedavi
            // 
            this.txtTedavi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTedavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTedavi.Location = new System.Drawing.Point(142, 443);
            this.txtTedavi.MaxLength = 500;
            this.txtTedavi.Multiline = true;
            this.txtTedavi.Name = "txtTedavi";
            this.txtTedavi.Size = new System.Drawing.Size(442, 124);
            this.txtTedavi.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReceteYaz);
            this.panel1.Location = new System.Drawing.Point(32, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 66);
            this.panel1.TabIndex = 36;
            // 
            // txtTC
            // 
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC.Location = new System.Drawing.Point(137, 22);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(176, 22);
            this.txtTC.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "TC Kimlik No:";
            // 
            // btnReceteYaz
            // 
            this.btnReceteYaz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReceteYaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceteYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceteYaz.Location = new System.Drawing.Point(405, 16);
            this.btnReceteYaz.Name = "btnReceteYaz";
            this.btnReceteYaz.Size = new System.Drawing.Size(123, 32);
            this.btnReceteYaz.TabIndex = 49;
            this.btnReceteYaz.Text = "Reçete Yaz";
            this.btnReceteYaz.UseVisualStyleBackColor = false;
            this.btnReceteYaz.Click += new System.EventHandler(this.btnReceteYaz_Click);
            // 
            // btnHastaGelmedi
            // 
            this.btnHastaGelmedi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHastaGelmedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaGelmedi.Location = new System.Drawing.Point(350, 597);
            this.btnHastaGelmedi.Name = "btnHastaGelmedi";
            this.btnHastaGelmedi.Size = new System.Drawing.Size(97, 32);
            this.btnHastaGelmedi.TabIndex = 37;
            this.btnHastaGelmedi.Text = "Hasta Gelmedi";
            this.btnHastaGelmedi.UseVisualStyleBackColor = false;
            this.btnHastaGelmedi.Click += new System.EventHandler(this.btnHastaGelmedi_Click);
            // 
            // MuayeneKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 662);
            this.Controls.Add(this.btnHastaGelmedi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTedavi);
            this.Controls.Add(this.txtTani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOyku);
            this.Controls.Add(this.label5);
            this.Name = "MuayeneKaydet";
            this.Text = "Muayene Kaydet";
            this.Load += new System.EventHandler(this.MuayeneKaydet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOyku;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTani;
        private System.Windows.Forms.TextBox txtTedavi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceteYaz;
        private System.Windows.Forms.Button btnHastaGelmedi;
    }
}