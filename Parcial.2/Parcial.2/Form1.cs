using System;
using System.Windows.Forms;

namespace Parcial._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            comboBox1.Items.Add("GB a MB");
            comboBox1.Items.Add("MB a GB");
            comboBox1.SelectedIndex = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (!double.TryParse(textBox1.Text, out double inputValue))
                {
                    throw new FormatException("Por favor, ingresa un valor numérico válido.");
                }

                string conversionType = comboBox1.SelectedItem.ToString();
                double result = 0;

                if (conversionType == "GB a MB")
                {
                    result = ConvertGbToMb(inputValue);
                }
                else if (conversionType == "MB a GB")
                {
                    result = ConvertMbToGb(inputValue);
                }


                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    throw new OverflowException("El resultado de la conversión es demasiado grande o pequeño para ser representado.");
                }

             
                textBox2.Text = result.ToString();

                
                string historyEntry = $"{DateTime.Now}: {inputValue} {conversionType} -> {result}";
                Registro.Items.Add(historyEntry);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de Desbordamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private double ConvertGbToMb(double gb)
        {
            if (gb < 0)
            {
                throw new ArgumentOutOfRangeException("El valor de GB no puede ser negativo.");
            }
            return gb * 1024;
        }

        
        private double ConvertMbToGb(double mb)
        {
            if (mb < 0)
            {
                throw new ArgumentOutOfRangeException("El valor de MB no puede ser negativo.");
            }
            return mb / 1024; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
