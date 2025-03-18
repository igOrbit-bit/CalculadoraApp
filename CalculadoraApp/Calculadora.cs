using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraApp
{
    public class Calculadora
    {
        private double resultado;
        private double valorAtual;
        private string operador;

        public Calculadora()
        {
            resultado = 0;
            valorAtual = 0;
            operador = "";
        }

        public void DefinirOperador(string novoOperador)
        {
            operador = novoOperador;
            resultado = valorAtual; 
            valorAtual = 0;
        }

        public void AdicionarNumero(double numero)
        {
            valorAtual = (valorAtual * 10) + numero; 
        }

        public double Calcular()
        {
            switch (operador)
            {
                case "+":
                    resultado += valorAtual;
                    break;
                case "-":
                    resultado -= valorAtual;
                    break;
                case "X":
                    resultado *= valorAtual;
                    break;
                case "/":
                    if (valorAtual != 0)
                        resultado /= valorAtual;
                    else
                        throw new DivideByZeroException("Erro: Divisão por zero!");
                    break;
            }

            valorAtual = 0;
            return resultado;
        }

        public void Limpar()
        {
            resultado = 0;
            valorAtual = 0;
            operador = "";
        }

        public void ApagarUltimoNumero()
        {
            valorAtual = Math.Floor(valorAtual / 10);
        }

        public double ObterValorAtual()
        {
            return valorAtual;
        }
    }

}
