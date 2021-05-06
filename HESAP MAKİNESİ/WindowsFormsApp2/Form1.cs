using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string islem = "";
        double sayi1 = 0, sayi2 = 0;

        public void sifirla()
        {
            txt1.Text = "0";

        }
        public double hesapla()
        {
            double sonuc = 0;
            if (islem == "+") sonuc = sayi1 + sayi2;
            else if (islem == "-") sonuc = sayi1 - sayi2;
            else if (islem == "x") sonuc = sayi1 * sayi2;
            else if (islem == "/") sonuc = sayi1 / sayi2;
            else sonuc = 0;
            return sonuc;

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txt1.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "1") txt1.Text = "";
            txt1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0") txt1.Text = "";
            txt1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0") txt1.Text = "";
            txt1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0") txt1.Text = "";
            txt1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0") txt1.Text = "";
            txt1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0") txt1.Text = "";
            txt1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0") txt1.Text = "";
            txt1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0") txt1.Text = "";
            txt1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0") txt1.Text = "";
            txt1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0") txt1.Text = "";
            txt1.Text += "0";
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            islem = "+";
            sayi1 = Convert.ToDouble(txt1.Text);
            sifirla();
            lbl1.Text = "islem:" + sayi1 + "  " + islem + "  ";
        }

        private void btncikar_Click(object sender, EventArgs e)
        {
            islem = "-";
            sayi1 = Convert.ToDouble(txt1.Text);
            sifirla();
            lbl1.Text = "islem:" + sayi1 + "  " + islem + "  ";
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            islem = "x";
            sayi1 = Convert.ToDouble(txt1.Text);
            sifirla();
            lbl1.Text = "islem:" + sayi1 + "  " + islem + "  ";
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            islem = "/";
            sayi1 = Convert.ToDouble(txt1.Text);
            sifirla();
            lbl1.Text = "islem:" + sayi1 + "  " + islem + "  ";
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(txt1.Text);
            txt1.Text = Convert.ToString(hesapla());
            lbl1.Text = "islem:" + sayi1 + "  " + islem + "  "+ sayi2+ "=" + Convert.ToString(hesapla());

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string sonveri = txt1.Text;
            txt1.Text = "";
            for (int i = 0; i < sonveri.Length-1; i++)
            {
                txt1.Text += sonveri[i].ToString();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            sifirla();
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            islem = "sin";
            double sonuc;
            sayi1 = Convert.ToDouble(txt1.Text);
            sonuc = Math.Sin(sayi1 * (Math.PI / 180));
            txt1.Text = sonuc.ToString();
            lbl1.Text = "islem:" + islem + sayi1 + "=" + Convert.ToString(sonuc);
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            islem = "cos";
            double sonuc;
            sayi1 = Convert.ToDouble(txt1.Text);
            sonuc = Math.Cos(sayi1 * (Math.PI / 180));
            txt1.Text = sonuc.ToString();
            lbl1.Text = "islem:" + islem + sayi1 + "=" + Convert.ToString(sonuc);
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            islem = "tan";
            double sonuc;
            sayi1 = Convert.ToDouble(txt1.Text);
            sonuc = Math.Tan(sayi1 * (Math.PI / 180));
            txt1.Text = sonuc.ToString();
            lbl1.Text = "islem:" + islem + sayi1 + "=" + Convert.ToString(sonuc);
        }

        private void btncot_Click(object sender, EventArgs e)
        {
            islem = "cot";
            double sonuc;
            sayi1 = Convert.ToDouble(txt1.Text);
            sonuc = 1/Math.Tan(sayi1 * (Math.PI / 180));
            txt1.Text = sonuc.ToString();
            lbl1.Text = "islem:" + islem + sayi1 + "=" + Convert.ToString(sonuc);
        }

        private void btnkok_Click(object sender, EventArgs e)
        {   
            double sonuc;
            sayi1= Convert.ToDouble(txt1.Text);
            sonuc = Math.Sqrt(sayi1);
            txt1.Text = sonuc.ToString();
            lbl1.Text = "islem:"+ Convert.ToString(sonuc);

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            double sonuc;
            sayi1 = Convert.ToDouble(txt1.Text);
            sonuc = Math.Log10(sayi1);
            txt1.Text = sonuc.ToString();
            lbl1.Text = "islem:" + Convert.ToString(sonuc);
        }

        private void btnkare_Click(object sender, EventArgs e)
        {
            double sonuc;
            sayi1 = Convert.ToDouble(txt1.Text);
            sonuc = sayi1 * sayi1;
            txt1.Text = sonuc.ToString();
            lbl1.Text = Convert.ToString(sonuc);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                islem = "+";
                sayi1 = Convert.ToDouble(txt1.Text);
                sifirla();
                lbl1.Text = "islem:" + sayi1 + "  " + islem + "  ";

            }

            if (e.KeyChar == '*')
            {
                if (txt1.Text != "0")
                {
                    sayi1 = Convert.ToDouble(txt1.Text);
                    islem = "x";
                    lbl1.Text = sayi1.ToString() + islem.ToString();
                    txt1.Text = "";
                }
                else lbl1.Text = "syntax ERROR";
            }

            if (e.KeyChar == '-')
            {
                if (txt1.Text != "0")
                {
                    sayi1 = Convert.ToDouble(txt1.Text);
                    islem = "-";
                    lbl1.Text = sayi1.ToString() + islem.ToString();
                    txt1.Text = "";
                }
                else lbl1.Text = "syntax ERROR";
            }

            if (e.KeyChar == '/')
            {
                if (txt1.Text != "0")
                {
                    sayi1 = Convert.ToDouble(txt1.Text);
                    islem = "/";
                    lbl1.Text = sayi1.ToString() + islem.ToString();
                    txt1.Text = "";
                }
                else lbl1.Text = "syntax ERROR";
            }

            if (e.KeyChar == '=')
            {

            }

        }
            private void btnvirgul_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0") txt1.Text = "";
            txt1.Text += ",";
        }
    }
  
    }

