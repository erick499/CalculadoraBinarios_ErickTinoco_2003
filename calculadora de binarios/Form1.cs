using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadora_de_binarios
{
    public partial class Form1 : Form
    {

        int valor1;
        int valor2;
        string resultado;
        int total;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void soma_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(@decimal.BinarioParaDecimal(textBox2.Text));
            resultado = "soma";
            textBox2.Text = "";
        }

        private void sub_click(object sender, EventArgs e)
        {
            valor1 = int.Parse(@decimal.BinarioParaDecimal(textBox2.Text));
            resultado = "sub";
            textBox2.Text = "";
        }

        private void multi_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(@decimal.BinarioParaDecimal(textBox2.Text));
            resultado = "mult";
            textBox2.Text = "";
        }

        private void div_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(@decimal.BinarioParaDecimal(textBox2.Text));
            resultado = "div";
            textBox2.Text = "";
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            switch(resultado){
            
                case "soma":
                    valor2 = int.Parse(@decimal.BinarioParaDecimal(textBox2.Text));
                    total = operacoes.soma(valor1,valor2);
                    string valorDecimal4 = @decimal.DecimalParaBinario(total.ToString());
                    textBox2.Text = valorDecimal4;
                    break;

                case "sub":
                    valor2 = int.Parse(@decimal.BinarioParaDecimal(textBox2.Text));
                    total = operacoes.sub(valor1, valor2);
                    string valorDecimal3 = @decimal.DecimalParaBinario(total.ToString());
                    textBox2.Text = valorDecimal3;
                    break;

                case "mult":
                    valor2 = int.Parse(@decimal.BinarioParaDecimal(textBox2.Text));
                    total = operacoes.mult(valor1, valor2);
                    string valorDecimal2 = @decimal.DecimalParaBinario(total.ToString());
                    textBox2.Text = valorDecimal2;
                    break;

                case "div":
                    valor2 = int.Parse(@decimal.BinarioParaDecimal(textBox2.Text));
                    total = operacoes.div(valor1, valor2);
                    string valorDecimal = @decimal.DecimalParaBinario(total.ToString());
                    textBox2.Text = valorDecimal;
                    break;
            }
            
        }

        private void converter_click(object sender, EventArgs e)
        {
            string valorDecimal = @decimal.BinarioParaDecimal(textBox2.Text);
            textBox4.Text = valorDecimal;

            string valorHexaDecimal = @decimal.hexabin(textBox2.Text);
            textBox3.Text = valorHexaDecimal;
        }

    }
}
