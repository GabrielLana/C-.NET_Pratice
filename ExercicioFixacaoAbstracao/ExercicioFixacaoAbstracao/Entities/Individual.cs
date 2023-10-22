using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoAbstracao.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpensives { get; set; }

        public Individual() { }

        public Individual(string name, double anualIncome, double healthExpensives) : base(name, anualIncome) 
        {
            HealthExpensives = healthExpensives;
        }

        public override double Tax()
        {
            double percent = AnualIncome < 20000 ? 15 : 25;
            return ((AnualIncome / 100) * percent) - ((HealthExpensives / 100) * 50);
        }
    }
}
