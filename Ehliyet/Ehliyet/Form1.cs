using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ehliyet
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

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            byte yas = Convert.ToByte(txtYas.Text);

            if (yas > 17)
                lblSonuc.Text = "EHLİYET ALABİLİR..";
            else
                lblSonuc.Text = "EHLİYET ALAMAZ..";
        }
    }
}
