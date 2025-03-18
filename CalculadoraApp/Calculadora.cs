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
            resultado = valorAtual; // Salva o valor atual para a próxima operação
            valorAtual = 0;
        }

        public void AdicionarNumero(double numero)
        {
            valorAtual = (valorAtual * 10) + numero; // Concatena números digitados
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

            valorAtual = 0; // Reinicia o valor para próximas operações
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
            valorAtual = Math.Floor(valorAtual / 10); // Remove o último dígito
        }

        public double ObterValorAtual()
        {
            return valorAtual;
        }
    }

}
