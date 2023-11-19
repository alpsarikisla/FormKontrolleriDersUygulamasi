namespace WinformsKontrolleri
{
    partial class ButtonKontrolu
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
            this.btn_tikla = new System.Windows.Forms.Button();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_tikla
            // 
            this.btn_tikla.Location = new System.Drawing.Point(22, 22);
            this.btn_tikla.Name = "btn_tikla";
            this.btn_tikla.Size = new System.Drawing.Size(75, 23);
            this.btn_tikla.TabIndex = 0;
            this.btn_tikla.Text = "Tıkla";
            this.btn_tikla.UseVisualStyleBackColor = true;
            this.btn_tikla.Click += new System.EventHandler(this.btn_tikla_Click);
            // 
            // btn_gonder
            // 
            this.btn_gonder.BackColor = System.Drawing.Color.LightGreen;
            this.btn_gonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gonder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_gonder.Location = new System.Drawing.Point(22, 51);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(126, 53);
            this.btn_gonder.TabIndex = 1;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.UseVisualStyleBackColor = false;
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Salmon;
            this.btn_iptal.Enabled = false;
            this.btn_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_iptal.Location = new System.Drawing.Point(154, 51);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(126, 53);
            this.btn_iptal.TabIndex = 1;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = false;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(19, 127);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(34, 13);
            this.lbl_isim.TabIndex = 2;
            this.lbl_isim.Text = "İsim =";
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(59, 124);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(221, 20);
            this.tb_isim.TabIndex = 3;
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(205, 150);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(75, 23);
            this.btn_yazdir.TabIndex = 4;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Location = new System.Drawing.Point(19, 155);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(0, 13);
            this.lbl_ekran.TabIndex = 5;
            // 
            // ButtonKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ekran);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.tb_isim);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.btn_tikla);
            this.Name = "ButtonKontrolu";
            this.Text = "ButtonKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tikla;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.Label lbl_ekran;
    }
}