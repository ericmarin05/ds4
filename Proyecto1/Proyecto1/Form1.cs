using System;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || isOperationPerformed)
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "+";
            isOperationPerformed = true;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "−";
            isOperationPerformed = true;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "x";
            isOperationPerformed = true;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "÷";
            isOperationPerformed = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            operation = "";
        }

        private void buttonNegativo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double number = double.Parse(textBox1.Text);
                number = -number;
                textBox1.Text = number.ToString();
            }
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
                textBox1.Text += ".";
        }

        private void PerformOperation()
        {
            double number;
            if (double.TryParse(textBox1.Text, out number))
            {
                switch (operation)
                {
                    case "+":
                        result += number;
                        break;
                    case "−":
                        result -= number;
                        break;
                    case "x":
                        result *= number;
                        break;
                    case "÷":
                        result /= number;
                        break;
                    default:
                        result = number;
                        break;
                }
                textBox1.Text = result.ToString();
            }
        }
    }
}

