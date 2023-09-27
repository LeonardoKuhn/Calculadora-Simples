using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0, resultado = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o Enter seja processado pelo controle
            }
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                btn0.PerformClick();
            }
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                btn1.PerformClick();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btn2.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btn3.PerformClick();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                btn4.PerformClick();
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                btn5.PerformClick();
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                btn6.PerformClick();
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                btn7.PerformClick();
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                btn8.PerformClick();
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                btn9.PerformClick();
            }
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
            {
                btnPonto.PerformClick();
            }
            else if (e.KeyCode == Keys.Add)
            {
                btnSum.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                btnSub.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                btnMul.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                btnDiv.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {
                btnCE.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnC.PerformClick();
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                txtValor1.Text = valor1.ToString();
                operacao = "SOMA";
                txtOperador.Text = "+";
            }
            else if (operacao == "SOMA" && valor1 != 0 && txtResultado.Text != "")
            {
                operacao = "SOMA";
                txtOperador.Text = "+";
                Calcular();
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                txtValor1.Text = valor1.ToString();
                operacao = "SOMA";
                txtOperador.Text = "+";
            }
            else
            {
                operacao = "SOMA";
                txtOperador.Text = "+";
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                txtValor1.Text = valor1.ToString();
                operacao = "SUBTRACAO";
                txtOperador.Text = "-";
            }
            else if (operacao == "SUBTRACAO" && valor1 != 0 && txtResultado.Text != "")
            {
                operacao = "SUBTRACAO";
                txtOperador.Text = "-";
                Calcular();
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                txtValor1.Text = valor1.ToString();
                operacao = "SUBTRACAO";
                txtOperador.Text = "-";
            }
            else
            {
                operacao = "SUBTRACAO";
                txtOperador.Text = "-";
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                txtValor1.Text = valor1.ToString();
                operacao = "MULTIPLICACAO";
                txtOperador.Text = "*";
            }
            else if (operacao == "MULTIPLICACAO" && valor1 != 0 && txtResultado.Text != "")
            {
                operacao = "MULTIPLICACAO";
                txtOperador.Text = "*";
                Calcular();
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                txtValor1.Text = valor1.ToString();
                operacao = "MULTIPLICACAO";
                txtOperador.Text = "*";
            }
            else
            {
                operacao = "MULTIPLICACAO";
                txtOperador.Text = "*";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                txtValor1.Text = valor1.ToString();
                operacao = "DIVISAO";
                txtOperador.Text = "/";
            }
            else if (operacao == "DIVISAO" && valor1 != 0 && txtResultado.Text != "")
            {
                operacao = "DIVISAO";
                txtOperador.Text = "/";
                Calcular();
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                txtValor1.Text = valor1.ToString();
                operacao = "DIVISAO";
                txtOperador.Text = "/";
            }
            else
            {
                operacao = "DIVISAO";
                txtOperador.Text = "/";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtValor1.Text = "";
            operacao = "";
            txtOperador.Text = "";
            valor1 = 0;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            if (txtResultado.Text != "" && valor1 != 0 && operacao != "")
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                switch (operacao.ToUpper())
                {
                    case "SOMA":
                        resultado = valor1 + valor2;
                        txtResultado.Text = resultado.ToString();
                        txtValor1.Text = "";
                        operacao = "";
                        txtOperador.Text = "";
                        break;
                    case "SUBTRACAO":
                        resultado = valor1 - valor2;
                        txtResultado.Text = resultado.ToString();
                        txtValor1.Text = "";
                        operacao = "";
                        txtOperador.Text = "";
                        break;
                    case "MULTIPLICACAO":
                        resultado = valor1 * valor2;
                        txtResultado.Text = resultado.ToString();
                        txtValor1.Text = "";
                        operacao = "";
                        txtOperador.Text = "";
                        break;
                    case "DIVISAO":
                        resultado = valor1 / valor2;
                        txtResultado.Text = resultado.ToString();
                        txtValor1.Text = "";
                        operacao = "";
                        txtOperador.Text = "";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}