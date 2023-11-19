using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsKontrolleri
{
    public partial class PersonelDosyaKayit : Form
    {
        DataModel dm = new DataModel();
        List<FileInfo> dosyalar = new List<FileInfo>();
        bool yuklendi = false;
        public PersonelDosyaKayit()
        {
            InitializeComponent();
            cb_ilce.DisplayMember = "Isim";
            cb_ilce.ValueMember = "ID";
            cb_sehir.DisplayMember = "Isim";
            cb_sehir.ValueMember = "ID";
            cb_departman.DisplayMember = "Isim";
            cb_departman.ValueMember = "ID";
           
        }

        private void PersonelDosyaKayit_Load(object sender, EventArgs e)
        {
            cb_sehir.DataSource = dm.SehirListele();
            yuklendi = true;
            cb_departman.DataSource = dm.DepartmanListele();
            DosyalariGetir();
        }

        private void DosyalariGetir()
        {
            listBox1.Items.Clear();
            DirectoryInfo di = new DirectoryInfo("Personeller");
            dosyalar = di.GetFiles().ToList();
            foreach (FileInfo item in dosyalar)
            {
                string[] isim = item.Name.Split('_','.');
                //      6514651651651_Alp_Sarikisla.txt
                listBox1.Items.Add(isim[1]+ " " + isim[2]);
            }
        }

        private void cb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yuklendi)
            {
                int secilenid = Convert.ToInt32(cb_sehir.SelectedValue.ToString());
                cb_ilce.DataSource = dm.SehireGoreIlceListele(secilenid);
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text) && !string.IsNullOrEmpty(tb_soyisim.Text) && !string.IsNullOrEmpty(mtb_kimlikNo.Text))
            {
                string dosyaisim = mtb_kimlikNo.Text + "_" + tb_isim.Text + "_" + tb_soyisim.Text;
                string dosyauzanti = ".txt";
                string path = "Personeller/" + dosyaisim + dosyauzanti;
                FileStream fs = new FileStream(path, FileMode.Create);
                fs.Close();

                //FileInfo fi = new FileInfo("Personeller/" + dosyaisim + dosyauzanti);
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(tb_isim.Text);
                sw.WriteLine(tb_soyisim.Text);
                sw.WriteLine(mtb_kimlikNo.Text);
                sw.WriteLine(mtb_Telefon.Text);
                sw.WriteLine(dtp_dogumTarih.Value);
                sw.WriteLine(rb_erkek.Checked == true ? "Erkek" : "Kadın");
                sw.WriteLine(rb_evli.Checked == true ? "Evli" : "Bekar");
                sw.WriteLine(nu_cocukSayi.Value.ToString());
                sw.WriteLine(cb_sehir.SelectedValue);
                sw.WriteLine(cb_ilce.SelectedValue);
                sw.WriteLine(tb_Adres.Text);
                sw.WriteLine(cb_departman.SelectedValue);
                sw.WriteLine(tb_gorev.Text);
                sw.WriteLine(nu_maas.Value.ToString());
                sw.Close();
                DosyalariGetir();
                MessageBox.Show("Kayıt Tamamlandı", "Başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen Isim, Soyisim ve Kimlik No alanlarını boş bırakmayınız","Uyarı");
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                StreamReader sr = new StreamReader(dosyalar[listBox1.SelectedIndex].FullName);
                tb_isim.Text = sr.ReadLine();
                tb_soyisim.Text = sr.ReadLine();
                mtb_kimlikNo.Text = sr.ReadLine();
                mtb_Telefon.Text = sr.ReadLine();
            }
        }
    }
}
