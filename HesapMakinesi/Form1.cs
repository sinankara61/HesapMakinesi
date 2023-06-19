using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        double x;
        double y;
        string islem;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text=="0")

            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text += "1";
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")

            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text += "2";
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")

            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text += "3";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")

            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text += "4";
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")

            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text += "5";
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")

            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text += "6";
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")

            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text += "7";
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")

            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text += "8";
            }
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")

            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text += "9";
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")

            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text += "0";
            }
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(richTextBox1.Text)>0)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1, 1);
                if (richTextBox1.Text.Length==1)
                {
                    richTextBox1.Text = "0";
                }
            }
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            x=Convert.ToDouble(richTextBox1.Text);
            islem = "+";
            labelControl1.Text=richTextBox1.Text + " + ";
            richTextBox1.Text = " ";

        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            y=Convert.ToDouble(richTextBox1.Text);
            double sonuc = 0;

            switch (islem)
            {
                case "+":
                    sonuc = x + y;
                    break;
                case "-":
                    sonuc = x - y;
                    break;
                case "*":
                    sonuc = x * y;
                    break;
                case "/":
                    if (y != 0)
                        sonuc = x / y;
                    else
                    {
                        MessageBox.Show("Sıfıra bölme hatası!");
                        return;
                    }
                    break;
            }

            richTextBox1.Text = sonuc.ToString("0.##");
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(richTextBox1.Text);
            islem = "-";
            labelControl1.Text = richTextBox1.Text + " - ";
            richTextBox1.Text = " ";
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(richTextBox1.Text);
            islem = "*";
            labelControl1.Text = richTextBox1.Text + " * ";
            richTextBox1.Text = " ";
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(richTextBox1.Text);
            islem = "/";
            labelControl1.Text = richTextBox1.Text + " / ";
            richTextBox1.Text = " ";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains(","))
                richTextBox1.Text += ",";
        }

        
    }
}
