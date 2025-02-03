using System;

/*Fazer um programa para ler dois números inteiros M e N, e depois ler
uma matriz de M linhas por N colunas contendo números inteiros,
podendo haver repetições. Em seguida, ler um número inteiro X que
pertence à matriz. Para cada ocorrência de X, mostrar os valores à
esquerda, acima, à direita e abaixo de X, quando houver, conforme
exemplo.*/

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Linhas e Colunas: ");
            string[] dimensoes = (Console.ReadLine() ?? "").Split(' ');

            if (dimensoes.Length != 2) {
                Console.WriteLine("Entrada errada.");
                return;
            }

            int linhas = int.Parse(dimensoes[0]);
            int colunas = int.Parse(dimensoes[1]);
            int[,] matriz = new int[linhas, colunas];

            Console.WriteLine("Matriz: ");
            for (int i = 0; i < linhas; i++)
            {
                string[] linha = (Console.ReadLine() ?? "").Split(' ');
                for (int j = 0; j < colunas; j++) {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }

            Console.Write("Número Inteiro: ");
            int numero;
            numero = int.TryParse(Console.ReadLine(), out numero) ? numero : 0;
            bool encontrado = false;

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Posição ({i},{j})");

                        if (j - 1 >= 0) Console.WriteLine($"Esquerda {matriz[i, j - 1]}");
                        else Console.WriteLine("Não há elementos à esquerda");

                        if (j + 1 > colunas) Console.WriteLine($"Direita {matriz[i, j + 1]}");
                        else Console.WriteLine("Não há elementos à direita");

                        if (i - 1 >= 0) Console.WriteLine($"Acima {matriz[i - 1, j]}");
                        else Console.WriteLine("Não há elementos acima");

                        if (i + 1 > linhas)  Console.WriteLine($"Abaixo {matriz[i + 1, j]}");
                        else Console.WriteLine("Não há elementos abaixo");

                        encontrado = true;
                    }
                }
            }

            if(!encontrado) Console.WriteLine($"O número {numero}, não foi encontrado na matriz.");
        }
    }
}