using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsKontrolleri
{
    public partial class TorunBrowser : Form
    {
        string anasayfa = "http://www.google.com";
        public TorunBrowser()
        {
            InitializeComponent();
        }

        private void TorunBrowser_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(anasayfa);
            TSTB_adres.Text = anasayfa;
        }

        private void TSBTN_Git_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(TSTB_adres.Text);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            TSTB_adres.Text = webBrowser1.Url.ToString();
            tabPage2.Text = webBrowser1.DocumentTitle;
        }

        private void TSMI_Geri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void TSMI_Ileri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void TSTB_adres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Url = new Uri(TSTB_adres.Text);
            }
        }
    }
}
