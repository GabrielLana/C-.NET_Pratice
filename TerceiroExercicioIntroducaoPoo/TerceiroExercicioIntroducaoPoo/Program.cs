using System.Globalization;
using TerceiroExercicioIntroducaoPoo;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao, qtd;

            Console.Write("Qual é a cotação do dólar? "); cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? "); qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.ConverterReaisParaDolar(cotacao, qtd).ToString("F2")}");
        }
    }
}