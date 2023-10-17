using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double resultInput;
        char operatorSymbol;
        bool pressedButton;
        private void focusin()
        {
            txtResult.Focus();
            txtResult.Select(txtResult.Text.Length, 1);
        }

        private void clearkan()
        {
            txtResult.Text = "0";
            txtInput.Text = "";
            ClearResult();
        }

        private void ClearResult()
        {
            resultInput = 0;
            operatorSymbol = ' ';
            pressedButton = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            clearkan();
            focusin();
        }

        private void btnAngka_Click(object sender, EventArgs e)
        {
            Button btnNumber = (Button)sender;
            pressedButton = false;
            if(txtResult.Text == "0")
            {
                txtResult.Clear();
            }

            if(operatorSymbol== '=')
            {
                txtResult.Clear();
                operatorSymbol = ' ';
                resultInput=0;
            }
            txtResult.Text = txtResult.Text + btnNumber.Text;
            pressedButton = false;
            focusin();
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btnOperasi = (Button)sender;
            if (pressedButton == false)
            {
                if (txtInput.Text == "")
                {
                    resultInput = Convert.ToDouble(txtResult.Text);
                }
                else
                {
                    if (operatorSymbol == '+')
                    {
                        resultInput = resultInput + Convert.ToDouble(txtResult.Text);
                    }
                    else if (operatorSymbol == '-')
                    {
                        resultInput = resultInput - Convert.ToDouble(txtResult.Text);
                    }
                    else if (operatorSymbol == '÷')
                    {
                        resultInput = resultInput / Convert.ToDouble(txtResult.Text);
                    }
                    else if (operatorSymbol == '×')
                    {
                        resultInput = resultInput * Convert.ToDouble(txtResult.Text);
                    }

                }
            }

            if (btnOperasi.Text == "=")
            {
                txtInput.Text = "";
                txtResult.Text = resultInput.ToString();
            }
            else
            {
                txtInput.Text = resultInput.ToString() + btnOperasi.Text;
                txtResult.Text = "0";
            }

            operatorSymbol = Convert.ToChar(btnOperasi.Text);
            pressedButton = true;
            focusin();
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if(txtResult.Text.Contains (',')== false)
            { 
                txtResult.Text = txtResult.Text + ",";
            }
            if(operatorSymbol== '=')
            {
                ClearResult();
            }
            focusin();
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDouble(txtResult.Text) * -1).ToString();
            focusin();
        }

        private void btnPersen_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDouble(txtResult.Text) * 0.01).ToString();
            focusin();
        }

        private void btnAkar_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDouble(txtResult.Text) * (Convert.ToDouble(txtResult.Text))).ToString();
            focusin();
        }

        private void btnPhi_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDouble(txtResult.Text) * 3.14).ToString();
            focusin();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDouble(txtResult.Text)%2).ToString();
            focusin();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            clearkan();
            focusin();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            if(operatorSymbol== '=')
            {
                ClearResult();
            }
            focusin();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if((txtResult.Text == "") || (txtResult.Text =="-"))
            {
                txtResult.Text = "0";
            }
            if(operatorSymbol == '=')
            {
                ClearResult();
            }
            focusin();
        }

        private Button GetButtonForNumber(char number)
        {
            switch (number)
            {
                case '0':
                    return btn0;
                case '1':
                    return btn1;
                case '2':
                    return btn2;
                case '3':
                    return btn3;
                case '4':
                    return btn4;
                case '5':
                    return btn5;
                case '6':
                    return btn6;
                case '7':
                    return btn7;
                case '8':
                    return btn8;
                case '9':
                    return btn9;
                default:
                    return null;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                btnAngka_Click(GetButtonForNumber(e.KeyChar), null);
            }
            else if (e.KeyChar == ',')
            {
                btnComma_Click(null, null);
            }
            else if (e.KeyChar == '+')
            {
                btnOperator_Click(btnPlus, null);
            }
            else if (e.KeyChar == '-')
            {
                btnOperator_Click(btnMinus, null);
            }
            else if (e.KeyChar == '*')
            {
                btnOperator_Click(btnTime, null);
            }
            else if (e.KeyChar == '/')
            {
                btnOperator_Click(btnDivide, null);
            }
            else if (e.KeyChar == '=')
            {
                btnOperator_Click(btnEquals, null);
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                btnD_Click(null, null);
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                btnOperator_Click(btnEquals, null);
            }
        }

        private void btnKuadrat_Click(object sender, EventArgs e)
        {
            double inputValue = Convert.ToDouble(txtResult.Text);
            double akarKuadrat = Math.Sqrt(inputValue);
            txtResult.Text = akarKuadrat.ToString();
            focusin();
        }
    }
}
