namespace Parcial_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            Registro = new ListBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 68);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 0;
            label1.Text = "\"Tamaño de la unidad USB\"";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(59, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 33);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 68);
            label2.Name = "label2";
            label2.Size = new Size(261, 25);
            label2.TabIndex = 3;
            label2.Text = "Ingrese la cantidad de archivos ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 68);
            label3.Name = "label3";
            label3.Size = new Size(192, 25);
            label3.TabIndex = 4;
            label3.Text = "Ingrese el peso en MB ";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(560, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 31);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(42, 227);
            button1.Name = "button1";
            button1.Size = new Size(169, 68);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Registro
            // 
            Registro.FormattingEnabled = true;
            Registro.ItemHeight = 25;
            Registro.Location = new Point(460, 159);
            Registro.Name = "Registro";
            Registro.Size = new Size(328, 279);
            Registro.TabIndex = 7;
            Registro.SelectedIndexChanged += Registro_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 197);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 8;
            label4.Text = "Resultado ";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Registro);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private ListBox Registro;
        private Label label4;
    }
}
