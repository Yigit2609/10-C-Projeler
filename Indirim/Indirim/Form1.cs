using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Indirim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYuzde15_Click(object sender, EventArgs e)
        {
            
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(txtEtiketFiyati.Text);

            indirimliFiyat = etiketFiyati - etiketFiyati * 0.15;
            
            lblFiyat.Text = indirimliFiyat.ToString();

        }

        private void btnYuzde25_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(txtEtiketFiyati.Text);

            indirimliFiyat = etiketFiyati - etiketFiyati * 0.25;
            lblFiyat.Text = indirimliFiyat.ToString();//yaz
        }

        private void btnYuzde50_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(txtEtiketFiyati.Text);

            indirimliFiyat = etiketFiyati - etiketFiyati * 0.50;
            lblFiyat.Text = indirimliFiyat.ToString();//yaz
        }

        private void btnYuzde75_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(txtEtiketFiyati.Text);

            indirimliFiyat = etiketFiyati - etiketFiyati * 0.75;
            lblFiyat.Text = indirimliFiyat.ToString();//yaz
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
