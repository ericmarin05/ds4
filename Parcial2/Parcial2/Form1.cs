using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHexToDec_Click(object sender, EventArgs e)
        {

        }

        private void txtHexadecimal(object sender, EventArgs e)
        {

        }

        private void txtDecimalFromHex(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtHex(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDecToHex_Click(object sender, EventArgs e)
        {

        }
    }
}




namespace Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Conversión de Hexadecimal a Decimal
        private void btnHexToDecimal_Click(object sender, EventArgs e)
        {
            try
            {
                string hexValue = txtHex.Text;
                int decimalValue = Convert.ToInt32(hexValue, 16);
                txtDecimal.Text = decimalValue.ToString();
                AddToHistory($"Hexadecimal {hexValue} → Decimal {decimalValue}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Conversión fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Conversión de Decimal a Hexadecimal
        private void btnDecimalToHex_Click(object sender, EventArgs e)
        {
            try
            {
                int decimalValue = int.Parse(txtDecimal.Text);
                string hexValue = decimalValue.ToString("X");
                txtHex.Text = hexValue;
                AddToHistory($"Decimal {decimalValue} → Hexadecimal {hexValue}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Conversión fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Conversión de Octal a Decimal
        private void btnOctalToDecimal_Click(object sender, EventArgs e)
        {
            try
            {
                string octalValue = txtOctal.Text;
                int decimalValue = Convert.ToInt32(octalValue, 8);
                txtDecimal.Text = decimalValue.ToString();
                AddToHistory($"Octal {octalValue} → Decimal {decimalValue}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Conversión fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Conversión de Decimal a Octal
        private void btnDecimalToOctal_Click(object sender, EventArgs e)
        {
            try
            {
                int decimalValue = int.Parse(txtDecimal.Text);
                string octalValue = Convert.ToString(decimalValue, 8);
                txtOctal.Text = octalValue;
                AddToHistory($"Decimal {decimalValue} → Octal {octalValue}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Conversión fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para agregar registros al historial
        private void AddToHistory(string conversion)
        {
            lstHistory.Items.Add(conversion);
        }
    }
}