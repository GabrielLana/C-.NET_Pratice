using ExercicioFixacaoAbstracao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioFixacaoAbstracao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: "); int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or company (i/c): "); string type = Console.ReadLine();
                Console.Write("Name: "); string name = Console.ReadLine();
                Console.Write("Anual income: $"); double income = double.Parse(Console.ReadLine());
                switch (type)
                {
                    case "i":
                        Console.Write("Health expensives: $"); double expensives = double.Parse(Console.ReadLine());
                        taxPayers.Add(new Individual(name, income, expensives));
                        break;
                    case "c":
                        Console.Write("Number of employees: "); int employees = int.Parse(Console.ReadLine());
                        taxPayers.Add(new Company(name, income, employees));
                        break;
                    default:
                        Console.WriteLine("Please choose a correct type!");
                        i--;
                        break;
                }
            }

            Console.WriteLine("Taxes Paid:");
            double sum = 0;
            foreach (var payer in taxPayers)
            {
                double tax = payer.Tax();
                sum += tax;
                Console.WriteLine($"{payer.Name}: ${tax.ToString("F2")}");
            }

            Console.WriteLine($"Total taxes: ${sum.ToString("F2")}");
        }
    }
}
