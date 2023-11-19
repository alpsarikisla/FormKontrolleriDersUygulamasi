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
    public partial class PictureBoxKontrolu : Form
    {
        public PictureBoxKontrolu()
        {
            InitializeComponent();
        }

        private void PictureBoxKontrolu_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "../../Resimler/resim.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilen = comboBox1.SelectedItem.ToString();

            if (secilen == "Normal")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
            if (secilen == "Center Image")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            if (secilen == "Auto Size")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            if (secilen == "Zoom")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
