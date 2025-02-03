using System;

/*A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.
Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.

Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto,
conforme exemplo.*/

namespace Pensionato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Quantos quartos serão alugados? ");
            n = int.TryParse(Console.ReadLine(), out n) ? n : 0;

            Estudante[] estudantes = new Estudante[10];

            for (int i = 0; i < n; i++)
            {
                string? nome, email;
                int quarto;

                Console.WriteLine("");
                Console.WriteLine($"Aluguel #{i+1}:");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Quarto: ");
                quarto = int.TryParse(Console.ReadLine(), out quarto) ? quarto : 0;

                estudantes[quarto] = new Estudante(nome, email, quarto);
            }

            Console.WriteLine("");
            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < estudantes.Length; i++)
            {
                if(estudantes[i] != null ) Console.WriteLine(estudantes[i]);
            }
        }
    }
}