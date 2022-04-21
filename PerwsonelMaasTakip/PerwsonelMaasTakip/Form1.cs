using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PerwsonelMaasTakip
{
    public partial class Form1 : Form
    {
        Personel goruntulenenPersonel;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            goruntulenenPersonel = null;
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTel.Text = "";
            txtAdres.Text = "";
            txtIzin.Text = "";
            txtMaas.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool yeniMi = false;

            if (goruntulenenPersonel == null)
            {
                goruntulenenPersonel = new Personel();
                yeniMi = true;
            }

            if (txtIzin.Text == "") txtIzin.Text = "0";


            goruntulenenPersonel.Ad = txtAd.Text;
            goruntulenenPersonel.Soyad = txtSoyad.Text;
            goruntulenenPersonel.Tel = txtTel.Text;
            goruntulenenPersonel.Adres = txtAdres.Text;

            goruntulenenPersonel.Yetki = cbYetki.SelectedIndex;
            goruntulenenPersonel.IzinliOlduguGun = Convert.ToInt32(txtIzin.Text);

            txtMaas.Text = goruntulenenPersonel.MaasHesapla().ToString();

            if (yeniMi)
                lbPers.Items.Add(goruntulenenPersonel);
            else
            {
                int i = lbPers.Items.IndexOf(goruntulenenPersonel);
                lbPers.Items[i] = goruntulenenPersonel;

            }
        }

        private void lbPers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbPers.SelectedIndex;

            if (index >= 0)
            {
                goruntulenenPersonel = (Personel)lbPers.Items[index];

                txtAd.Text = goruntulenenPersonel.Ad;
                txtSoyad.Text = goruntulenenPersonel.Soyad;
                txtTel.Text = goruntulenenPersonel.Tel;
                txtAdres.Text = goruntulenenPersonel.Adres;
                txtIzin.Text = goruntulenenPersonel.IzinliOlduguGun.ToString();
                txtMaas.Text = goruntulenenPersonel.MaasHesapla().ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(goruntulenenPersonel.ToString() +" - Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                int i = lbPers.Items.IndexOf(goruntulenenPersonel);
                lbPers.Items.RemoveAt(i);
                
                btnYeni_Click(sender, e);//Yeni butonuna tıkla


            }
        }

    }
}
