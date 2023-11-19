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
    public partial class FlowLayoutPanelKontrolu : Form
    {
        public FlowLayoutPanelKontrolu()
        {
            InitializeComponent();
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string FolderPath = folderBrowserDialog1.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(FolderPath);
                List<FileInfo> dosyalar = di.GetFiles().ToList();

                foreach (FileInfo item in dosyalar)
                {
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(150, 150);
                    pb.ImageLocation = item.FullName;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Click += Pb_Click;
                    flowLayoutPanel1.Controls.Add(pb);
                }
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pictureBox1.ImageLocation = pb.ImageLocation;
        }
    }
}
