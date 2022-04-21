using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mevsimler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(txtDerece.Text);

            if (derece <= 10)
            {
                lblSonuc.Text = "KIŞ MEVSİMİ";
                pbSonuc.Image = pbKis.Image;
            }
            else if (derece <= 20)
            {
                lblSonuc.Text = "SON BAHAR MEVSİMİ";
                pbSonuc.Image = pbSonbahar.Image;
            }
            else if (derece <= 30)
            {
                lblSonuc.Text = "İLKBAHAR MEVSİMİ";
                pbSonuc.Image = pbIlkBahar.Image;
            }
            else
            {
                lblSonuc.Text = "YAZ MEVSİMİ";
                pbSonuc.Image = pbYaz.Image;
            }
        }

        private void txtDerece_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
