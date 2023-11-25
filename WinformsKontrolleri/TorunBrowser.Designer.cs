namespace WinformsKontrolleri
{
    partial class TorunBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TorunBrowser));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSMI_Geri = new System.Windows.Forms.ToolStripButton();
            this.TSMI_Ileri = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSTB_adres = new System.Windows.Forms.ToolStripTextBox();
            this.TSBTN_Git = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 540);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(934, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Geri,
            this.TSMI_Ileri,
            this.toolStripSeparator1,
            this.TSTB_adres,
            this.TSBTN_Git});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(928, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSMI_Geri
            // 
            this.TSMI_Geri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMI_Geri.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Geri.Image")));
            this.TSMI_Geri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMI_Geri.Name = "TSMI_Geri";
            this.TSMI_Geri.Size = new System.Drawing.Size(24, 22);
            this.TSMI_Geri.Text = "<-";
            this.TSMI_Geri.Click += new System.EventHandler(this.TSMI_Geri_Click);
            // 
            // TSMI_Ileri
            // 
            this.TSMI_Ileri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMI_Ileri.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Ileri.Image")));
            this.TSMI_Ileri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMI_Ileri.Name = "TSMI_Ileri";
            this.TSMI_Ileri.Size = new System.Drawing.Size(24, 22);
            this.TSMI_Ileri.Text = "->";
            this.TSMI_Ileri.Click += new System.EventHandler(this.TSMI_Ileri_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSTB_adres
            // 
            this.TSTB_adres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSTB_adres.Name = "TSTB_adres";
            this.TSTB_adres.Size = new System.Drawing.Size(600, 25);
            this.TSTB_adres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TSTB_adres_KeyDown);
            // 
            // TSBTN_Git
            // 
            this.TSBTN_Git.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBTN_Git.Image = ((System.Drawing.Image)(resources.GetObject("TSBTN_Git.Image")));
            this.TSBTN_Git.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBTN_Git.Name = "TSBTN_Git";
            this.TSBTN_Git.Size = new System.Drawing.Size(27, 22);
            this.TSBTN_Git.Text = "=>";
            this.TSBTN_Git.Click += new System.EventHandler(this.TSBTN_Git_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(928, 483);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(934, 514);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "+";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TorunBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 579);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TorunBrowser";
            this.Text = "TorunBrowser";
            this.Load += new System.EventHandler(this.TorunBrowser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSMI_Geri;
        private System.Windows.Forms.ToolStripButton TSMI_Ileri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TSTB_adres;
        private System.Windows.Forms.ToolStripButton TSBTN_Git;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}