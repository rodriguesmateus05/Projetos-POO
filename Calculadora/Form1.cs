using System.Globalization;
using System.Linq.Expressions;
using System.Net.WebSockets;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal result = 0;
        decimal result2 = 0;
        String operacao = "";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void b0_Click(object sender, EventArgs e)
        {
            resultado.Text= resultado.Text+ "0";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "9";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            result = 0;
            result2 = 0;
            operacao = "";
            op2.Text = "";
            op.Text = "";
        }

        

        private void bponto_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + ".";
        }

        private void opIgual_Click(object sender, EventArgs e)
        {
            result2 = decimal.Parse(resultado.Text,CultureInfo.InvariantCulture);
            
            switch (operacao) 
            {
                case "+":
                    resultado.Text = Convert.ToString(result + result2);
                    break;
                case "-":
                   resultado.Text = Convert.ToString(result - result2);
                    break;
                case "*":
                   resultado.Text = Convert.ToString(result * result2);
                    break;
                case "/":
                   resultado.Text = Convert.ToString(result / result2);
                    break;
              

            }

            /*
            if (op.Text == "+")
            {
                resultado.Text = Convert.ToString(result + result2);
            }
            else if (op.Text == "-")
            {

            }
            else if (op.Text == "*")
            {

            }
            else if (op.Text == "/")
            {

            }
            else { 
            
            }
            */

        }
        private void opSomar_Click(object sender, EventArgs e)
        {
            result = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            resultado.Text = "";
            String valor =  Convert.ToString(result);
            operacao = "+";
            op2.Text = $"{valor} " + "+";
            op.Text = "+";
            
        }
        private void opSubtrair_Click(object sender, EventArgs e)
        {
            result = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            resultado.Text = "";
            String valor = Convert.ToString(result);
            operacao = "-";
            op2.Text = $"{valor} " + "-";
            op.Text = "-";
        }

        private void opMultiplicar_Click(object sender, EventArgs e)
        {
            result = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            resultado.Text = "";
            String valor = Convert.ToString(result);
            operacao = "*";
            op2.Text = $"{valor} " + "*";
            op.Text = "*";
        }

        private void opDividir_Click(object sender, EventArgs e)
        {
            result = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            resultado.Text = "";
            String valor = Convert.ToString(result);
            operacao = "/";
            op2.Text = $"{valor} " + "/";
            op.Text = "/";
        }
    }
}