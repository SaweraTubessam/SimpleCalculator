using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        string input="";
        char operater=' ';
        double result = 0.0;
        double userinput = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

            input += "1";
            textBox1.Text = input;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
            textBox1.Text = input; 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += "3";
            textBox1.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += "4";
            textBox1.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input += "5";
            textBox1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += "6";
            textBox1.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += "7";
            textBox1.Text = input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += "8";
            textBox1.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += "9";
            textBox1.Text = input;  
        }

        private void button16_Click(object sender, EventArgs e)
        {
            input+= "0";
            textBox1.Text = input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operater = '+';
            input += "+";
            textBox1.Text = input;
            result = double.Parse(input.Substring(0, input.Length - 1));
            input = "";
           

        }

        private void button11_Click(object sender, EventArgs e)
        {
            operater='-';
            input += "-";
            textBox1.Text = input;
            result += double.Parse(input.Substring(0, input.Length - 1));
            input = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operater = '/';
            input += "/";
            textBox1.Text = input;
            result = double.Parse(input.Substring(0, input.Length - 1));

            input = "";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            operater = '*';
            input += "*";
            textBox1.Text = input;
            result = double.Parse(input.Substring(0, input.Length - 1));

            input = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double userinput=double.Parse(input);
            switch (operater)
            {
                case '+':
                    result += userinput;
                    break;
                case '-':
                    result -= userinput;
                    break;
                case '/':
                    result /= userinput; break;
                case '*':
                    result *= userinput; break;


            }

            textBox1.Text = result.ToString();
            input = result.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            input = "";
            result = 0.0;
            textBox1.Text= input;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

