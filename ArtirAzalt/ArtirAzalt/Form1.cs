using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArtirAzalt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArtir_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtSayi.Text);
            s+=1;
           
            txtSayi.Text = s.ToString();
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtSayi.Text);
            s -= 1;

            txtSayi.Text = s.ToString();
        }


    }
}
