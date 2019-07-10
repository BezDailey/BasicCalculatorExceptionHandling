using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string operation;
        string firstNumberTxt;
        bool completedResult = false;
        public Form1()
        {
            InitializeComponent();
        }

        public class FloatingPtDivisonException : ApplicationException
        {
            public FloatingPtDivisonException(string exceptionType)

                :base (exceptionType)
            {

            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text == "0" && txtBx1.Text != null)
            {
                txtBx1.Text = "7";
                completedResult = false;
            }
            else
            {
                txtBx1.Text += "7";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text == "0" && txtBx1.Text != null)
            {
                txtBx1.Text = "1";
                completedResult = false;
            }
            else
            {
                txtBx1.Text += "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text == "0" && txtBx1.Text != null || completedResult == true)
            {
                txtBx1.Text = "2";
                completedResult = false;
            }
            else
            {
                txtBx1.Text += "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text == "0" && txtBx1.Text != null || completedResult == true)
            {
                txtBx1.Text = "3";
                completedResult = false;
            }
            else
            {
                txtBx1.Text += "3";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text == "0" && txtBx1.Text != null || completedResult == true)
            {
                txtBx1.Text = "4";
                completedResult = false;
            }
            else
            {
                txtBx1.Text += "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text == "0" && txtBx1.Text != null || completedResult == true)
            {
                txtBx1.Text = "5";
                completedResult = false;
            }
            else
            {
                txtBx1.Text += "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text == "0" && txtBx1.Text != null || completedResult == true)
            {
                txtBx1.Text = "6";
                completedResult = false;
            }
            else
            {
                txtBx1.Text += "6";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text == "0" && txtBx1.Text != null || completedResult == true)
            {
                txtBx1.Text = "8";
                completedResult = false;
            }
            else
            {
                txtBx1.Text += "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text == "0" && txtBx1.Text != null || completedResult == true)
            {
                txtBx1.Text = "9";
                completedResult = false;
            }
            else
            {
                txtBx1.Text += "9";
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text == "0" && txtBx1.Text != null || completedResult == true)
            {
                txtBx1.Text = "0";
                completedResult = false;
            }
            else
            {
                txtBx1.Text += "0";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtBx1.Text = "0";
            operation = null;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnSub.Enabled = true;
            btnAdd.Enabled = true;
            firstNumberTxt = null;
            txtBx2.Text = firstNumberTxt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtBx1.Text);
            txtBx1.Text = "0";
            operation = "+";
            firstNumberTxt = Convert.ToString(firstNumber);
            txtBx2.Text = firstNumberTxt;
            if (operation != null)
            {
                btnDivide.Enabled = false;
                btnMultiply.Enabled = false;
                btnSub.Enabled = false;
                btnAdd.Enabled = false;
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtBx1.Text);
            txtBx1.Text = "0";
            operation = "-";
            firstNumberTxt = Convert.ToString(firstNumber);
            txtBx2.Text = firstNumberTxt;
            if (operation != null)
            {
                btnDivide.Enabled = false;
                btnMultiply.Enabled = false;
                btnSub.Enabled = false;
                btnAdd.Enabled = false;
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtBx1.Text);
            txtBx1.Text = "0";
            operation = "x";
            firstNumberTxt = Convert.ToString(firstNumber);
            txtBx2.Text = firstNumberTxt;
            if (operation != null)
            {
                btnDivide.Enabled = false;
                btnMultiply.Enabled = false;
                btnSub.Enabled = false;
                btnAdd.Enabled = false;
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtBx1.Text);
            txtBx1.Text = "0";
            firstNumberTxt = Convert.ToString(firstNumber);
            txtBx2.Text = firstNumberTxt;
            operation = "/";
            if (operation != null)
            {
                btnDivide.Enabled = false;
                btnMultiply.Enabled = false;
                btnSub.Enabled = false;
                btnAdd.Enabled = false;
            }
        }

        private void BtnClear2_Click(object sender, EventArgs e)
        {
            txtBx1.Text = "0";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;

            secondNumber = Convert.ToDouble(txtBx1.Text);

            if (operation == "+")
            {
                result = (firstNumber + secondNumber);
                txtBx1.Text = Convert.ToString(result);
                txtBx2.Text = null;
            }
            if (operation == "-")
            {
                result = (firstNumber - secondNumber);
                txtBx1.Text = Convert.ToString(result);
                txtBx2.Text = null;
            }
            if (operation == "x")
            {
                result = (firstNumber * secondNumber);
                txtBx1.Text = Convert.ToString(result);
                txtBx2.Text = null;
            }
            if (operation == "/")
            {
                /*
                if (secondNumber == 0)
                {
                    txtBx1.Text = "Can't divide by zero";
                    txtBx2.Text = null;

                }
                else
                {
                    result = (firstNumber / secondNumber);
                    txtBx1.Text = Convert.ToString(result);
                    txtBx2.Text = null;
                }
                */
                try
                {
                    if (secondNumber == 0)
                    {
                        FloatingPtDivisonException excepObj = new FloatingPtDivisonException("Excepction type: " + "Floating-Point division by zero");
                        throw excepObj;
                    }
                    result = (firstNumber / secondNumber);
                    txtBx1.Text = Convert.ToString(result);
                    txtBx2.Text = null;
                }
                catch (FloatingPtDivisonException excepObj)
                {
                    txtBx1.Text = "Can't divide by zero";
                    txtBx2.Text = null;
                }
            }
            operation = null;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnSub.Enabled = true;
            btnAdd.Enabled = true;
            completedResult = true;
        }
    }
}
