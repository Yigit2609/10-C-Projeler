using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LocalDataHelper;

namespace TemzilikListesi
{
    public partial class Form1 : Form
    {
        Ogrenci mevcutOgrenci;

        public Form1()
        {
            InitializeComponent();

            listBox1.Items.Load<Ogrenci>("bilgiler.dat");

            listeDegisti();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool yeniMi = false;

            if (mevcutOgrenci == null)
            {
                mevcutOgrenci = new Ogrenci();
                yeniMi = true;
            }

            mevcutOgrenci.No = Convert.ToInt32(txtNo.Text);
            mevcutOgrenci.Ad = txtAd.Text;
            mevcutOgrenci.Soyad = txtSoyad.Text;

            if (yeniMi)
            {
                listBox1.Items.Add(mevcutOgrenci);
                
            }
            else listBox1.Items[listBox1.Items.IndexOf(mevcutOgrenci)] = mevcutOgrenci;

            listeDegisti();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            mevcutOgrenci = null;
            txtNo.Text = txtAd.Text = txtSoyad.Text = "";
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                mevcutOgrenci = (Ogrenci)listBox1.Items[listBox1.SelectedIndex];

                txtNo.Text = mevcutOgrenci.No.ToString();
                txtAd.Text = mevcutOgrenci.Ad;
                txtSoyad.Text = mevcutOgrenci.Soyad;
            }
        }

        void listeDegisti()
        {
            lblBir.Text = "1.Kişi";
            lblIki.Text = "2.Kişi";

            if (listBox1.Items.Count > 0)
                lblBir.Text = listBox1.Items[0].ToString();

            if(listBox1.Items.Count > 1)
                lblIki.Text = listBox1.Items[1].ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Save("bilgiler.dat");
        }

        private void btnTemizlikYapildi_Click(object sender, EventArgs e)
        {
            Ogrenci ogr1=null, ogr2=null;

            if (listBox1.Items.Count > 0)
            {
                ogr1 = (Ogrenci)listBox1.Items[0];
            }

            if (listBox1.Items.Count > 1)
            {
                ogr2 = (Ogrenci)listBox1.Items[1];
            }

            if (ogr1 != null)
            {
                listBox1.Items.RemoveAt(0);
                listBox1.Items.Add(ogr1);
            }

            if (ogr2 != null)
            {
                listBox1.Items.RemoveAt(0);
                listBox1.Items.Add(ogr2);
            }

            listeDegisti();
        }
    }
}
