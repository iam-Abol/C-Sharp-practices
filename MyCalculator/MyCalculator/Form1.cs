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
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            /////////////////////////////////////////

            panel1.Enabled = false;
            this.KeyPreview = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btndot.Enabled = !txtDisplay.Text.Contains(".");
            btnBackSpace.Enabled = Convert.ToBoolean(txtDisplay.TextLength);
        }

        private void Numbers(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                txtDisplay.Text = "";
                flag = false;
            }
            txtDisplay.Text += ((Button)sender).Text;
        }




        private void btnequal_Click(object sender, MouseEventArgs e)
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
            op = null;
        }

        private void operators(object sender, MouseEventArgs e)
        {
            if (op != null)
            {
                btnequal_Click(null, null);
            }
            a = Convert.ToDouble(txtDisplay.Text);
            op = ((Button)sender).Text;
            flag = true;

        }

        private void btnBackSpace_Click(object sender, MouseEventArgs e)
        {
            if (txtDisplay.Text != "")
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.TextLength - 1);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button btn = new Button();
            btn.Text = e.KeyChar.ToString();
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                Numbers(btn, null);
            }
            if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                operators(btn, null);
            }
            if (e.KeyChar == '.' && txtDisplay.Text.Contains(".") == false)
            {
                Numbers(btn, null);
            }
            if (e.KeyChar == 8)
            {
                btnBackSpace_Click(null, null);
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnequal_Click(null, null);
                btnequal.Focus();
            }
        }

        private void btnOnOff_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnOnOff.Text == "ON")
            {
                panel1.Enabled = true;
                this.KeyPreview = true;
                btnOnOff.Text = "OFF";
            }
            else if (btnOnOff.Text == "OFF")
            {
                panel1.Enabled = false;
                this.KeyPreview = false;
                btnOnOff.Text = "ON";
            }
        }

       
    }
}
