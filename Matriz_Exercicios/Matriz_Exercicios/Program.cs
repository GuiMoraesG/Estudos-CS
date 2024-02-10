using System;
using System.Collections.Generic;
using System.Xml;

namespace Matriz_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite valores: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];
            List<int> list = new List<int>();

            Console.WriteLine("Digite a posição: ");
            int pos = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matriz[i, j] == pos)
                    {
                        Console.WriteLine($"Posições: {i}, {j}");
                    }
                }
            }
        }
    }
}
