using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bizimHesaplar
{
    public partial class hesapMakinesi : Form
    {
        public hesapMakinesi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                lblSonuc.Text = Convert.ToString(0);
                kontrol = false;
            }
            else if (kontrolSonuc == true)
            {
                lblSonuc.Text = Convert.ToString(0);
                kontrolSonuc = false;
            }
            else
            {
                lblSonuc.Text += Convert.ToString(0);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
          
            if (kontrol == true) 
            {
                lblSonuc.Text = Convert.ToString(1);
                kontrol = false;
            }
            else if (kontrolSonuc == true)
            {
                lblSonuc.Text = Convert.ToString(1);
                kontrolSonuc = false;
            }
            else
            {
                lblSonuc.Text += Convert.ToString(1);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                lblSonuc.Text = Convert.ToString(2);
                kontrol = false;
            }
            else if (kontrolSonuc == true)
            {
                lblSonuc.Text = Convert.ToString(2);
                kontrolSonuc = false;
            }
            else
            {
                lblSonuc.Text += Convert.ToString(2);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                lblSonuc.Text = Convert.ToString(3);
                kontrol = false;
            }
            else if (kontrolSonuc == true)
            {
                lblSonuc.Text = Convert.ToString(3);
                kontrolSonuc = false;
            }
            else
            {
                lblSonuc.Text += Convert.ToString(3);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                lblSonuc.Text = Convert.ToString(4);
                kontrol = false;
            }
            else if (kontrolSonuc == true)
            {
                lblSonuc.Text = Convert.ToString(4);
                kontrolSonuc = false;
            }
            else
            {
                lblSonuc.Text += Convert.ToString(4);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                lblSonuc.Text = Convert.ToString(5);
                kontrol = false;
            }
            else if (kontrolSonuc == true)
            {
                lblSonuc.Text = Convert.ToString(5);
                kontrolSonuc = false;
            }
            else
            {
                lblSonuc.Text += Convert.ToString(5);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                lblSonuc.Text = Convert.ToString(6);
                kontrol = false;
            }
            else if (kontrolSonuc == true)
            {
                lblSonuc.Text = Convert.ToString(6);
                kontrolSonuc = false;
            }
            else
            {
                lblSonuc.Text += Convert.ToString(6);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                lblSonuc.Text = Convert.ToString(7);
                kontrol = false;
            }
            else if (kontrolSonuc == true)
            {
                lblSonuc.Text = Convert.ToString(7);
                kontrolSonuc = false;
            }
            else
            {
                lblSonuc.Text += Convert.ToString(7);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                lblSonuc.Text = Convert.ToString(8);
                kontrol = false;
            }
            else if (kontrolSonuc == true)
            {
                lblSonuc.Text = Convert.ToString(8);
                kontrolSonuc = false;
            }
            else
            {
                lblSonuc.Text += Convert.ToString(8);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                lblSonuc.Text = Convert.ToString(9);
                kontrol = false;
            }
            else if (kontrolSonuc == true)
            {
                lblSonuc.Text = Convert.ToString(9);
                kontrolSonuc = false;
            }
            else
            {
                lblSonuc.Text += Convert.ToString(9);
            }
        }

        int toplama = 0;
        int cikarma = 0;
        int carpma = 0;
        int bolme = 0;
        double isaret = 0;
        double yuzde = 0;

        bool kontrol;
        bool kontrolSonuc;
        string islem = "";

        private void btnBolme_Click(object sender, EventArgs e)
        {
            kontrol = true;
            bolme = Convert.ToInt32(lblSonuc.Text);
            islem = "/";
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            kontrol = true;
            carpma = Convert.ToInt32(lblSonuc.Text);
            islem = "x";
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            kontrol = true;
            toplama = Convert.ToInt32(lblSonuc.Text);
            islem = "+";
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            kontrol = true;
            cikarma = Convert.ToInt32(lblSonuc.Text);
            islem = "-";
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            if (islem == "+")
            {
                toplama += Convert.ToInt32(lblSonuc.Text);
                lblSonuc.Text = Convert.ToString(toplama);
            }
            else if (islem == "-")  
            {
                cikarma = cikarma - Convert.ToInt32(lblSonuc.Text);
                lblSonuc.Text = Convert.ToString(cikarma);
            }
            else if (islem == "x")
            {
                carpma = carpma * Convert.ToInt32(lblSonuc.Text);
                lblSonuc.Text = Convert.ToString(carpma);
            }
            else if (islem == "/")
            {
                bolme = bolme / Convert.ToInt32(lblSonuc.Text);
                lblSonuc.Text = Convert.ToString(bolme);
            }

            kontrolSonuc = true;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = string.Empty;
        }

        private void btnYuzde_Click(object sender, EventArgs e)
        {
            yuzde =  Convert.ToDouble(lblSonuc.Text) /100;
            lblSonuc.Text = Convert.ToString(yuzde);
            kontrolSonuc = true;
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {

        }

        private void btnNegatif_Click(object sender, EventArgs e)
        {
            isaret = Convert.ToDouble(lblSonuc.Text);

            if (isaret < 0)
            {
                lblSonuc.Text = Convert.ToString(-isaret);
            }
            else if (isaret > 0) 
            {
                lblSonuc.Text = Convert.ToString(-isaret);
            }

            kontrolSonuc = true;
        }
    }
}
