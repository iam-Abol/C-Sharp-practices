using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        double a, b, result;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Numbers(object sender, MouseEventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Text;
        }

        private void oprators(object sender, MouseEventArgs e)
        {
            a = Convert.ToDouble(txtDisplay.Text);
            op = ((Button)sender).Text;
            txtDisplay.Text = "";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(txtDisplay.Text);
            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }
            txtDisplay.Text = result.ToString();
        }
    }
}
