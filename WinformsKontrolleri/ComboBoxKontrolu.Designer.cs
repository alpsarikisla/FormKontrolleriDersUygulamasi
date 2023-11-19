namespace WinformsKontrolleri
{
    partial class ComboBoxKontrolu
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
            this.cb_haftaninGunleri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_getir = new System.Windows.Forms.Button();
            this.cb_Aylar = new System.Windows.Forms.ComboBox();
            this.Aylar = new System.Windows.Forms.Label();
            this.cb_databoundAylar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_aygetir = new System.Windows.Forms.Button();
            this.lbl_secilenAy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_haftaninGunleri
            // 
            this.cb_haftaninGunleri.FormattingEnabled = true;
            this.cb_haftaninGunleri.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.cb_haftaninGunleri.Location = new System.Drawing.Point(12, 54);
            this.cb_haftaninGunleri.Name = "cb_haftaninGunleri";
            this.cb_haftaninGunleri.Size = new System.Drawing.Size(121, 21);
            this.cb_haftaninGunleri.TabIndex = 0;
            this.cb_haftaninGunleri.Text = "Seçiniz...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Haftanın Günleri";
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(139, 52);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(75, 23);
            this.btn_getir.TabIndex = 2;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // cb_Aylar
            // 
            this.cb_Aylar.FormattingEnabled = true;
            this.cb_Aylar.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cb_Aylar.Location = new System.Drawing.Point(12, 114);
            this.cb_Aylar.Name = "cb_Aylar";
            this.cb_Aylar.Size = new System.Drawing.Size(121, 21);
            this.cb_Aylar.TabIndex = 3;
            this.cb_Aylar.Text = "Ay Seçiniz...";
            this.cb_Aylar.SelectedIndexChanged += new System.EventHandler(this.cb_Aylar_SelectedIndexChanged);
            // 
            // Aylar
            // 
            this.Aylar.AutoSize = true;
            this.Aylar.Location = new System.Drawing.Point(12, 98);
            this.Aylar.Name = "Aylar";
            this.Aylar.Size = new System.Drawing.Size(30, 13);
            this.Aylar.TabIndex = 4;
            this.Aylar.Text = "Aylar";
            // 
            // cb_databoundAylar
            // 
            this.cb_databoundAylar.FormattingEnabled = true;
            this.cb_databoundAylar.Location = new System.Drawing.Point(15, 198);
            this.cb_databoundAylar.Name = "cb_databoundAylar";
            this.cb_databoundAylar.Size = new System.Drawing.Size(121, 21);
            this.cb_databoundAylar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aylar";
            // 
            // btn_aygetir
            // 
            this.btn_aygetir.Location = new System.Drawing.Point(142, 196);
            this.btn_aygetir.Name = "btn_aygetir";
            this.btn_aygetir.Size = new System.Drawing.Size(75, 23);
            this.btn_aygetir.TabIndex = 7;
            this.btn_aygetir.Text = "Ay Getir";
            this.btn_aygetir.UseVisualStyleBackColor = true;
            this.btn_aygetir.Click += new System.EventHandler(this.btn_aygetir_Click);
            // 
            // lbl_secilenAy
            // 
            this.lbl_secilenAy.AutoSize = true;
            this.lbl_secilenAy.Location = new System.Drawing.Point(12, 231);
            this.lbl_secilenAy.Name = "lbl_secilenAy";
            this.lbl_secilenAy.Size = new System.Drawing.Size(35, 13);
            this.lbl_secilenAy.TabIndex = 8;
            this.lbl_secilenAy.Text = "label3";
            // 
            // ComboBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_secilenAy);
            this.Controls.Add(this.btn_aygetir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_databoundAylar);
            this.Controls.Add(this.Aylar);
            this.Controls.Add(this.cb_Aylar);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_haftaninGunleri);
            this.Name = "ComboBoxKontrolu";
            this.Text = "ComboBoxKontrolu";
            this.Load += new System.EventHandler(this.ComboBoxKontrolu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_haftaninGunleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.ComboBox cb_Aylar;
        private System.Windows.Forms.Label Aylar;
        private System.Windows.Forms.ComboBox cb_databoundAylar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aygetir;
        private System.Windows.Forms.Label lbl_secilenAy;
    }
}