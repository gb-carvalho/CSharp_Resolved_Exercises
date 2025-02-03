using System;
using System.Collections.Generic;
using System.Globalization;

/*
Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.
*/

namespace RegisterEmployees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Employee? employee;

            Console.Write("How many employees will be registered? ");
            n = int.TryParse(Console.ReadLine(), out n) ? n : 0;

            List<Employee> employees = new List<Employee>();
            
            for (int i = 0; i < n; i++)
            {
                int id;
                string? name;
                double salary;

                Console.WriteLine("");
                Console.WriteLine($"Emplyoee #{i + 1}:");
                Console.Write("Id: ");
                id = int.TryParse(Console.ReadLine(), out id) ? id : 0;
                Console.Write("Nome: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.TryParse(Console.ReadLine(), out salary) ? salary : 0;

                employee = new Employee(id, name, salary);
                employees.Add(employee);
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase : ");
            int id_increase;
            id_increase = int.TryParse(Console.ReadLine(), out id_increase) ? id_increase : 0;

            employee = employees.Find(x => x.Id == id_increase);
            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.TryParse(Console.ReadLine(), out percentage) ? percentage : 0;
                employee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach(Employee obj in employees)
            {
                Console.WriteLine(obj);
            }

        }
    }
}