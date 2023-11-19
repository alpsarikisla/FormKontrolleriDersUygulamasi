﻿using System;
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
    public partial class ButtonKontrolu : Form
    {
        public ButtonKontrolu()
        {
            InitializeComponent();
        }

        private void btn_tikla_Click(object sender, EventArgs e)
        {
            this.Text = "Butona Tıkladım";
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                string isim = tb_isim.Text;
                lbl_ekran.Text = "Merhaba = " + isim;
            }
            else
            {
                MessageBox.Show("Lütfen isim alanını doldurunuz","Uyarı");
            }
        }
    }
}
