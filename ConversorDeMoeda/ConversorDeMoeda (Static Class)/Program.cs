using ConversorDeMoeda;
using System;

/* Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais. 
Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6% de IOF 
sobre o valor em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.*/

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacao, qnt_dolar;

            Console.Write("Qual é a cotação do dolar? ");
            cotacao = double.TryParse(Console.ReadLine(), out cotacao) ? cotacao : 0.00;

            Console.Write("Quantos dólares você vai comprar? ");
            qnt_dolar = double.TryParse(Console.ReadLine(), out qnt_dolar) ? qnt_dolar : 0.00;

            Console.WriteLine($"Valor a ser pago em reais: {ConversorDeMoedas.ConverterDolarReal(qnt_dolar, cotacao):F2}");

        }
    }
}