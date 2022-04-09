using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ilksayi;
        string islem;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0"&& textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 6)
            {
                textBox1.Font = new Font("Segoe UI", 30);
            }
            else if (textBox1.TextLength == 12)
            {
                textBox1.Font = new Font("Segoe UI", 15);
            }
            else if (textBox1.TextLength == 1)
            {
                textBox1.Font = new Font("Segoe UI", 28);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            islem = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            islem = "-";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            islem = "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            islem = "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double ikincisayi;
            double sonuc;
            ikincisayi = Convert.ToDouble(textBox1.Text);
            if (islem == "+")
            {
                sonuc= ilksayi + ikincisayi;
                textBox1.Text = Convert.ToString(sonuc);
                ilksayi = sonuc;
            }
            if (islem == "-")
            {
                sonuc = ilksayi - ikincisayi;
                textBox1.Text = Convert.ToString(sonuc);
                ilksayi = sonuc;
            }
            if (islem == "*")
            {
                sonuc = ilksayi * ikincisayi;
                textBox1.Text = Convert.ToString(sonuc);
                ilksayi = sonuc;
            }
            if (islem == "/")
            {
              

                if (ikincisayi == 0)
                {
                    textBox1.Text = "Hata";
                }
                else
                {
                    sonuc = ilksayi / ikincisayi;
                    textBox1.Text = Convert.ToString(sonuc);
                    ilksayi = sonuc;
                }
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = ",";
        }
    }
}
