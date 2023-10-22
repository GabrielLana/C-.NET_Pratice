using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioFixacaoMatriz2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de linhas da matriz: "); int x = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de colunas da matriz: "); int y = int.Parse(Console.ReadLine());

            int[,] matrix = new int[x, y];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Digite o valor do campo [{i},{j}]: "); matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Digite um número existente na matriz: "); int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0;j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == n)
                    {
                        Console.WriteLine($"Posição: [{i}, {j}]");
                        if(j - 1 >= 0)
                            Console.WriteLine($"Esquerda: {matrix[i, j - 1]}");
                        if(i - 1 >= 0)
                            Console.WriteLine($"Cima: {matrix[i - 1, j]}");
                        if(j + 1 < matrix.GetLength(1))
                            Console.WriteLine($"Direita: {matrix[i, j + 1]}");
                        if(i + 1 < matrix.GetLength(0))
                            Console.WriteLine($"Baixo: {matrix[i + 1, j]}");
                    }
                }
            }
        }
    }
}
