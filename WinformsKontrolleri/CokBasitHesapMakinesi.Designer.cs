namespace WinformsKontrolleri
{
    partial class CokBasitHesapMakinesi
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sayi1 = new System.Windows.Forms.TextBox();
            this.tb_sayi2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_sonuc = new System.Windows.Forms.TextBox();
            this.btn_topla = new System.Windows.Forms.Button();
            this.btn_fark = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_Bol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı 2";
            // 
            // tb_sayi1
            // 
            this.tb_sayi1.Location = new System.Drawing.Point(12, 25);
            this.tb_sayi1.Name = "tb_sayi1";
            this.tb_sayi1.Size = new System.Drawing.Size(161, 20);
            this.tb_sayi1.TabIndex = 2;
            // 
            // tb_sayi2
            // 
            this.tb_sayi2.Location = new System.Drawing.Point(179, 25);
            this.tb_sayi2.Name = "tb_sayi2";
            this.tb_sayi2.Size = new System.Drawing.Size(161, 20);
            this.tb_sayi2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sonuç";
            // 
            // tb_sonuc
            // 
            this.tb_sonuc.Location = new System.Drawing.Point(56, 89);
            this.tb_sonuc.Name = "tb_sonuc";
            this.tb_sonuc.Size = new System.Drawing.Size(283, 20);
            this.tb_sonuc.TabIndex = 5;

            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(12, 51);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(75, 23);
            this.btn_topla.TabIndex = 6;
            this.btn_topla.Text = "Topla";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // btn_fark
            // 
            this.btn_fark.Location = new System.Drawing.Point(96, 51);
            this.btn_fark.Name = "btn_fark";
            this.btn_fark.Size = new System.Drawing.Size(75, 23);
            this.btn_fark.TabIndex = 7;
            this.btn_fark.Text = "Çıkar";
            this.btn_fark.UseVisualStyleBackColor = true;
            this.btn_fark.Click += new System.EventHandler(this.btn_fark_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(180, 51);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(75, 23);
            this.btn_carp.TabIndex = 8;
            this.btn_carp.Text = "Çarp";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // btn_Bol
            // 
            this.btn_Bol.Location = new System.Drawing.Point(264, 51);
            this.btn_Bol.Name = "btn_Bol";
            this.btn_Bol.Size = new System.Drawing.Size(75, 23);
            this.btn_Bol.TabIndex = 9;
            this.btn_Bol.Text = "Böl";
            this.btn_Bol.UseVisualStyleBackColor = true;
            this.btn_Bol.Click += new System.EventHandler(this.btn_Bol_Click);
            // 
            // CokBasitHesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 128);
            this.Controls.Add(this.btn_Bol);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_fark);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.tb_sonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_sayi2);
            this.Controls.Add(this.tb_sayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CokBasitHesapMakinesi";
            this.Text = "CokBasitHesapMakinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sayi1;
        private System.Windows.Forms.TextBox tb_sayi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_sonuc;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button btn_fark;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_Bol;
    }
}