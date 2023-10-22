using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoAbstracao.Entities
{
    internal class Company : TaxPayer
    {
        public int EmployeeNumber { get; set; }

        public Company() { }

        public Company(string name, double anualIncome, int employeeNumber) : base(name, anualIncome)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double Tax()
        {
            double percent = EmployeeNumber > 10 ? 14 : 16;
            return (AnualIncome / 100) * percent;
        }
    }
}
