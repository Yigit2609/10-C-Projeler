using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OgrenciNot
{
    public partial class Form1 : Form
    {
        Ogrenci ogr;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            bool yeni = false;

            if (ogr == null)//zaten öğrenci varsa tekrar oluşturma
            {
                yeni = true;
                ogr = new Ogrenci();
            }

            ogr.No = Convert.ToInt32(txtNo.Text);
            ogr.Ad = txtAd.Text;
            ogr.Soyad = txtSoyad.Text;
            ogr.Sinav1 = Convert.ToDouble(txtS1.Text);
            ogr.Sinav2 = Convert.ToDouble(txtS2.Text);
            ogr.Performans = Convert.ToDouble(txtP.Text);

            if (yeni)//Yeni ise listeye ekle
                lbListe.Items.Add(ogr);

            else//eski ise sadece güncelle
            {
                int index = lbListe.Items.IndexOf(ogr);
                lbListe.Items[index] = lbListe.Items[index];
            }

            txtOrt.Text = ogr.OrtalamaHesapla().ToString("f2");
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            ogr = null;//yeni kayıt eklenmesi için gerekli
            txtNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtS1.Text = "";
            txtS2.Text = "";
            txtP.Text = "";
        }

        private void lbListe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbListe.SelectedIndex;

            if (index >= 0)
            {
                ogr = (Ogrenci)lbListe.Items[index];

                txtNo.Text = ogr.No.ToString();
                txtAd.Text = ogr.Ad;
                txtSoyad.Text = ogr.Soyad;
                txtS1.Text = ogr.Sinav1.ToString();
                txtS2.Text = ogr.Sinav2.ToString();
                txtP.Text = ogr.Performans.ToString();

                txtOrt.Text = ogr.OrtalamaHesapla().ToString("f2");
            }

        }
    }
}
