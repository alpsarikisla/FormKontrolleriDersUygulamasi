namespace WinformsKontrolleri
{
    partial class ProgressBarVeTimerKontrolleri
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_arttir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_saat = new System.Windows.Forms.ProgressBar();
            this.pb_dakika = new System.Windows.Forms.ProgressBar();
            this.pb_saniye = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_saat = new System.Windows.Forms.Label();
            this.btn_durdur = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(287, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btn_arttir
            // 
            this.btn_arttir.Location = new System.Drawing.Point(305, 12);
            this.btn_arttir.Name = "btn_arttir";
            this.btn_arttir.Size = new System.Drawing.Size(75, 23);
            this.btn_arttir.TabIndex = 1;
            this.btn_arttir.Text = "Arttır";
            this.btn_arttir.UseVisualStyleBackColor = true;
            this.btn_arttir.Click += new System.EventHandler(this.btn_arttir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_saat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pb_saniye);
            this.groupBox1.Controls.Add(this.pb_dakika);
            this.groupBox1.Controls.Add(this.pb_saat);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dijital Saat";
            // 
            // pb_saat
            // 
            this.pb_saat.Location = new System.Drawing.Point(6, 94);
            this.pb_saat.Maximum = 23;
            this.pb_saat.Name = "pb_saat";
            this.pb_saat.Size = new System.Drawing.Size(356, 23);
            this.pb_saat.TabIndex = 0;
            // 
            // pb_dakika
            // 
            this.pb_dakika.Location = new System.Drawing.Point(6, 146);
            this.pb_dakika.Maximum = 59;
            this.pb_dakika.Name = "pb_dakika";
            this.pb_dakika.Size = new System.Drawing.Size(356, 23);
            this.pb_dakika.TabIndex = 0;
            // 
            // pb_saniye
            // 
            this.pb_saniye.Location = new System.Drawing.Point(6, 199);
            this.pb_saniye.Maximum = 59;
            this.pb_saniye.Name = "pb_saniye";
            this.pb_saniye.Size = new System.Drawing.Size(356, 23);
            this.pb_saniye.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dakika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Saniye";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(100, 36);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(0, 31);
            this.lbl_saat.TabIndex = 2;
            // 
            // btn_durdur
            // 
            this.btn_durdur.Location = new System.Drawing.Point(305, 285);
            this.btn_durdur.Name = "btn_durdur";
            this.btn_durdur.Size = new System.Drawing.Size(75, 23);
            this.btn_durdur.TabIndex = 3;
            this.btn_durdur.Text = "Durdur";
            this.btn_durdur.UseVisualStyleBackColor = true;
            this.btn_durdur.Click += new System.EventHandler(this.btn_durdur_Click);
            // 
            // ProgressBarVeTimerKontrolleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 328);
            this.Controls.Add(this.btn_durdur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_arttir);
            this.Controls.Add(this.progressBar1);
            this.Name = "ProgressBarVeTimerKontrolleri";
            this.Text = "ProgressBarVeTimerKontrolleri";
            this.Load += new System.EventHandler(this.ProgressBarVeTimerKontrolleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_arttir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pb_saniye;
        private System.Windows.Forms.ProgressBar pb_dakika;
        private System.Windows.Forms.ProgressBar pb_saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Button btn_durdur;
    }
}