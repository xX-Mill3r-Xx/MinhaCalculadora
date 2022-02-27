using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MinhaCalculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "9";
        }

        private void btn_virgulaPonto_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += ".";
        }

        private void btn_Adicao_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text != "")
            {
                valor1 = decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
                txt_Resultado.Text = "";
                operacao = "SOMA";
                lbl_Operacao.Text = "+";
            }

        }

        private void btn_Resultado_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txt_Resultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txt_Resultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txt_Resultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                txt_Resultado.Text = Convert.ToString(valor1 / valor2);
            }
            else
            {
                txt_Resultado.Text = "Error.";
            }
        }

        private void btn_Subtracao_Click(object sender, EventArgs e)
        {
            if(txt_Resultado.Text != "")
            {
                valor1 = decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
                txt_Resultado.Text = "";
                operacao = "SUB";
                lbl_Operacao.Text = "-";
            }
            
        }

        private void btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text != "")
            {
                valor1 = decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
                txt_Resultado.Text = "";
                operacao = "MULT";
                lbl_Operacao.Text = "x";
            }

        }

        private void btn_Divisao_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text != "")
            {
                valor1 = decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
                txt_Resultado.Text = "";
                operacao = "DIV";
                lbl_Operacao.Text = "/";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = "";
            lbl_Operacao.Text = "";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lbl_Operacao.Text = "";
        }
    }
}
