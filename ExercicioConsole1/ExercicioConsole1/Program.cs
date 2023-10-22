

using System.Globalization;

namespace ExercicioConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto, ultimoNome;
            byte quartos, idade;
            float preco, altura;
            string[] vet;

            Console.WriteLine("Entre com seu nome completo: ");
            nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?: ");
            quartos = byte.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura");
            vet = Console.ReadLine().Split(" ");
            ultimoNome = vet[0];
            idade = byte.Parse(vet[1]);
            altura = float.Parse(vet[2]);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}