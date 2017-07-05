using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kl2
{
    public partial class Form1 : Form
    {
        string oldValue;
        char act = '0';
        public Form1()
        {
            InitializeComponent();

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            act = '+';
            oldValue = textBox1.Text;
            textBox1.Text = "";

        }

        private void minus_Click(object sender, EventArgs e)
        {
            act = '-';
            oldValue = textBox1.Text;
            textBox1.Text = "";
        }

        private void multp_Click(object sender, EventArgs e)
        {
            act = '*';
            oldValue = textBox1.Text;
            textBox1.Text = "";
        }

        private void split_Click(object sender, EventArgs e)
        {
            act = '/';
            oldValue = textBox1.Text;
            textBox1.Text = "";
        }

        private void C_Click(object sender, EventArgs e)
        {
            act = '0';
            oldValue = "";
            textBox1.Text = "";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void znak_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            act = 's';
        }

        private void stepen_Click(object sender, EventArgs e)
        {
            act = '^';
            oldValue = textBox1.Text;
            textBox1.Text = "";
        }

        private void sp1it_Click(object sender, EventArgs e)
        {
            act = '1';
        }
        private void otv_Click(object sender, EventArgs e)
        {
            switch (act)
            {
                case '+':
                    textBox1.Text = Convert.ToString(Convert.ToDouble(oldValue) + Convert.ToDouble(textBox1.Text));
                    act = '0';
                    break;
                case '-':
                    textBox1.Text = Convert.ToString(Convert.ToInt32(oldValue) - Convert.ToInt32(textBox1.Text));
                    act = '0';
                    break;
                case '*':
                    textBox1.Text = Convert.ToString(Convert.ToDouble(oldValue) * Convert.ToDouble(textBox1.Text));
                    act = '0';
                    break;
                case '/':
                    textBox1.Text = Convert.ToString(Convert.ToDouble(oldValue) / Convert.ToDouble(textBox1.Text));
                    act = '0';
                    break;
                case 's':
                    textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
                    act = '0';
                    break;
                case '^':
                    textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(oldValue), Convert.ToDouble(textBox1.Text)));
                    act = '0';
                    break;
                case '1':
                    textBox1.Text = Convert.ToString(1 / Convert.ToDouble(textBox1.Text));
                    act = '0';
                    break;
            }
        }

    }
}
