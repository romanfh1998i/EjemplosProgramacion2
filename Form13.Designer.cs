namespace Tarea3
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
            this.btnConvertirCaF = new System.Windows.Forms.Button();
            this.btnFaC = new System.Windows.Forms.Button();
            this.Temperatura = new System.Windows.Forms.Label();
            this.textBoxtemperatura = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.txtboxResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxtemperatura = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertirCaF
            // 
            this.btnConvertirCaF.Location = new System.Drawing.Point(422, 283);
            this.btnConvertirCaF.Name = "btnConvertirCaF";
            this.btnConvertirCaF.Size = new System.Drawing.Size(112, 34);
            this.btnConvertirCaF.TabIndex = 1;
            this.btnConvertirCaF.Text = "Celsius ";
            this.btnConvertirCaF.UseVisualStyleBackColor = true;
            this.btnConvertirCaF.Click += new System.EventHandler(this.btnConvertirCaF_Click);
            // 
            // btnFaC
            // 
            this.btnFaC.Location = new System.Drawing.Point(579, 283);
            this.btnFaC.Name = "btnFaC";
            this.btnFaC.Size = new System.Drawing.Size(112, 34);
            this.btnFaC.TabIndex = 2;
            this.btnFaC.Text = "Fahrenheit";
            this.btnFaC.UseVisualStyleBackColor = true;
            this.btnFaC.Click += new System.EventHandler(this.btnFaC_Click);
            // 
            // Temperatura
            // 
            this.Temperatura.AutoSize = true;
            this.Temperatura.Location = new System.Drawing.Point(74, 154);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(114, 25);
            this.Temperatura.TabIndex = 3;
            this.Temperatura.Text = "Temperatura:";
            // 
            // textBoxtemperatura
            // 
            this.textBoxtemperatura.Location = new System.Drawing.Point(228, 154);
            this.textBoxtemperatura.Name = "textBoxtemperatura";
            this.textBoxtemperatura.Size = new System.Drawing.Size(150, 31);
            this.textBoxtemperatura.TabIndex = 4;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(74, 226);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(94, 25);
            this.Resultado.TabIndex = 5;
            this.Resultado.Text = "Resultado:";
            // 
            // txtboxResultado
            // 
            this.txtboxResultado.Location = new System.Drawing.Point(228, 226);
            this.txtboxResultado.Name = "txtboxResultado";
            this.txtboxResultado.Size = new System.Drawing.Size(150, 31);
            this.txtboxResultado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Temperatura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resultado:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(529, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(529, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 31);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(74, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 48);
            this.label3.TabIndex = 11;
            this.label3.Text = "Convetidor de Grado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Digite el grado que quiera convetir:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Digite el grado que quiera convetir:";
            // 
            // comboBoxtemperatura
            // 
            this.comboBoxtemperatura.AutoCompleteCustomSource.AddRange(new string[] {
            "celsius a fahrenheit",
            "fahrenheit a celsius"});
            this.comboBoxtemperatura.FormattingEnabled = true;
            this.comboBoxtemperatura.Items.AddRange(new object[] {
            "celsius a fahrenheit",
            "fahrenheit a celsius"});
            this.comboBoxtemperatura.Location = new System.Drawing.Point(123, 284);
            this.comboBoxtemperatura.Name = "comboBoxtemperatura";
            this.comboBoxtemperatura.Size = new System.Drawing.Size(230, 33);
            this.comboBoxtemperatura.TabIndex = 14;
            this.comboBoxtemperatura.SelectedIndexChanged += new System.EventHandler(this.comboBoxtemperatura_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxtemperatura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxResultado);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.textBoxtemperatura);
            this.Controls.Add(this.Temperatura);
            this.Controls.Add(this.btnFaC);
            this.Controls.Add(this.btnConvertirCaF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnConvertirCaF;
        private Button btnFaC;
        private Label Temperatura;
        private TextBox textBoxtemperatura;
        private Label Resultado;
        private TextBox txtboxResultado;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxtemperatura;
        private Label label6;
    }
}