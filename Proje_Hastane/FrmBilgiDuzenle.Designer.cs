﻿namespace Proje_Hastane
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.BtnBilgiGüncelle = new System.Windows.Forms.Button();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBilgiGüncelle
            // 
            this.BtnBilgiGüncelle.BackColor = System.Drawing.Color.Red;
            this.BtnBilgiGüncelle.Location = new System.Drawing.Point(199, 300);
            this.BtnBilgiGüncelle.Name = "BtnBilgiGüncelle";
            this.BtnBilgiGüncelle.Size = new System.Drawing.Size(134, 35);
            this.BtnBilgiGüncelle.TabIndex = 31;
            this.BtnBilgiGüncelle.Text = "Güncelle";
            this.BtnBilgiGüncelle.UseVisualStyleBackColor = false;
            this.BtnBilgiGüncelle.Click += new System.EventHandler(this.BtnBilgiGüncelle_Click);
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(199, 263);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(134, 32);
            this.CmbCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Şifre: ";
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(199, 166);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(134, 29);
            this.MskTel.TabIndex = 4;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(199, 34);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(134, 29);
            this.TxtAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ad: ";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(199, 77);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(134, 29);
            this.TxtSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Soyad: ";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(199, 214);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(134, 29);
            this.TxtSifre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Telefon Numarası: ";
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(199, 123);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(134, 29);
            this.MskTc.TabIndex = 3;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cinsiyet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "TC Kimlik No: ";
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.BtnBilgiGüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(373, 360);
            this.Controls.Add(this.BtnBilgiGüncelle);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MskTel);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBilgiGüncelle;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}