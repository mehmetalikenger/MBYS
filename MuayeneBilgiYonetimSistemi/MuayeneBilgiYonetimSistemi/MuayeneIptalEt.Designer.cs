namespace MuayeneBilgiYonetimSistemi
{
    partial class MuayeneIptalEt
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMuayeneTarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Location = new System.Drawing.Point(217, 125);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(80, 30);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Muayene Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "TC Kimlik No:";
            // 
            // txtMuayeneTarihi
            // 
            this.txtMuayeneTarihi.AsciiOnly = true;
            this.txtMuayeneTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMuayeneTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuayeneTarihi.Location = new System.Drawing.Point(158, 78);
            this.txtMuayeneTarihi.Mask = "00-00-0000";
            this.txtMuayeneTarihi.Name = "txtMuayeneTarihi";
            this.txtMuayeneTarihi.Size = new System.Drawing.Size(139, 24);
            this.txtMuayeneTarihi.TabIndex = 2;
            // 
            // txtTC
            // 
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC.Location = new System.Drawing.Point(158, 35);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(139, 24);
            this.txtTC.TabIndex = 1;
            // 
            // MuayeneIptalEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 188);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtMuayeneTarihi);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "MuayeneIptalEt";
            this.Text = "Muayene İptal Et";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtMuayeneTarihi;
        private System.Windows.Forms.TextBox txtTC;
    }
}