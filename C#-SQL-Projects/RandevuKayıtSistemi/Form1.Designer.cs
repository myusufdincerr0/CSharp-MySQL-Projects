namespace uygulamam1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKayıtlıRandevularım = new System.Windows.Forms.Button();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpRandevuSaat = new System.Windows.Forms.DateTimePicker();
            this.txttelNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpRandevuGunu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.txttckimlik = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKayıtlıRandevularım);
            this.groupBox1.Controls.Add(this.btnRandevuAl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpRandevuSaat);
            this.groupBox1.Controls.Add(this.txttelNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpRandevuGunu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDogumtarihi);
            this.groupBox1.Controls.Add(this.txttckimlik);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(369, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Kayıt Bilgileri";
            // 
            // btnKayıtlıRandevularım
            // 
            this.btnKayıtlıRandevularım.Location = new System.Drawing.Point(323, 360);
            this.btnKayıtlıRandevularım.Name = "btnKayıtlıRandevularım";
            this.btnKayıtlıRandevularım.Size = new System.Drawing.Size(242, 41);
            this.btnKayıtlıRandevularım.TabIndex = 16;
            this.btnKayıtlıRandevularım.Text = "Kayıtlı Randevularım";
            this.btnKayıtlıRandevularım.UseVisualStyleBackColor = true;
            this.btnKayıtlıRandevularım.Click += new System.EventHandler(this.btnKayıtlıRandevularım_Click);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Location = new System.Drawing.Point(64, 360);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(207, 41);
            this.btnRandevuAl.TabIndex = 15;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Randevu Saati Seçiniz:";
            // 
            // dtpRandevuSaat
            // 
            this.dtpRandevuSaat.CustomFormat = "HH:mm";
            this.dtpRandevuSaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRandevuSaat.Location = new System.Drawing.Point(269, 299);
            this.dtpRandevuSaat.Name = "dtpRandevuSaat";
            this.dtpRandevuSaat.ShowUpDown = true;
            this.dtpRandevuSaat.Size = new System.Drawing.Size(247, 29);
            this.dtpRandevuSaat.TabIndex = 13;
            // 
            // txttelNo
            // 
            this.txttelNo.Location = new System.Drawing.Point(293, 134);
            this.txttelNo.Name = "txttelNo";
            this.txttelNo.Size = new System.Drawing.Size(386, 29);
            this.txttelNo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefon Numaranızı Giriniz:";
            // 
            // dtpRandevuGunu
            // 
            this.dtpRandevuGunu.Location = new System.Drawing.Point(370, 257);
            this.dtpRandevuGunu.Name = "dtpRandevuGunu";
            this.dtpRandevuGunu.Size = new System.Drawing.Size(309, 29);
            this.dtpRandevuGunu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Randevu ya uygun bir gün seçin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doğum Tarihiniz:";
            // 
            // dtpDogumtarihi
            // 
            this.dtpDogumtarihi.Location = new System.Drawing.Point(199, 218);
            this.dtpDogumtarihi.Name = "dtpDogumtarihi";
            this.dtpDogumtarihi.Size = new System.Drawing.Size(200, 29);
            this.dtpDogumtarihi.TabIndex = 7;
            // 
            // txttckimlik
            // 
            this.txttckimlik.Location = new System.Drawing.Point(164, 173);
            this.txttckimlik.Name = "txttckimlik";
            this.txttckimlik.Size = new System.Drawing.Size(470, 29);
            this.txttckimlik.TabIndex = 6;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(209, 93);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(470, 29);
            this.txtsoyad.TabIndex = 5;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(187, 46);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(470, 29);
            this.txtad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tc Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "SoyAdınızı Giriniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adınızı Giriniz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 640);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpRandevuGunu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDogumtarihi;
        private System.Windows.Forms.TextBox txttckimlik;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txttelNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRandevuSaat;
        private System.Windows.Forms.Button btnKayıtlıRandevularım;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Label label7;
    }
}

