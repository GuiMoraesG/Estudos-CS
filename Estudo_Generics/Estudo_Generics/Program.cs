using System;

namespace Estudo_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int value = int.Parse(Console.ReadLine());

                printService.AddValue(value);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
