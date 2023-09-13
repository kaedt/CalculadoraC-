using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form

    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button16_Click(object sender, EventArgs e)
        {
         textBox1.Text = textBox1.Text + "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA") 
            {
                textBox1.Text = Convert.ToString(valor1 + valor2);
            } else if (operacao == "SUB")
            {
             textBox1.Text = Convert.ToString(valor1 - valor2);
            } else if (operacao == "MULT")
            {
             textBox1.Text = Convert.ToString(valor1 * valor2);
            } else if (operacao == "DIV")
            {
             textBox1.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "SUB";
            LbOperacao.Text = "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "MULT";
            LbOperacao.Text = "x";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "DIV";
            LbOperacao.Text = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            valor1 = 0;
            valor2 = 0;
            LbOperacao.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "SOMA";
            LbOperacao.Text = "+";
        
        
    }
    }
}
