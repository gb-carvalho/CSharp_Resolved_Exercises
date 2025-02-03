using System;
using System.Globalization;
using System.Net.Security;
using System.Security.Cryptography;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R${preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é R${preco2:F2}");
            Console.WriteLine();
            Console.WriteLine("Registo: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arrendondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.Write("Escreva inteiros, separados por espaço: ");

            string line = Console.ReadLine() ?? string.Empty;
            string[] lista = line.Split(' ');

            if (lista[0] == "")
            {
                Console.WriteLine("Nada foi escrito");
            }
            else
            { 
                for (int i = 0; i < lista.Length; i++)
                {
                    Console.WriteLine(lista[i]);
                }
            }



        }
    }
}