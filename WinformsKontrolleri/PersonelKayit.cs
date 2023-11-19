using DataAccessLayer;
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
    public partial class PersonelKayit : Form
    {
        DataModel dm = new DataModel();
        bool yuklendi = false;
        public PersonelKayit()
        {
            InitializeComponent();
            cb_ilce.DisplayMember = "Isim";
            cb_ilce.ValueMember = "ID";
            cb_sehir.DisplayMember = "Isim";
            cb_sehir.ValueMember = "ID";
            cb_departman.DisplayMember = "Isim";
            cb_departman.ValueMember = "ID";
        }

        private void PersonelKayit_Load(object sender, EventArgs e)
        {
            cb_sehir.DataSource = dm.SehirListele();
            cb_departman.DataSource = dm.DepartmanListele();
            listBox1.Items.AddRange(new string[] { "İngilizce", "Almanca", "Rusça", "İtalyanca", "Fransızca", "İspanyolca" });
            yuklendi = true;
        }

        private void cb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yuklendi)
            {
                int secilenid = Convert.ToInt32(cb_sehir.SelectedValue.ToString());
                cb_ilce.DataSource = dm.SehireGoreIlceListele(secilenid);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> secilenler = new List<string>();
            if (listBox1.SelectedItems.Count != 0)
            {
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                   secilenler.Add(listBox1.SelectedItems[i].ToString());
                    listBox2.Items.Add(listBox1.SelectedItems[i]);
                    
                }
                for (int i = 0; i < secilenler.Count; i++)
                {
                    listBox1.Items.Remove(secilenler[i]);
                }
            }

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Isim = tb_isim.Text;
            p.Soyisim = tb_soyisim.Text;
            p.Adres = tb_Adres.Text;
            p.Cinsiyet = rb_erkek.Checked ? "Erkek" : "Kadın";
            p.MedeniHal = rb_evli.Checked ? "Evli" : "Bekar";
            p.CocukSayisi = Convert.ToByte(nu_cocukSayi.Value);
            p.Departman_ID = int.Parse(cb_departman.SelectedValue.ToString());
            p.DogumTarihi = dtp_dogumTarih.Value;
            p.Gorev = tb_gorev.Text;
            p.Ilce_ID = Convert.ToInt32(cb_ilce.SelectedValue.ToString());
            p.Sehir_ID = Convert.ToInt32(cb_sehir.SelectedValue.ToString());
            p.KimlikNo = mtb_kimlikNo.Text;
            p.Telefon = mtb_Telefon.Text;
            p.Maas = Convert.ToDouble(nu_maas.Value);
            p.PersonelNot = tb_not.Text;

            string diller = "";
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                diller += listBox2.Items[i].ToString() + ",";
            }
            p.Diller = diller.Substring(0, diller.Length - 1);
            if (dm.PersonelEkle(p))
            {
                MessageBox.Show("Personel Ekleme Başarılı");
            }
            else
            {
                MessageBox.Show("Personel Eklerken Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
