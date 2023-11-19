using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsKontrolleri.Model;

namespace WinformsKontrolleri
{
    public partial class ComboBoxKontrolu : Form
    {
        public ComboBoxKontrolu()
        {
            InitializeComponent();
        }
        private void ComboBoxKontrolu_Load(object sender, EventArgs e)
        {
            List<Ay> aylar = new List<Ay>();
            aylar.Add(new Ay() { ID = 1, Name = "Ocak" });
            aylar.Add(new Ay() { ID = 2, Name = "Şubat" });
            aylar.Add(new Ay() { ID = 3, Name = "Mart" });
            aylar.Add(new Ay() { ID = 4, Name = "Nisan" });
            aylar.Add(new Ay() { ID = 5, Name = "Mayıs" });
            aylar.Add(new Ay() { ID = 6, Name = "Haziran" });
            aylar.Add(new Ay() { ID = 7, Name = "Temmuz" });
            aylar.Add(new Ay() { ID = 8, Name = "Ağustos" });
            aylar.Add(new Ay() { ID = 9, Name = "Eylül" });
            aylar.Add(new Ay() { ID = 10, Name = "Ekim" });
            aylar.Add(new Ay() { ID = 11, Name = "Kasım" });
            aylar.Add(new Ay() { ID = 12, Name = "Aralık" });
            cb_databoundAylar.ValueMember = "ID";
            cb_databoundAylar.DisplayMember = "Name";
            cb_databoundAylar.DataSource = aylar;
        }
        private void btn_getir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_haftaninGunleri.SelectedItem.ToString(),"Secilen Gün");
        }

        private void cb_Aylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cb_Aylar.SelectedItem.ToString(), "Seçilen Ay");
        }

        private void btn_aygetir_Click(object sender, EventArgs e)
        {
            lbl_secilenAy.Text = cb_databoundAylar.SelectedValue.ToString() + " - " + cb_databoundAylar.Text.ToString();
        }
    }
}
