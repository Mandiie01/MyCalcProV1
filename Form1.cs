using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalcProV1
{
    public partial class Form1 : Form
    {
        int value1;
        int value2;
        double result = 0;
        string sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInsertBlock.Clear();
            label2.Text = "";
            label3.Text = "";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtInsertBlock.Text = txtInsertBlock.Text + "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtInsertBlock.Text = txtInsertBlock.Text + ".";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            value2 = Convert.ToInt32(txtInsertBlock.Text);
            label3.Text = txtInsertBlock.Text;
            if(sign == "+")
            {
                result = value1 + value2;
                txtInsertBlock.Text = Convert.ToString(result);
            }
            else if (sign == "-")
            {
                result = value1 - value2;
                txtInsertBlock.Text = Convert.ToString(result);
            }
            else if (sign == "/")
            {
                result = value1 / value2;
                txtInsertBlock.Text = Convert.ToString(result);
            }
            else if (sign == "*")
            {
                result = value1 * value2;
                txtInsertBlock.Text = Convert.ToString(result);
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtInsertBlock.Text = txtInsertBlock.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtInsertBlock.Text = txtInsertBlock.Text + "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtInsertBlock.Text = txtInsertBlock.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtInsertBlock.Text = txtInsertBlock.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtInsertBlock.Text = txtInsertBlock.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtInsertBlock.Text = txtInsertBlock.Text + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtInsertBlock.Text = txtInsertBlock.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtInsertBlock.Text = txtInsertBlock.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtInsertBlock.Text = txtInsertBlock.Text + "9";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(txtInsertBlock.Text);
            sign = "+";
            label2.Text =txtInsertBlock.Text + sign;
            txtInsertBlock.Text = "";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(txtInsertBlock.Text);
            sign = "-";
            label2.Text = txtInsertBlock.Text + sign;
            txtInsertBlock.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(txtInsertBlock.Text);
            sign = "/";
            label2.Text = txtInsertBlock.Text + sign;
            txtInsertBlock.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(txtInsertBlock.Text);
            sign = "*";
            label2.Text = txtInsertBlock.Text + sign;
            txtInsertBlock.Text = "";
        }
    }
}
