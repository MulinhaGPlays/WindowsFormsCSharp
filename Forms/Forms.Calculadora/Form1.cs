using System.Globalization;

namespace Forms.Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                textBox1.Text = $"{valor1 + valor2}";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }
    }
}