using System;
using System.Collections.Generic;

namespace Estudando_HashSet_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = 'A';
            HashSet<int> Students = new HashSet<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"How many studentes for Cor {c}? ");
                int N = int.Parse(Console.ReadLine());

                for (int j = 0; j < N; j++) 
                {
                    Console.WriteLine();
                    int student = int.Parse(Console.ReadLine());

                    Students.Add(student);
                }
                c++;
            }

            Console.WriteLine($"Total Students: {Students.Count}");
        }
    }
}
