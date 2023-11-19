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
    public partial class ListBoxKontrolu : Form
    {
        public ListBoxKontrolu()
        {
            InitializeComponent();
        }

        private void ListBoxKontrolu_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Front-End Uzmanlığı");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secili = listBox1.SelectedItem.ToString();
            MessageBox.Show(secili,"Seçilen");
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string secili = listBox2.SelectedItem.ToString();
                MessageBox.Show(secili, "Seçilen");
            }
        }

        private void btn_urunEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_urun.Text))
            {
                lb_urunler.Items.Add(tb_urun.Text);
                tb_urun.Text = "";
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (lb_urunler.SelectedItem != null)
            {
                lb_urunler.Items.Remove(lb_urunler.SelectedItem);
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            if (lb_islemler.SelectedItem != null)
            {
                double s1 = Convert.ToDouble(tb_sayi1.Text);
                double s2 = Convert.ToDouble(tb_sayi2.Text);
                string islem = lb_islemler.SelectedItem.ToString();
                double sonuc = 0;
                switch (islem)
                {
                    case "Toplama":
                        sonuc = s1 + s2;  
                        break;
                    case "Çıkarma":
                        sonuc = s1 - s2;
                        break;
                    case "Çarpma":
                        sonuc = s1 * s2;
                        break;
                    case "Bölme":
                        sonuc = s1 / s2;
                        break;
                    //default:
                    //    break;
                }
                tb_sonuc.Text = sonuc.ToString();
            }
            else
            {
                MessageBox.Show("İşlem Seçiniz", "Uyarı");
            }
        }
    }
}
