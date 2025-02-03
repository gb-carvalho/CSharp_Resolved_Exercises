using System;
using System.IO;
using Program.Entities;
using System.Globalization;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This should be a user input, but i don`t wanna write this
            string root_directory = @"C:\Users\GB\Desktop\Projetos\C# (Udemy)\Employee (LINQ)\";
            string file = root_directory + "employees.txt";

            List<Employee> employees = new List<Employee>();
            try
            {
                Console.Write("Enter salary: ");
                double.TryParse(Console.ReadLine(), out double baseSalary);

                StreamReader sr = new StreamReader(file);
                while (!sr.EndOfStream)
                {
                    string[] line_parts = (sr.ReadLine() ?? "").Split(",");
                    string name = line_parts[0];
                    string email = line_parts[1];
                    double salary = double.Parse(line_parts[2], CultureInfo.InvariantCulture);

                    Employee employee = new Employee (name, email, salary); 
                    employees.Add(employee);                   
                }

                IEnumerable<string> Emails = employees
                    .Where(obj => obj.Salary > baseSalary)
                    .OrderBy(obj => obj.Email)
                    .Select(obj => obj.Email);

                double salarySum = employees
                    .Where(obj => obj.Name[0] == 'M')
                    .Sum(obj => obj.Salary);

                Console.WriteLine($"Email of people whose salary is more than {baseSalary:F2}"); 
                foreach (string Email in Emails) 
                {
                    Console.WriteLine(Email);
                }
                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {salarySum:F2}");
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}