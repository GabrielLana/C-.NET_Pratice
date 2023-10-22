using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioFixacaoMatriz1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Qual o tamanho da sua matriz quadrada?: "); int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            List<int> negativeNumbers = new List<int>();

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    Console.Write($"Digite o valor [{x},{y}]: "); matrix[x,y] = int.Parse(Console.ReadLine());
                    if (matrix[x, y] < 0)
                        negativeNumbers.Add(matrix[x, y]);
                }
            }

            Console.WriteLine($"Diagonal principal: ");

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                Console.Write($"{matrix[x, x]} ");
            }

            Console.WriteLine("");
            Console.Write($"Quantidade de números negativos: {negativeNumbers.Count()}");
        }
    }
}
