using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoExercicioIntroducaoPoo
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public override string ToString()
        {
            double liquido = SalarioBruto - Imposto;
            return $"{Nome}, R${liquido.ToString("F2")}";
        }

        public void AumentarSalario(double porcentagem)
        {
            double valorAumento = (SalarioBruto / 100) * porcentagem;
            SalarioBruto += valorAumento;
        }
    }
}
