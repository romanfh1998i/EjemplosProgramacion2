namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2, Division;
            valor1=double.Parse(Valor1_TextBox.Text);
            valor2=double.Parse(Valor_2_Text_Box.Text);
            Division=valor1/valor2;
            textBoxResultado.Text=Division.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            double valor1, valor2,resta;
            valor1=double.Parse(Valor1_TextBox.Text);
            valor2=double.Parse(Valor_2_Text_Box.Text);
            resta=valor1-valor2;
            textBoxResultado.Text=resta.ToString();

        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            int valor1, valor2, suma;
            valor1=int.Parse(Valor1_TextBox.Text);
            valor2=int.Parse(Valor_2_Text_Box.Text);
            suma=valor1+valor2;
            textBoxResultado.Text=suma.ToString();
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            int valor1, valor2, multiplicacion;
            valor1=int.Parse(Valor1_TextBox.Text);
            valor2=int.Parse(Valor_2_Text_Box.Text);
            multiplicacion=valor1*valor2;
            textBoxResultado.Text=multiplicacion.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Valor1_TextBox.Clear();
            Valor_2_Text_Box.Clear();
            textBoxResultado.Clear();
        }
    }
}