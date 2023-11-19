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
    public partial class TextBoxKontrolu : Form
    {
       
        public TextBoxKontrolu()
        {
            InitializeComponent();
        }

        private void TextBoxKontrolu_Load(object sender, EventArgs e)
        {
            tb_readonly.Text = "hedehude@hotmail.com";
            tb_enabled.Text = "hedehude@hotmail.com";
           
        }

    }
}
