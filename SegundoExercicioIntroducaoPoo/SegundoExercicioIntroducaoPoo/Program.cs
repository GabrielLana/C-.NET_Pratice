using SegundoExercicioIntroducaoPoo;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            byte exercicio;

            Console.Write("Escolha qual exercício você quer rodar: 1, 2 ou 3? ");
            exercicio = byte.Parse(Console.ReadLine());
            switch (exercicio)
            {
                case 1:
                    ExercicioUm();
                    break;
                case 2:
                    ExercicioDois();
                    break;
                case 3:
                    ExercicioTres();
                    break;
                default:
                    Console.WriteLine("O exercício escolhido não existe. Reinicie e tente novamente :(");
                    break;
            }
        }

        internal static void ExercicioUm()
        {
            Retangulo x = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            x.Largura = double.Parse(Console.ReadLine());
            x.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"AREA = {x.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {x.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {x.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }

        internal static void ExercicioDois()
        {
            Funcionario x = new Funcionario();

            Console.WriteLine("Dados do funcionário:");
            Console.Write("Nome: "); x.Nome = Console.ReadLine();
            Console.Write("Salário bruto: R$"); x.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: R$"); x.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine($"Funcionário: {x}");
            Console.Write("Digite a porcentagem para aumentar o salário: "); x.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados atualizados: {x}");
        }

        internal static void ExercicioTres()
        {
            Aluno x = new Aluno();

            Console.Write("Nome do aluno: "); x.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            x.Trimestre1 = double.Parse(Console.ReadLine());
            x.Trimestre2 = double.Parse(Console.ReadLine());
            x.Trimestre3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"NOTA FINAL = {x.NotaFinal().ToString("F2")}");
            if(x.VerificaSeAlunoFoiAProvado())
            {
                Console.WriteLine("APROVADO");
            } else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {x.DiferencaEntreMediaENotaFinal().ToString("F2")} PONTOS");
            }
        }
    }
}