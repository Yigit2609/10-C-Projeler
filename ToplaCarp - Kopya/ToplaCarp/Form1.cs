using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToplaCarp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txtS1.Text);
            int s2 = Convert.ToInt32(txtS2.Text);
            int sonuc;

            if (rdTopla.Checked)
            {
                //Toplama
                sonuc = s1 + s2;
            }
            else
            {
                //Çarpma
                sonuc = s1 * s2;
            }

            lblSonuc.Text = "Sonuç = " + sonuc;
        }
    }
}
