
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace netHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1-Değişkenleri tanımla
            int matDogru, matYanlis, turkDogru, turkYanlis;
            double matNet, turkNet;
            
            //2-TextbBoxlardan verileri al
            matDogru = Convert.ToInt32(txtMatDogru.Text);
            matYanlis = Convert.ToInt32(txtMatYanlıs.Text);
                        
            turkDogru = Convert.ToInt32(txtTurkceDogru.Text);
            turkYanlis = Convert.ToInt32(txtTurkceYanlıs.Text);
            
            //3-Hesaplamayı yap
            matNet = matDogru - matYanlis / 4.0;
            turkNet = turkDogru - turkYanlis / 4.0;

            //4-Sonuçları göster
            txtTurkceNet.Text = turkNet.ToString();
            txtMatNet.Text = matNet.ToString();
        }
    }
}
