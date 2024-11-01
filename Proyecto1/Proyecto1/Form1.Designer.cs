namespace Proyecto1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button11 = new Button();
            button12 = new Button();
            button15 = new Button();
            button14 = new Button();
            button16 = new Button();
            button13 = new Button();
            buttonNegativo = new Button();
            buttonDecimal = new Button();
            HISTORIAL = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 24);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(192, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button0
            // 
            button0.Location = new Point(78, 209);
            button0.Name = "button0";
            button0.Size = new Size(60, 40);
            button0.TabIndex = 1;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 163);
            button1.Name = "button1";
            button1.Size = new Size(60, 40);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(78, 163);
            button2.Name = "button2";
            button2.Size = new Size(60, 40);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(144, 163);
            button3.Name = "button3";
            button3.Size = new Size(60, 40);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 117);
            button4.Name = "button4";
            button4.Size = new Size(60, 40);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(78, 117);
            button5.Name = "button5";
            button5.Size = new Size(60, 40);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(144, 117);
            button6.Name = "button6";
            button6.Size = new Size(60, 40);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 71);
            button7.Name = "button7";
            button7.Size = new Size(60, 40);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(78, 71);
            button8.Name = "button8";
            button8.Size = new Size(60, 40);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(144, 71);
            button9.Name = "button9";
            button9.Size = new Size(60, 40);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button11
            // 
            button11.Location = new Point(297, 117);
            button11.Name = "button11";
            button11.Size = new Size(60, 40);
            button11.TabIndex = 11;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = true;
            button11.Click += buttonSum_Click;
            // 
            // button12
            // 
            button12.Location = new Point(297, 71);
            button12.Name = "button12";
            button12.Size = new Size(60, 40);
            button12.TabIndex = 12;
            button12.Text = "−";
            button12.UseVisualStyleBackColor = true;
            button12.Click += buttonSubtract_Click;
            // 
            // button15
            // 
            button15.Location = new Point(220, 71);
            button15.Name = "button15";
            button15.Size = new Size(60, 40);
            button15.TabIndex = 13;
            button15.Text = "x";
            button15.UseVisualStyleBackColor = true;
            button15.Click += buttonMultiply_Click;
            // 
            // button14
            // 
            button14.Location = new Point(220, 117);
            button14.Name = "button14";
            button14.Size = new Size(60, 40);
            button14.TabIndex = 14;
            button14.Text = "÷";
            button14.UseVisualStyleBackColor = true;
            button14.Click += buttonDivide_Click;
            // 
            // button16
            // 
            button16.Location = new Point(220, 19);
            button16.Name = "button16";
            button16.Size = new Size(60, 40);
            button16.TabIndex = 15;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = true;
            button16.Click += buttonEqual_Click;
            // 
            // button13
            // 
            button13.Location = new Point(297, 19);
            button13.Name = "button13";
            button13.Size = new Size(60, 40);
            button13.TabIndex = 16;
            button13.Text = "C";
            button13.UseVisualStyleBackColor = true;
            button13.Click += buttonClear_Click;
            // 
            // buttonNegativo
            // 
            buttonNegativo.Location = new Point(220, 163);
            buttonNegativo.Name = "buttonNegativo";
            buttonNegativo.Size = new Size(60, 40);
            buttonNegativo.TabIndex = 17;
            buttonNegativo.Text = "±";
            buttonNegativo.UseVisualStyleBackColor = true;
            buttonNegativo.Click += buttonNegativo_Click;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Location = new Point(297, 163);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(60, 40);
            buttonDecimal.TabIndex = 18;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = true;
            buttonDecimal.Click += buttonDecimal_Click;
            // 
            // HISTORIAL
            // 
            HISTORIAL.FormattingEnabled = true;
            HISTORIAL.ItemHeight = 25;
            HISTORIAL.Location = new Point(388, 24);
            HISTORIAL.Name = "HISTORIAL";
            HISTORIAL.Size = new Size(324, 229);
            HISTORIAL.TabIndex = 19;
            HISTORIAL.SelectedIndexChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            ClientSize = new Size(740, 276);
            Controls.Add(HISTORIAL);
            Controls.Add(buttonDecimal);
            Controls.Add(buttonNegativo);
            Controls.Add(button13);
            Controls.Add(button16);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11; // Sumar
        private System.Windows.Forms.Button button12; // Restar
        private System.Windows.Forms.Button button15; // Multiplicar
        private System.Windows.Forms.Button button14; // Dividir
        private System.Windows.Forms.Button button16; // Igual
        private System.Windows.Forms.Button button13; // Limpiar
        private System.Windows.Forms.Button buttonNegativo; // Cambiar signo
        private System.Windows.Forms.Button buttonDecimal; // Punto decimal
        private ListBox HISTORIAL;
    }
}

