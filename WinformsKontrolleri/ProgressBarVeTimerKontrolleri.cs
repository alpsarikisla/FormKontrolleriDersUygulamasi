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
    public partial class ProgressBarVeTimerKontrolleri : Form
    {
        public ProgressBarVeTimerKontrolleri()
        {
            InitializeComponent();
        }
        private void ProgressBarVeTimerKontrolleri_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Data();
        }
        private void btn_arttir_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            Data();
        }
        public void Data()
        {
            DateTime simdi = DateTime.Now;
            pb_saat.Value = simdi.Hour;
            pb_dakika.Value = simdi.Minute;
            pb_saniye.Value = simdi.Second;
            string saat = "";
            if (simdi.Second == 0)
            {
                saat = simdi.Hour + ":" + simdi.Minute + ":" + simdi.Second+"0";
            }
            else
            {
                saat = simdi.Hour + ":" + simdi.Minute + ":" + simdi.Second;
            }
            lbl_saat.Text = saat;
            //if (simdi.Second == 0)
            //{
            //    Console.Beep(500, 300);
            //}
            //else
            //{
            //    Console.Beep(1000, 100);
            //}
        }

        private void btn_durdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
