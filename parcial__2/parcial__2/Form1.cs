namespace parcial__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] {
                "1 GB", "2 GB", "4 GB", "8 GB", "16 GB", "32 GB",
                "64 GB", "128 GB", "256 GB", "512 GB", "1 TB", "2 TB"
            });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(textBox1.Text, out int cantidadArchivos) || cantidadArchivos <= 0)
            {
                listBox1.Items.Add("Ingrese una cantidad válida de archivos.");
                return;
            }

            if (!float.TryParse(textBox2.Text, out float tamañoPorArchivo) || tamañoPorArchivo <= 0)
            {
                listBox1.Items.Add("Ingrese un tamaño válido para cada archivo.");
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                listBox1.Items.Add("Seleccione un tamaño de unidad USB.");
                return;
            }

            float tamañoUSBMB = ConvertirTamañoUSBaMB(comboBox1.SelectedItem.ToString());

            float espacioTotalRequeridoMB = cantidadArchivos * tamañoPorArchivo;

            listBox1.Items.Add($"Espacio total requerido: {espacioTotalRequeridoMB} MB");
            listBox1.Items.Add($"Capacidad de la unidad USB: {tamañoUSBMB} MB");

            if (espacioTotalRequeridoMB <= tamañoUSBMB)
            {
                listBox1.Items.Add("Los archivos caben en la unidad USB.");
            }
            else
            {
                listBox1.Items.Add("Los archivos NO caben en la unidad USB.");
            }
            public float ConvertirTamañoUSBaMB(string tamañoUSB)
            {
                string[] partes = tamañoUSB.Split(' ');
                float tamaño = float.Parse(partes[0]);
                string unidad = partes[1];

                return unidad == "GB" ? tamaño * 1024 : tamaño * 1024 * 1024;
            }
        }
    }
}
