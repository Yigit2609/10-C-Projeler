using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace takdirAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte ortalama, devamsizlik;
            ortalama=Convert.ToByte(txtOrtalama.Text);
            devamsizlik=Convert.ToByte(txtDevamsizlik.Text);

            if (devamsizlik < 5)
            {
                if (ortalama >= 85)
                    lblHesepla.Text = "Takdir Belgesi alabilir.";
                else if (ortalama >= 70)
                    lblHesepla.Text = "Teşekkür Belgesi alabilir";
                else 
                    lblHesepla.Text = "Ortalması düşük. Belge alamaz!";
            }
            else
            {
                lblHesepla.Text = "Devamsızlığı çok. Belge alamaz!";
            }
               
        }
    }
}
