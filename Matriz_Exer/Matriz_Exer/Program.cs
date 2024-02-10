using System;
using System.Collections.Generic;

namespace Matriz_Exer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor");
            int n = int.Parse(Console.ReadLine());

            List<int> lista = new List<int>();
            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (matriz[i, j] < 0)
                    {
                        lista.Add(matriz[i, j]);
                    }
                }
            }

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{matriz[i, i]} ");
            }

            Console.WriteLine("\nNegative Numbers: ");
            Console.WriteLine(lista.Count);
        }
    }
}
