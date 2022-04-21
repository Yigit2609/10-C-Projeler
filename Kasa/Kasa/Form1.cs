using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(txtTutar.Text);
            double toplamTutar = 0;
            int taksitSay = 0;

            if (rdTekCekim.Checked)
            {
                toplamTutar = tutar;
                taksitSay = 1;
            }
            else if (rd2Taksit.Checked)
            {
                toplamTutar = tutar * 1.05;
                taksitSay = 2;
            }
            else if (rd3Taksit.Checked)
            {
                toplamTutar = tutar * 1.05;
                taksitSay = 3;
            }
            else if (rd4Taksit.Checked)
            {
                toplamTutar = tutar * 1.10;
                taksitSay = 4;
            }
            else if (rd5Taksit.Checked)
            {
                toplamTutar = tutar * 1.10;
                taksitSay = 5;
            }
            else
            {
                MessageBox.Show("Taksit sayısını seçmediniz!");
                return;
            }

            MessageBox.Show("Toplam Tutar:" + toplamTutar);


            lbGecmis.Items.Add(toplamTutar.ToString() + " TL (Ödeme Planı : " + taksitSay + "x" + 
                toplamTutar / taksitSay + " TL)");

        }

        private void btnGecmisTemizle_Click(object sender, EventArgs e)
        {
            lbGecmis.Items.Clear();
        }
    }
}
