using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Sınav2Ornek1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.I4)]
        static extern int SendMessage(
            IntPtr hWnd,
            [param: MarshalAs(UnmanagedType.U4)]
        uint Msg,
            [param: MarshalAs(UnmanagedType.U4)]
        uint wParam,
            [param: MarshalAs(UnmanagedType.I4)]
        int lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ReleaseCapture();

        const uint WM_NCLBUTTONDOWN = 0xA1; // 161
        const uint HTCAPTION = 2;
        public Region CreateRegion()
        {
         
           
            //Create a graphics path
            GraphicsPath path = new GraphicsPath(FillMode.Winding);
            path.AddEllipse(new Rectangle(0,50,30,30));
            path.AddRectangle(new Rectangle(15, 50, 30, 30));
            path.AddRectangle(new Rectangle(30,0,ClientRectangle.Width-30,ClientRectangle.Height));
            
            //Create a Region object from the path and set it as the form's region
            Region rgn = new Region(path);
            return rgn;
        }

        Region defaultRegion;
        bool opened = false;

        public Form1()
        {
            InitializeComponent();

            defaultRegion = Region;
            //this.Region = CreateRegion();
            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double birimFiyat = Convert.ToDouble(txtBirimFiyat.Text);
            int miktar = Convert.ToInt32(txtMiktar.Text);
            double indirim = 0;

            double tutar = birimFiyat * miktar;
            //indirim yap
            if (miktar >= 100 && miktar < 200)
                indirim = tutar * 5 / 100;
            else if (miktar >= 200 && miktar < 500)
                indirim = tutar * 10 / 100;
            else if (miktar >= 500)
                indirim = tutar * 20 / 100;


            double odenecekTutar = tutar - indirim;

            txtTutar.Text = odenecekTutar.ToString("f2");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(opened)
                Left = Screen.PrimaryScreen.Bounds.Width - 30;
            else
                Left = Screen.PrimaryScreen.Bounds.Width - ClientRectangle.Width;
            opened = !opened;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Region = defaultRegion;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, // Form handle
                    WM_NCLBUTTONDOWN, // Simulating the click
                    HTCAPTION, // Attaching it to the title bar
                    0); // No further options required
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Left = Screen.PrimaryScreen.Bounds.Width - 30;
        }
    }

}