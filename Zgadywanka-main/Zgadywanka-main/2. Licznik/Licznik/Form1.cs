using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licznik
{
    public partial class FormLicznik : Form
    {
        public FormLicznik()
        {
            InitializeComponent();
   
            
        }

        Random x = new Random();
        int number;
        int proby;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLicznik.Text == "0" || textBoxLicznik.Text.Contains("#"))
            {
                textBoxLicznik.Text = "1";
            }
            else
            {
                textBoxLicznik.Text += "1";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxLicznik.Text == "0" || textBoxLicznik.Text.Contains("#"))
            {
                textBoxLicznik.Text = "0";
            }
            else
            {
                textBoxLicznik.Text += "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxLicznik.Text == "0" || textBoxLicznik.Text.Contains("#"))
            {
                textBoxLicznik.Text = "2";
            }
            else
            {
                textBoxLicznik.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxLicznik.Text == "0" || textBoxLicznik.Text.Contains("#"))
            {
                textBoxLicznik.Text = "3";
            }
            else
            {
                textBoxLicznik.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxLicznik.Text == "0" || textBoxLicznik.Text.Contains("#"))
            {
                textBoxLicznik.Text = "4";
            }
            else
            {
                textBoxLicznik.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxLicznik.Text == "0" || textBoxLicznik.Text.Contains("#"))
            {
                textBoxLicznik.Text = "5";
            }
            else
            {
                textBoxLicznik.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxLicznik.Text == "0" || textBoxLicznik.Text.Contains("#"))
            {
                textBoxLicznik.Text = "6";
            }
            else
            {
                textBoxLicznik.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxLicznik.Text == "0" || textBoxLicznik.Text.Contains("#"))
            {
                textBoxLicznik.Text = "7";
            }
            else
            {
                textBoxLicznik.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxLicznik.Text == "0" || textBoxLicznik.Text.Contains("#"))
            {
                textBoxLicznik.Text = "8";
            }
            else
            {
                textBoxLicznik.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxLicznik.Text == "0" || textBoxLicznik.Text.Contains("#"))
            {
                textBoxLicznik.Text = "9";
            }
            else
            {
                textBoxLicznik.Text += "9";
            }
        }

        private void buttonGwiazdka_Click(object sender, EventArgs e)
        {
            number = x.Next(0, 100);
            proby = 0;
        }

        private void buttonHasz_Click(object sender, EventArgs e)
        {
            proby++;

            if (textBoxLicznik.Text.Contains("#"))
            {
                textBoxLicznik.Text = "0";
            }

             int pom = Convert.ToInt32(textBoxLicznik.Text);
            if (number == pom)
            {
                textBoxLicznik.Text = "#" + "#BRAWO. Proby: " + Convert.ToString(proby);
                proby = 0;
                number = x.Next(0, 100);
            }
            else if (number > pom)
            {
                textBoxLicznik.Text = "#ZA MALO#";
            }
            else
            {
                textBoxLicznik.Text = "#ZA DUZO#";
            }
        }

        private void textBoxLicznik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
