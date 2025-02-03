using NotaAluno;
using System;

/* Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano 
(o primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final 
do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos 
faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno 
para resolver este problema. */

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            double nota;

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");

            aluno.Nota1 = double.TryParse(Console.ReadLine(), out nota) ? nota : 0.00;
            aluno.Nota2 = double.TryParse(Console.ReadLine(), out nota) ? nota : 0.00;
            aluno.Nota3 = double.TryParse(Console.ReadLine(), out nota) ? nota : 0.00;

            Console.WriteLine($"Nota Final = {aluno.NotaFinal():F2}");

            if (aluno.Aprovado())
                Console.WriteLine($"Aluno {aluno.Nome} Aprovado.");
            else
                Console.WriteLine($"Aluno {aluno.Nome} Reprovado \nFaltaram {aluno.NotaRestante():F2} pontos.");
            

        }
    }
}