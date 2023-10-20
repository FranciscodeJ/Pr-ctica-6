namespace Práctica__6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(textBox1.Text);       // Se declaran los espacios en las cajas de texto para los valores que se escribirán en la base y en la altura del tríangulo.
            float valor2 = float.Parse(textBox2.Text);
            float valor3 = valor1 * valor2 / 2;                //Se declará la fórmula para obtener el área  del triángulo.

            textBox3.Text = valor3.ToString();                 //Se declara que en la carja de texto 3 se mostrará el valor resultante de la fórmula del área del tríangulo.

        }
    }
}
