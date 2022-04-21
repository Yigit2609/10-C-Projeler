using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusteriArama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string aranan = txtBul.Text;
            int adet =  lbMusteriler.Items.Count;
            bool bulunduMu = false;

            for (int i = 0; i < adet; i++)
            {
                string musteri = lbMusteriler.Items[i].ToString();

                if (musteri.ToLower() == aranan.ToLower())
                {
                    lbMusteriler.SelectedIndex = i;
                    bulunduMu = true;
                    MessageBox.Show("Bulundu...");
                    break;//Donguyu bitirir ve
                }
            }
            //buraya atlar

            if (!bulunduMu)
                MessageBox.Show("Maalesef aradığınız müşteri bulunamadı!");
        }
    }
}
