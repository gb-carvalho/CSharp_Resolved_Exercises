﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterEmployees
{
    internal class Employee
    {
        public int Id { get; private set; } 
        public string? Name { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string? name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100.0);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, R${Salary:F2}";
        }

    }
}
