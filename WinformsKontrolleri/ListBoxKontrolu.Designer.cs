namespace WinformsKontrolleri
{
    partial class ListBoxKontrolu
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_urunler = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_urun = new System.Windows.Forms.TextBox();
            this.btn_urunEkle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.lb_islemler = new System.Windows.Forms.ListBox();
            this.tb_sayi1 = new System.Windows.Forms.TextBox();
            this.tb_sayi2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.tb_sonuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Web Yazılım Uzmanlığı",
            "İleri Yazılım Uzmanlığı"});
            this.listBox1.Location = new System.Drawing.Point(12, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Index Changed";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Web Yazılım Uzmanlığı",
            "İleri Yazılım Uzmanlığı"});
            this.listBox2.Location = new System.Drawing.Point(226, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 0;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Double Click";
            // 
            // lb_urunler
            // 
            this.lb_urunler.FormattingEnabled = true;
            this.lb_urunler.Location = new System.Drawing.Point(12, 215);
            this.lb_urunler.Name = "lb_urunler";
            this.lb_urunler.Size = new System.Drawing.Size(120, 95);
            this.lb_urunler.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Adı:";
            // 
            // tb_urun
            // 
            this.tb_urun.Location = new System.Drawing.Point(141, 231);
            this.tb_urun.Name = "tb_urun";
            this.tb_urun.Size = new System.Drawing.Size(205, 20);
            this.tb_urun.TabIndex = 4;
            // 
            // btn_urunEkle
            // 
            this.btn_urunEkle.Location = new System.Drawing.Point(141, 257);
            this.btn_urunEkle.Name = "btn_urunEkle";
            this.btn_urunEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_urunEkle.TabIndex = 5;
            this.btn_urunEkle.Text = "Ürün Ekle";
            this.btn_urunEkle.UseVisualStyleBackColor = true;
            this.btn_urunEkle.Click += new System.EventHandler(this.btn_urunEkle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(15, 316);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // lb_islemler
            // 
            this.lb_islemler.FormattingEnabled = true;
            this.lb_islemler.Items.AddRange(new object[] {
            "Toplama",
            "Çıkarma",
            "Çarpma",
            "Bölme"});
            this.lb_islemler.Location = new System.Drawing.Point(432, 46);
            this.lb_islemler.Name = "lb_islemler";
            this.lb_islemler.Size = new System.Drawing.Size(120, 108);
            this.lb_islemler.TabIndex = 6;
            // 
            // tb_sayi1
            // 
            this.tb_sayi1.Location = new System.Drawing.Point(558, 62);
            this.tb_sayi1.Name = "tb_sayi1";
            this.tb_sayi1.Size = new System.Drawing.Size(147, 20);
            this.tb_sayi1.TabIndex = 7;
            // 
            // tb_sayi2
            // 
            this.tb_sayi2.Location = new System.Drawing.Point(558, 101);
            this.tb_sayi2.Name = "tb_sayi2";
            this.tb_sayi2.Size = new System.Drawing.Size(147, 20);
            this.tb_sayi2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sonuç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sayı 2";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(558, 129);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_hesapla.TabIndex = 9;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // tb_sonuc
            // 
            this.tb_sonuc.Location = new System.Drawing.Point(561, 158);
            this.tb_sonuc.Name = "tb_sonuc";
            this.tb_sonuc.Size = new System.Drawing.Size(144, 20);
            this.tb_sonuc.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sayı 1";
            // 
            // ListBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_sonuc);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_sayi2);
            this.Controls.Add(this.tb_sayi1);
            this.Controls.Add(this.lb_islemler);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_urunEkle);
            this.Controls.Add(this.tb_urun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_urunler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "ListBoxKontrolu";
            this.Text = "ListBoxKontrolu";
            this.Load += new System.EventHandler(this.ListBoxKontrolu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_urunler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_urun;
        private System.Windows.Forms.Button btn_urunEkle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.ListBox lb_islemler;
        private System.Windows.Forms.TextBox tb_sayi1;
        private System.Windows.Forms.TextBox tb_sayi2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.TextBox tb_sonuc;
        private System.Windows.Forms.Label label6;
    }
}