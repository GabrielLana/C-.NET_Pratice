using PrimeiroExercicioIntroducaoPoo;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            byte exercicio;

            Console.Write("Escolha qual exercício você quer rodar, 1 ou 2? ");
            exercicio = byte.Parse(Console.ReadLine());
            switch (exercicio)
            {
                case 1:
                    ExercicioUm();
                    break;
                case 2:
                    ExercicioDois();
                    break;
                default:
                    Console.WriteLine("O exercício escolhido não existe. Reinicie e tente novamente :(");
                    break;
            }
        }

        internal static void ExercicioUm()
        {
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = byte.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = byte.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.Nome}");
            }
            else if (pessoa2.Idade > pessoa1.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
            }
            else
            {
                Console.WriteLine($"Ambos tem a mesma idade");
            }
        }

        internal static void ExercicioDois()
        {
            Funcionario funcionario1, funcionario2;
            float media;
            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: R$");
            funcionario1.Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: R$");
            funcionario2.Salario = float.Parse(Console.ReadLine());

            media = (funcionario1.Salario + funcionario2.Salario) / 2;
            Console.WriteLine($"Salário médio = R${media.ToString("F2")}");
        }
    }
}