using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceiroExercicioIntroducaoPoo
{
    public static class ConversorDeMoeda
    {
        public static double ConverterReaisParaDolar(double cotacao, double qtd)
        {
            var bruto = cotacao * qtd;
            var iof = (bruto / 100) * 6;
            return bruto + iof;
        }
    }
}
