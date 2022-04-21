using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DosyaTuruEslestirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            string secim = lbDosyaUzantisi.SelectedItem.ToString();
            bool cevap1 = rdVideo.Checked;
            bool cevap2 = rdResim.Checked;


            if ((secim == "MP4" || secim == "MOV") && cevap1 == true)
            {
                MessageBox.Show("Cevabınız doğru");
            }
            else if ((secim == "JPG" || secim == "PNG") && cevap2 == true)
            {
                MessageBox.Show("Cevabınız doğru");
            }
            else
            {
                MessageBox.Show("Cevqabınız yanlış");
            }
        }
    }
}
