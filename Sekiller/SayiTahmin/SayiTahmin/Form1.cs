using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SayiTahmin
{
    public partial class Form1 : Form
    {
        int hak;
        int sayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            hak = 5;

            Random rasgele = new Random();
            sayi = rasgele.Next(1,50);

            lblHak.Text = hak.ToString();
            lblSonuc.Text = "Oyun Başladı!";

            btnTahminEt.Enabled = true;
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            hak--;

            lblHak.Text = hak.ToString();


            int tahmin = Convert.ToInt32(txtTahmin.Text);

            if (tahmin < sayi)
            {
                lblSonuc.Text = "Yukarı";
            }
            else if (tahmin > sayi)
            {
                lblSonuc.Text = "Aşağı";
            }
            else
            {
                lblSonuc.Text = "Tebrikler! Bildiniz.. :)";
                btnTahminEt.Enabled = false;
                return;
            }

            if(hak<=0)
            {
                btnTahminEt.Enabled = false;
                lblSonuc.Text = "Oyun Bitti! Üzgünüm :( "+sayi;
                
            }


        }
    }
}
