using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraApp
{
    public partial class Form1 : Form
    {
        Calculadora calc = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void btNumero_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; 

            
            if (txtDisplay.Text.EndsWith(" + ") || txtDisplay.Text.EndsWith(" - ") ||
                txtDisplay.Text.EndsWith(" X ") || txtDisplay.Text.EndsWith(" / "))
            {
                txtDisplay.Text += btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }

           
            calc.AdicionarNumero(double.Parse(btn.Text));
        }

        private void btOperador_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

           
            txtDisplay.Text += " " + btn.Text + " ";

           
            calc.DefinirOperador(btn.Text);
        }

       
        
        private void btResultado_Click(object sender, EventArgs e)
        {
        double resultado = calc.Calcular();

    
         txtDisplay.Text += " = " + resultado.ToString(); 
        }

        

        private void btC_Click(object sender, EventArgs e)
        {
            calc.Limpar();
            txtDisplay.Text = "";
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }

         
            if (txtDisplay.Text == "" || txtDisplay.Text == "-")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btVirgula_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains(",")) 
            {
                txtDisplay.Text += ",";
            }
        }

        private void btPorcentagem_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (valor / 100).ToString();
        }

        private void btCE_Click(object sender, EventArgs e)
        {

        }
    }
}
