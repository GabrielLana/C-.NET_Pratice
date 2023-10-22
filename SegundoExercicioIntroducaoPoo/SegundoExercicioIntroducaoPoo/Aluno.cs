using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoExercicioIntroducaoPoo
{
    internal class Aluno
    {

        public string Nome { get; set; }
        public double Trimestre1 { get; set; }
        public double Trimestre2 { get; set; }
        public double Trimestre3 { get; set; }

        public double NotaFinal()
        {
            return Trimestre1 + Trimestre2 + Trimestre3;
        }

        public bool VerificaSeAlunoFoiAProvado()
        {
            return NotaFinal() >= 60;
        }

        public double DiferencaEntreMediaENotaFinal()
        {
            return 60 - NotaFinal();
        }
    }
}
