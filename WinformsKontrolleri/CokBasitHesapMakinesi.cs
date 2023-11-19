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
    public partial class CokBasitHesapMakinesi : Form
    {
        public CokBasitHesapMakinesi()
        {
            InitializeComponent();
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(tb_sayi1.Text);
            double s2 = Convert.ToDouble(tb_sayi2.Text);

            double toplam = s1 + s2;
            //tb_sonuc.Text = Convert.ToString(toplam);
            tb_sonuc.Text = toplam.ToString();
        }

        private void btn_fark_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(tb_sayi1.Text);
            double s2 = Convert.ToDouble(tb_sayi2.Text);

            double fark = s1 - s2;
            tb_sonuc.Text = fark.ToString();
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(tb_sayi1.Text);
            double s2 = Convert.ToDouble(tb_sayi2.Text);

            double carpim = s1 * s2;
            tb_sonuc.Text = carpim.ToString();
        }

        private void btn_Bol_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(tb_sayi1.Text);
            double s2 = Convert.ToDouble(tb_sayi2.Text);

            double bolum = s1 / s2;
            tb_sonuc.Text = bolum.ToString();
        }

       
    }
}
