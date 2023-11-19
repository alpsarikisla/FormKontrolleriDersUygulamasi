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
    public partial class ListBoxUygulama : Form
    {
        public ListBoxUygulama()
        {
            InitializeComponent();
        }  

        private void btn_sec_Click(object sender, EventArgs e)
        {
            if (lb_diller.SelectedItem != null)
            {
                lb_secilenler.Items.Add(lb_diller.SelectedItem.ToString());
                lb_diller.Items.Remove(lb_diller.SelectedItem);
            }
            else
            {
                MessageBox.Show("Dil seçimi yapmadınız", "Uyarı");
            }
        }

        private void btn_birak_Click(object sender, EventArgs e)
        {
            if (lb_secilenler.SelectedItem != null)
            {
                lb_diller.Items.Add(lb_secilenler.SelectedItem.ToString());
                lb_secilenler.Items.Remove(lb_secilenler.SelectedItem);
            }
            else
            {
                MessageBox.Show("Dil seçimi yapmadınız", "Uyarı");
            }
        }

        private void btn_cokluSec_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem!= null)
            {
                List<string> secilenler = new List<string>();
                for (int i = 0; i < listBox2.SelectedItems.Count; i++)
                {
                    listBox1.Items.Add(listBox2.SelectedItems[i]);
                    secilenler.Add(listBox2.SelectedItems[i].ToString());
                }
                foreach (var item in secilenler)
                {
                    listBox2.Items.Remove(item);
                }
            }
        }

        private void btn_CokluBirak_Click(object sender, EventArgs e)
        {

        }
    }
}
