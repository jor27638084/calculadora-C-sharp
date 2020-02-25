using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string operador;
        int a = 0;
        bool validar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {

        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_numerador(object sender, EventArgs e)
        {
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
           
        }

        private void entrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void btn_numerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            text_valor.Text = text_valor.Text + bt.Text;
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            text_valor.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            if(validar == true)
            {
                a = a + Convert.ToInt32(text_valor.Text);
                label1.Text = Convert.ToString(a) + " + ";
                text_valor.Text = "";
                operador = "+";
            }
            else
            {
                label1.Text = text_valor.Text + btn_adicao.Text;
                a = Convert.ToInt32(text_valor.Text);
                text_valor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(text_valor.Text);
                label1.Text = Convert.ToString(a) + " - ";
                text_valor.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = text_valor.Text + btn_subtracao.Text;
                text_valor.Text = "";
                operador = "-";
                validar = true;

            }
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToInt32(text_valor.Text);
                label1.Text = Convert.ToString(a) + " / ";
                text_valor.Text = "";
                operador = "/";
            }
            else
            {
                label1.Text = text_valor.Text + btn_divisao.Text;
                text_valor.Text = "";
                operador = "/";
                validar = true;

            }
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToInt32(text_valor.Text);
                label1.Text = Convert.ToString(a) + " * ";
                text_valor.Text = "";
                operador = "*";
            }
            else
            {
                label1.Text = text_valor.Text + btn_multiplicacao.Text;
                text_valor.Text = "";
                operador = "*";
                validar = true;

            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if(operador == "+")
            {
                label1.Text = label1.Text + text_valor.Text + "=";
                text_valor.Text = Convert.ToString(a + Convert.ToInt32(text_valor.Text));
            } 
            else if (operador == "-")
            {
                label1.Text = label1.Text + text_valor.Text + "=";
                text_valor.Text = Convert.ToString(a - Convert.ToInt32(text_valor.Text));
            }
            else if (operador == "/")
            {
                label1.Text = label1.Text + text_valor.Text + "=";
                text_valor.Text = Convert.ToString(a / Convert.ToInt32(text_valor.Text));
            }
            else if (operador == "*")
            {
                label1.Text = label1.Text + text_valor.Text + "=";
                text_valor.Text = Convert.ToString(a * Convert.ToInt32(text_valor.Text));
            }
        }
    }
}
