using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kuvvet10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGosterFor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 5; i++)
            {
                double sonuc = Math.Pow(10, i);

                lbSayilarFor.Items.Add(sonuc);
            }
        }

        private void btnGosterWhile_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 5)
            {
                double sonuc = Math.Pow(10, i);
                lbSayilarWhile.Items.Add(sonuc);
                i++;
            }
        }

        private void btnGosterDoWhile_Click(object sender, EventArgs e)
        {
            int i = 0;

            do
            {
                double sonuc = Math.Pow(10, i);
                lbSayilarDoWhile.Items.Add(sonuc);
                i++;
            } while (i <= 5);
        }
    }
}
