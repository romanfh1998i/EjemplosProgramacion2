namespace Tarea3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertirCaF_Click(object sender, EventArgs e)
        {
            double convetidor, f;
            f=Double.Parse(textBox1.Text);
            convetidor=(((f-32))*5/9);
            textBox2.Text=convetidor.ToString();



        }

        private void btnFaC_Click(object sender, EventArgs e)
        {
            double convetidor, c; ;
            c=Double.Parse(textBox1.Text);
            convetidor=((c*9/5)+32);
            textBox2.Text=convetidor.ToString();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void comboBoxtemperatura_SelectedIndexChanged(object sender, EventArgs e)
        {


            double k, c, f, convetidor;
            if (comboBoxtemperatura.SelectedItem=="celsius a fahrenheit")
            {
                c=Double.Parse(textBoxtemperatura.Text);
                convetidor=((c*9/5)+32);
                txtboxResultado.Text=convetidor.ToString();

            }
            if(comboBoxtemperatura.SelectedItem=="fahrenheit a celsius")
            {
                f=Double.Parse(textBoxtemperatura.Text);
                convetidor=(((f-32))*5/9);
                txtboxResultado.Text=convetidor.ToString();
            }
        }
    }
}