using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LocalDataHelper;

namespace ProjeTakip
{
    public partial class Form1 : Form
    {
        Ogrenci ogrenci;

        public Form1()
        {
            InitializeComponent();

            lbOgrenciler.Items.Load<Ogrenci>("bilgiler.dat");
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            ogrenci = null;
            txtAd.Text = txtNo.Text = txtSoyad.Text = txtKonu.Text = txtNot.Text = "";
            cbDers.SelectedIndex = 0;


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool yeniMi = false;

            if (ogrenci == null)
            {
                ogrenci = new Ogrenci();
                yeniMi = true;
            }

            ogrenci.No = Convert.ToInt32(txtNo.Text);
            ogrenci.Ad = txtAd.Text;
            ogrenci.Soyad = txtSoyad.Text;
            ogrenci.Ders = cbDers.SelectedIndex;
            ogrenci.Konu = txtKonu.Text;
            ogrenci.Not = Convert.ToDouble(txtNot.Text);

            if (yeniMi)
                lbOgrenciler.Items.Add(ogrenci);
            else
            {
                int indeks = lbOgrenciler.Items.IndexOf(ogrenci);
                lbOgrenciler.Items[indeks] = ogrenci;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(ogrenci.ToString() + " - Silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                int indeks = lbOgrenciler.Items.IndexOf(ogrenci);
                lbOgrenciler.Items.RemoveAt(indeks);
            }
        }

        private void lbOgrenciler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indeks = lbOgrenciler.SelectedIndex;

            if (indeks >= 0)
            {
                ogrenci = (Ogrenci)lbOgrenciler.Items[indeks];

                txtNo.Text = ogrenci.No.ToString();
                txtAd.Text = ogrenci.Ad;
                txtSoyad.Text = ogrenci.Soyad;
                cbDers.SelectedIndex = ogrenci.Ders;
                txtKonu.Text = ogrenci.Konu;
                txtNot.Text = ogrenci.Not.ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            lbOgrenciler.Items.Save("bilgiler.dat");
        }
    }
}
