namespace SSProject
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
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.cmbOgrenciListe = new System.Windows.Forms.ComboBox();
            this.tbListele = new System.Windows.Forms.TabPage();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblFinalNotu = new System.Windows.Forms.Label();
            this.lblVizeNotu = new System.Windows.Forms.Label();
            this.tbDers = new System.Windows.Forms.TabPage();
            this.lblKredi = new System.Windows.Forms.Label();
            this.lblDersKod = new System.Windows.Forms.Label();
            this.lblDersAd = new System.Windows.Forms.Label();
            this.lblOgrenciSec = new System.Windows.Forms.Label();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.nudFinal = new System.Windows.Forms.NumericUpDown();
            this.nudVize = new System.Windows.Forms.NumericUpDown();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.txtDersKod = new System.Windows.Forms.TextBox();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.cmbOgrenciler = new System.Windows.Forms.ComboBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.tpOgrenci = new System.Windows.Forms.TabControl();
            this.tbOgrenci = new System.Windows.Forms.TabPage();
            this.lblBolum = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            this.tbListele.SuspendLayout();
            this.tbDers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVize)).BeginInit();
            this.tpOgrenci.SuspendLayout();
            this.tbOgrenci.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDersler
            // 
            this.dgvDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersler.Location = new System.Drawing.Point(345, 73);
            this.dgvDersler.Name = "dgvDersler";
            this.dgvDersler.Size = new System.Drawing.Size(303, 207);
            this.dgvDersler.TabIndex = 2;
            // 
            // cmbOgrenciListe
            // 
            this.cmbOgrenciListe.FormattingEnabled = true;
            this.cmbOgrenciListe.Location = new System.Drawing.Point(96, 140);
            this.cmbOgrenciListe.Name = "cmbOgrenciListe";
            this.cmbOgrenciListe.Size = new System.Drawing.Size(164, 21);
            this.cmbOgrenciListe.TabIndex = 0;
            // 
            // tbListele
            // 
            this.tbListele.Controls.Add(this.dgvDersler);
            this.tbListele.Controls.Add(this.btnListele);
            this.tbListele.Controls.Add(this.cmbOgrenciListe);
            this.tbListele.Location = new System.Drawing.Point(4, 22);
            this.tbListele.Name = "tbListele";
            this.tbListele.Padding = new System.Windows.Forms.Padding(3);
            this.tbListele.Size = new System.Drawing.Size(788, 419);
            this.tbListele.TabIndex = 2;
            this.tbListele.Text = "Dersleri Listele";
            this.tbListele.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(129, 194);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(97, 23);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Dersleri Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblFinalNotu
            // 
            this.lblFinalNotu.AutoSize = true;
            this.lblFinalNotu.Location = new System.Drawing.Point(238, 275);
            this.lblFinalNotu.Name = "lblFinalNotu";
            this.lblFinalNotu.Size = new System.Drawing.Size(55, 13);
            this.lblFinalNotu.TabIndex = 12;
            this.lblFinalNotu.Text = "Final Notu";
            // 
            // lblVizeNotu
            // 
            this.lblVizeNotu.AutoSize = true;
            this.lblVizeNotu.Location = new System.Drawing.Point(238, 233);
            this.lblVizeNotu.Name = "lblVizeNotu";
            this.lblVizeNotu.Size = new System.Drawing.Size(53, 13);
            this.lblVizeNotu.TabIndex = 11;
            this.lblVizeNotu.Text = "Vize Notu";
            // 
            // tbDers
            // 
            this.tbDers.Controls.Add(this.lblFinalNotu);
            this.tbDers.Controls.Add(this.lblVizeNotu);
            this.tbDers.Controls.Add(this.lblKredi);
            this.tbDers.Controls.Add(this.lblDersKod);
            this.tbDers.Controls.Add(this.lblDersAd);
            this.tbDers.Controls.Add(this.lblOgrenciSec);
            this.tbDers.Controls.Add(this.btnDersEkle);
            this.tbDers.Controls.Add(this.nudFinal);
            this.tbDers.Controls.Add(this.nudVize);
            this.tbDers.Controls.Add(this.txtKredi);
            this.tbDers.Controls.Add(this.txtDersKod);
            this.tbDers.Controls.Add(this.txtDersAd);
            this.tbDers.Controls.Add(this.cmbOgrenciler);
            this.tbDers.Location = new System.Drawing.Point(4, 22);
            this.tbDers.Name = "tbDers";
            this.tbDers.Padding = new System.Windows.Forms.Padding(3);
            this.tbDers.Size = new System.Drawing.Size(788, 419);
            this.tbDers.TabIndex = 1;
            this.tbDers.Text = "Ders Ekle/Not Giriş";
            this.tbDers.UseVisualStyleBackColor = true;
            // 
            // lblKredi
            // 
            this.lblKredi.AutoSize = true;
            this.lblKredi.Location = new System.Drawing.Point(238, 188);
            this.lblKredi.Name = "lblKredi";
            this.lblKredi.Size = new System.Drawing.Size(31, 13);
            this.lblKredi.TabIndex = 10;
            this.lblKredi.Text = "Kredi";
            // 
            // lblDersKod
            // 
            this.lblDersKod.AutoSize = true;
            this.lblDersKod.Location = new System.Drawing.Point(238, 142);
            this.lblDersKod.Name = "lblDersKod";
            this.lblDersKod.Size = new System.Drawing.Size(57, 13);
            this.lblDersKod.TabIndex = 9;
            this.lblDersKod.Text = "Ders Kodu";
            // 
            // lblDersAd
            // 
            this.lblDersAd.AutoSize = true;
            this.lblDersAd.Location = new System.Drawing.Point(238, 99);
            this.lblDersAd.Name = "lblDersAd";
            this.lblDersAd.Size = new System.Drawing.Size(47, 13);
            this.lblDersAd.TabIndex = 8;
            this.lblDersAd.Text = "Ders Adı";
            // 
            // lblOgrenciSec
            // 
            this.lblOgrenciSec.AutoSize = true;
            this.lblOgrenciSec.Location = new System.Drawing.Point(238, 55);
            this.lblOgrenciSec.Name = "lblOgrenciSec";
            this.lblOgrenciSec.Size = new System.Drawing.Size(74, 13);
            this.lblOgrenciSec.TabIndex = 7;
            this.lblOgrenciSec.Text = "Öğrenci Seçin";
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(319, 331);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(75, 23);
            this.btnDersEkle.TabIndex = 6;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // nudFinal
            // 
            this.nudFinal.Location = new System.Drawing.Point(388, 268);
            this.nudFinal.Name = "nudFinal";
            this.nudFinal.Size = new System.Drawing.Size(135, 20);
            this.nudFinal.TabIndex = 5;
            // 
            // nudVize
            // 
            this.nudVize.Location = new System.Drawing.Point(388, 226);
            this.nudVize.Name = "nudVize";
            this.nudVize.Size = new System.Drawing.Size(135, 20);
            this.nudVize.TabIndex = 4;
            // 
            // txtKredi
            // 
            this.txtKredi.Location = new System.Drawing.Point(388, 181);
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(135, 20);
            this.txtKredi.TabIndex = 3;
            // 
            // txtDersKod
            // 
            this.txtDersKod.Location = new System.Drawing.Point(388, 135);
            this.txtDersKod.Name = "txtDersKod";
            this.txtDersKod.Size = new System.Drawing.Size(135, 20);
            this.txtDersKod.TabIndex = 2;
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(388, 92);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(135, 20);
            this.txtDersAd.TabIndex = 1;
            // 
            // cmbOgrenciler
            // 
            this.cmbOgrenciler.FormattingEnabled = true;
            this.cmbOgrenciler.Location = new System.Drawing.Point(388, 47);
            this.cmbOgrenciler.Name = "cmbOgrenciler";
            this.cmbOgrenciler.Size = new System.Drawing.Size(135, 21);
            this.cmbOgrenciler.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(378, 101);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(138, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(378, 52);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(138, 20);
            this.txtAd.TabIndex = 0;
            // 
            // tpOgrenci
            // 
            this.tpOgrenci.Controls.Add(this.tbOgrenci);
            this.tpOgrenci.Controls.Add(this.tbDers);
            this.tpOgrenci.Controls.Add(this.tbListele);
            this.tpOgrenci.Location = new System.Drawing.Point(2, 3);
            this.tpOgrenci.Name = "tpOgrenci";
            this.tpOgrenci.SelectedIndex = 0;
            this.tpOgrenci.Size = new System.Drawing.Size(796, 445);
            this.tpOgrenci.TabIndex = 1;
            // 
            // tbOgrenci
            // 
            this.tbOgrenci.Controls.Add(this.lblBolum);
            this.tbOgrenci.Controls.Add(this.lblNumara);
            this.tbOgrenci.Controls.Add(this.lblSoyad);
            this.tbOgrenci.Controls.Add(this.lblAd);
            this.tbOgrenci.Controls.Add(this.btnOgrenciEkle);
            this.tbOgrenci.Controls.Add(this.txtBolum);
            this.tbOgrenci.Controls.Add(this.txtNumara);
            this.tbOgrenci.Controls.Add(this.txtSoyad);
            this.tbOgrenci.Controls.Add(this.txtAd);
            this.tbOgrenci.Location = new System.Drawing.Point(4, 22);
            this.tbOgrenci.Name = "tbOgrenci";
            this.tbOgrenci.Padding = new System.Windows.Forms.Padding(3);
            this.tbOgrenci.Size = new System.Drawing.Size(788, 419);
            this.tbOgrenci.TabIndex = 0;
            this.tbOgrenci.Text = "Öğrenci Ekle";
            this.tbOgrenci.UseVisualStyleBackColor = true;
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Location = new System.Drawing.Point(267, 213);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(36, 13);
            this.lblBolum.TabIndex = 8;
            this.lblBolum.Text = "Bölüm";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(267, 159);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(44, 13);
            this.lblNumara.TabIndex = 7;
            this.lblNumara.Text = "Numara";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(267, 108);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 6;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(267, 59);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "Ad";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(315, 267);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(135, 23);
            this.btnOgrenciEkle.TabIndex = 4;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(378, 206);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(138, 20);
            this.txtBolum.TabIndex = 3;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(378, 152);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(138, 20);
            this.txtNumara.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tpOgrenci);
            this.Name = "frmMain";
            this.Text = "Student Course Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            this.tbListele.ResumeLayout(false);
            this.tbDers.ResumeLayout(false);
            this.tbDers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVize)).EndInit();
            this.tpOgrenci.ResumeLayout(false);
            this.tbOgrenci.ResumeLayout(false);
            this.tbOgrenci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.ComboBox cmbOgrenciListe;
        private System.Windows.Forms.TabPage tbListele;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblFinalNotu;
        private System.Windows.Forms.Label lblVizeNotu;
        private System.Windows.Forms.TabPage tbDers;
        private System.Windows.Forms.Label lblKredi;
        private System.Windows.Forms.Label lblDersKod;
        private System.Windows.Forms.Label lblDersAd;
        private System.Windows.Forms.Label lblOgrenciSec;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.NumericUpDown nudFinal;
        private System.Windows.Forms.NumericUpDown nudVize;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.TextBox txtDersKod;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.ComboBox cmbOgrenciler;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TabControl tpOgrenci;
        private System.Windows.Forms.TabPage tbOgrenci;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.TextBox txtNumara;
    }
}

