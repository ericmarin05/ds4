using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;


namespace Proyecto1
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;
        string connectionString = "Data Source=servidor_sql;Initial Catalog=nombre_bd;Integrated Security=True;";

        private void GuardarEnBaseDeDatos(string operacion, string resultado)
        {
            string connectionString = "Data Source=servidor_sql;Initial Catalog=nombre_bd;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO HistorialOperaciones (Operacion, Resultado) VALUES (@Operacion, @Resultado)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Operacion", operacion);
                        command.Parameters.AddWithValue("@Resultado", resultado);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
                }
            }
        }


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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            double number;
            if (double.TryParse(textBox1.Text, out number))
            {
                string previousResult = result.ToString();
                string currentText = textBox1.Text;

                switch (operation)
                {
                    case "+":
                        result += number;
                        HISTORIAL.Items.Add($"{previousResult} + {currentText} = {result}");
                        break;
                    case "−":
                        result -= number;
                        HISTORIAL.Items.Add($"{previousResult} - {currentText} = {result}");
                        break;
                    case "x":
                        result *= number;
                        HISTORIAL.Items.Add($"{previousResult} * {currentText} = {result}");
                        break;
                    case "÷":
                        if (number != 0)
                        {
                            result /= number;
                            HISTORIAL.Items.Add($"{previousResult} ÷ {currentText} = {result}");
                        }
                        else
                        {
                            MessageBox.Show("Error: División por cero.");
                        }
                        break;
                    default:
                        result = number;
                        break;
                }
                textBox1.Text = result.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

