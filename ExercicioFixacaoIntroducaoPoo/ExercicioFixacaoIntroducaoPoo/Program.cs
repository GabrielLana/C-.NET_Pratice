
using ExercicioFixacaoIntroducaoPoo;
using System.Globalization;

namespace Course
{
    public class Course
    {
        public static void Main(string[] args)
        {
            ContaBancaria contaBancaria;

            {
                string conta, nome, haveraDeposito;
                double deposito;

                Console.Write("Entre o número da conta: "); conta = Console.ReadLine();
                Console.Write("Entre o titular da conta: "); nome = Console.ReadLine();
                Console.Write("Haverá depósito inicial (s/n)? "); haveraDeposito = Console.ReadLine();
                while (haveraDeposito != "s" && haveraDeposito != "n")
                {
                    Console.WriteLine("Por favor responda apenas com 's' ou 'n'.");
                    Console.Write("Haverá depósito inicial (s/n)? "); haveraDeposito = Console.ReadLine();
                }
                if(haveraDeposito == "s")
                {
                    Console.Write("Entre o valor de depósito inicial: R$"); deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contaBancaria = new ContaBancaria(conta, nome, deposito);
                }
                else
                {
                    contaBancaria = new ContaBancaria(conta, nome);
                }
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);
            Console.Write("Entre um valor para depósito: R$"); contaBancaria.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);
            Console.Write("Entre um valor para saque: R$"); contaBancaria.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);
        }
    }
}
