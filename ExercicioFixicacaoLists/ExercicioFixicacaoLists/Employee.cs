using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixicacaoLists
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, R${Salary.ToString("F2")}";
        }

        public void RaiseSalary(double percentage)
        {
            Salary += (Salary / 100) * percentage;
        }
    }
}
