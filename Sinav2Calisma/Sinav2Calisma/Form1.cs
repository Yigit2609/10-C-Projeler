using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sinav2Calisma
{
    public partial class Form1 : Form
    {
        //Global alanı
        int a;
        int calisma;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTumuBuyuk_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string str2="";

            for (int i = 0; i < str.Length; i++)
            {
                char eski = str[i];

                char yeni = Char.ToUpper(eski);
                str2 += yeni;
            }

            textBox1.Text = str2;
        }

        private void btnTumunuKucult_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string str2 = "";

            for (int i = 0; i < str.Length; i++)
            {
                char eski = str[i];

                char yeni = Char.ToLower(eski);
                str2 += yeni;
            }

            textBox1.Text = str2;
        }

        private void btnKelimeDuzeni_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string str2 = "";

            for (int i = 0; i < str.Length; i++)
            {
                char eski = str[i];

                char yeni = Char.ToLower(eski);

                if (i == 0 || str[i - 1] == ' ' || Char.IsPunctuation(str[i - 1]))
                    yeni = Char.ToUpper(eski);

                str2 += yeni;
            }

            textBox1.Text = str2;
        }
            


        
    }
}
