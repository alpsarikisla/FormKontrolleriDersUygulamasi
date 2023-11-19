namespace WinformsKontrolleri
{
    partial class ListBoxUygulama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_diller = new System.Windows.Forms.ListBox();
            this.lb_secilenler = new System.Windows.Forms.ListBox();
            this.btn_sec = new System.Windows.Forms.Button();
            this.btn_birak = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_CokluBirak = new System.Windows.Forms.Button();
            this.btn_cokluSec = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_birak);
            this.groupBox1.Controls.Add(this.btn_sec);
            this.groupBox1.Controls.Add(this.lb_secilenler);
            this.groupBox1.Controls.Add(this.lb_diller);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bildiğiniz diller";
            // 
            // lb_diller
            // 
            this.lb_diller.FormattingEnabled = true;
            this.lb_diller.Items.AddRange(new object[] {
            "İngilizce",
            "Almanca",
            "Fransızca",
            "İspanyolca",
            "Korece",
            "Flemenkçe",
            "Rusça",
            "Arapça",
            "Japonca",
            "Çince",
            "Taice",
            "Frankça",
            "Vietnamca",
            "Hintçe"});
            this.lb_diller.Location = new System.Drawing.Point(6, 19);
            this.lb_diller.Name = "lb_diller";
            this.lb_diller.Size = new System.Drawing.Size(120, 186);
            this.lb_diller.TabIndex = 0;
            // 
            // lb_secilenler
            // 
            this.lb_secilenler.FormattingEnabled = true;
            this.lb_secilenler.Location = new System.Drawing.Point(190, 19);
            this.lb_secilenler.Name = "lb_secilenler";
            this.lb_secilenler.Size = new System.Drawing.Size(120, 186);
            this.lb_secilenler.TabIndex = 0;
            // 
            // btn_sec
            // 
            this.btn_sec.Location = new System.Drawing.Point(132, 64);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(52, 23);
            this.btn_sec.TabIndex = 1;
            this.btn_sec.Text = ">>";
            this.btn_sec.UseVisualStyleBackColor = true;
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // btn_birak
            // 
            this.btn_birak.Location = new System.Drawing.Point(132, 93);
            this.btn_birak.Name = "btn_birak";
            this.btn_birak.Size = new System.Drawing.Size(52, 23);
            this.btn_birak.TabIndex = 1;
            this.btn_birak.Text = "<<";
            this.btn_birak.UseVisualStyleBackColor = true;
            this.btn_birak.Click += new System.EventHandler(this.btn_birak_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_CokluBirak);
            this.groupBox2.Controls.Add(this.btn_cokluSec);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(12, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 221);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bildiğiniz diller";
            // 
            // btn_CokluBirak
            // 
            this.btn_CokluBirak.Location = new System.Drawing.Point(132, 93);
            this.btn_CokluBirak.Name = "btn_CokluBirak";
            this.btn_CokluBirak.Size = new System.Drawing.Size(52, 23);
            this.btn_CokluBirak.TabIndex = 1;
            this.btn_CokluBirak.Text = "<<";
            this.btn_CokluBirak.UseVisualStyleBackColor = true;
            this.btn_CokluBirak.Click += new System.EventHandler(this.btn_CokluBirak_Click);
            // 
            // btn_cokluSec
            // 
            this.btn_cokluSec.Location = new System.Drawing.Point(132, 64);
            this.btn_cokluSec.Name = "btn_cokluSec";
            this.btn_cokluSec.Size = new System.Drawing.Size(52, 23);
            this.btn_cokluSec.TabIndex = 1;
            this.btn_cokluSec.Text = ">>";
            this.btn_cokluSec.UseVisualStyleBackColor = true;
            this.btn_cokluSec.Click += new System.EventHandler(this.btn_cokluSec_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(190, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 186);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "İngilizce",
            "Almanca",
            "Fransızca",
            "İspanyolca",
            "Korece",
            "Flemenkçe",
            "Rusça",
            "Arapça",
            "Japonca",
            "Çince",
            "Taice",
            "Frankça",
            "Vietnamca",
            "Hintçe"});
            this.listBox2.Location = new System.Drawing.Point(6, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(120, 186);
            this.listBox2.TabIndex = 0;
            // 
            // ListBoxUygulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 558);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListBoxUygulama";
            this.Text = "List Box Uygulama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_secilenler;
        private System.Windows.Forms.ListBox lb_diller;
        private System.Windows.Forms.Button btn_birak;
        private System.Windows.Forms.Button btn_sec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_CokluBirak;
        private System.Windows.Forms.Button btn_cokluSec;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}