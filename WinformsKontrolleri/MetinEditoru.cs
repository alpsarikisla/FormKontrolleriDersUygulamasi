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
    public partial class MetinEditoru : Form
    {
        bool kaydedildi = false;
        bool yuklendi = false;
        string path;
        public MetinEditoru()
        {
            InitializeComponent();
        }
        private void MetinEditoru_Load(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Zengin Metin Biçimi |*.rtf";
            openFileDialog1.Filter = "Zengin Metin Biçimi |*.rtf | Tüm Dosya Türleri | *.*";

            FontFamily[] fontlar = FontFamily.Families;
            foreach (FontFamily item in fontlar)
            {
                TSCB_fontlar.Items.Add(item.Name);
            }
            TSCB_fontlar.SelectedItem = richTextBox1.Font.Name;
            TSCB_size.Text = richTextBox1.Font.Size.ToString();
            yuklendi = true;
        }
        private void TSMI_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMI_kaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void TSMI_Ac_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                richTextBox1.LoadFile(filepath);
            }
        }

        private void TSMI_yeni_Click(object sender, EventArgs e)
        {
            if (kaydedildi)
            {
                richTextBox1.Clear();
            }
            else
            {
               DialogResult sonuc = MessageBox.Show("Kaydedilmemiş değişiklikleriniz var. Kaydetmek ister misiniz?","Kayıt", MessageBoxButtons.YesNoCancel);
                if (sonuc == DialogResult.Yes)
                {
                    Kaydet();
                    richTextBox1.Clear();
                }
                else if(sonuc == DialogResult.No)
                {
                    richTextBox1.Clear();
                }
                //else if (sonuc == DialogResult.Cancel)
                //{
                //    MessageBox.Show("Yeni dosya işlemi iptal edildi");
                //}
            }
        }

        private void richTextBox1_Changed(object sender, EventArgs e)
        {
            kaydedildi = false;
        }

        private void Kaydet()
        {
            if (kaydedildi)
            {
                richTextBox1.SaveFile(path);
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filepath = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(filepath);
                    path = filepath;
                    kaydedildi = true;
                }
            }
        }

        private void TSCB_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size = float.Parse(TSCB_size.Text);
            Font fnt = new Font(richTextBox1.Font.FontFamily, size);
            //richTextBox1.Font = fnt;
            richTextBox1.SelectionFont = fnt;
        }

        private void TSCB_fontlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yuklendi)
            {
                string fontadi = TSCB_fontlar.SelectedItem.ToString();
                float size = float.Parse(TSCB_size.Text);
                FontFamily ff = new FontFamily(fontadi);
                Font fnt = new Font(ff, size);
                richTextBox1.SelectionFont = fnt;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                DialogResult sonuc = MessageBox.Show("Tüm sayfaya uygulansın mı?", "Renk Seçim", MessageBoxButtons.YesNoCancel);
                if (sonuc == DialogResult.Yes)
                {
                    Color secilenrenk = colorDialog1.Color;
                    toolStripButton1.BackColor = secilenrenk;
                    richTextBox1.ForeColor = secilenrenk;
                   
                }
                else if(sonuc == DialogResult.No)
                {
                    Color secilenrenk = colorDialog1.Color;
                    toolStripButton1.BackColor = secilenrenk;
                    richTextBox1.SelectionColor = secilenrenk;
                }
                else if(sonuc == DialogResult.Cancel)
                {
                    MessageBox.Show("renk değişimi iptal edildi", "uyarı");
                }
            }
        }

        private void TSMI_yaziTipi_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
    }
}
