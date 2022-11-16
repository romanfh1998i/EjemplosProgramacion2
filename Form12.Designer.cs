namespace WinFormsApp1
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
            this.Valor1_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Valor_2_Text_Box = new System.Windows.Forms.TextBox();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMultiplicacion = new System.Windows.Forms.Button();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonResta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Valor1_TextBox
            // 
            this.Valor1_TextBox.BackColor = System.Drawing.Color.Chartreuse;
            this.Valor1_TextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Valor1_TextBox.Location = new System.Drawing.Point(106, 49);
            this.Valor1_TextBox.Name = "Valor1_TextBox";
            this.Valor1_TextBox.Size = new System.Drawing.Size(100, 23);
            this.Valor1_TextBox.TabIndex = 0;
            this.Valor1_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 2:";
            // 
            // Valor_2_Text_Box
            // 
            this.Valor_2_Text_Box.BackColor = System.Drawing.Color.GreenYellow;
            this.Valor_2_Text_Box.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Valor_2_Text_Box.Location = new System.Drawing.Point(106, 93);
            this.Valor_2_Text_Box.Name = "Valor_2_Text_Box";
            this.Valor_2_Text_Box.Size = new System.Drawing.Size(100, 23);
            this.Valor_2_Text_Box.TabIndex = 3;
            // 
            // buttonDivision
            // 
            this.buttonDivision.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonDivision.Location = new System.Drawing.Point(231, 42);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(53, 28);
            this.buttonDivision.TabIndex = 4;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(36, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite los siguentes valores:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonMultiplicacion
            // 
            this.buttonMultiplicacion.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonMultiplicacion.Location = new System.Drawing.Point(231, 88);
            this.buttonMultiplicacion.Name = "buttonMultiplicacion";
            this.buttonMultiplicacion.Size = new System.Drawing.Size(53, 28);
            this.buttonMultiplicacion.TabIndex = 6;
            this.buttonMultiplicacion.Text = "*";
            this.buttonMultiplicacion.UseVisualStyleBackColor = true;
            this.buttonMultiplicacion.Click += new System.EventHandler(this.buttonMultiplicacion_Click);
            // 
            // buttonSuma
            // 
            this.buttonSuma.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSuma.Location = new System.Drawing.Point(231, 140);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(53, 28);
            this.buttonSuma.TabIndex = 7;
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = true;
            this.buttonSuma.Click += new System.EventHandler(this.buttonSuma_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.BackColor = System.Drawing.Color.GreenYellow;
            this.textBoxResultado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxResultado.Location = new System.Drawing.Point(106, 144);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(100, 23);
            this.textBoxResultado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(36, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonResta
            // 
            this.buttonResta.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonResta.Location = new System.Drawing.Point(231, 194);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(53, 28);
            this.buttonResta.TabIndex = 10;
            this.buttonResta.Text = "-";
            this.buttonResta.UseVisualStyleBackColor = true;
            this.buttonResta.Click += new System.EventHandler(this.buttonResta_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(117, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(296, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.buttonMultiplicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.Valor_2_Text_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Valor1_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Valor1_TextBox;
        private Label label1;
        private Label label2;
        private TextBox Valor_2_Text_Box;
        private Button buttonDivision;
        private Label label3;
        private Button buttonMultiplicacion;
        private Button buttonSuma;
        private TextBox textBoxResultado;
        private Label label4;
        private Button buttonResta;
        private Button button1;
    }
}