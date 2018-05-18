using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakYonetim
{
    public partial class GayrimenkulYonetim : Form
    {
        public GayrimenkulYonetim()
        {
            InitializeComponent();
        }

        private void gAYRİMENKULToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Gayrimenkul Gy = new Gayrimenkul();
            Gy.Show();
        }

        private void gAYRİMENKULFİYATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GayrimenkulFiyat Gyf = new GayrimenkulFiyat();
            Gyf.Show();
        }


        private void kİRACIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kiraci krc = new Kiraci();
            krc.Show();
        }

        private void kİRACIGAYRİMENKULToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KiraciGayrimenkul krcgy = new KiraciGayrimenkul();
            krcgy.Show();
        }

        private void mÜSTERİÖDEMEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MusteriOdeme msodm = new MusteriOdeme();
            msodm.Show();
        }
    }
}
