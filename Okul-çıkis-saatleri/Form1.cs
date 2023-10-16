using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_çıkis_saatleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gunAd=cmb1.Text;
            int gunNo = cmb1.SelectedIndex;

            gunNo++;
            
            if (gunNo==1 || gunNo==2 || gunNo == 3)
            {
                lbl1.Text = "Çıkış Saati 16:40'dadır";
            }

            else if (gunNo==4 || gunNo == 5)
            {
                lbl1.Text = "Çikış saati 15:50";
            }

            else
            {
                lbl1.Text = "Tatil;)";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Hikmet Nazif Kurşunoğlu MTAL Lisesi Çıkış Saatleri.";
            lbl1.Text = "Saat";
        }
    }
}
