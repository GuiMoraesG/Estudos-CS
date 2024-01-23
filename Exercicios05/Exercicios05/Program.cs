using System;

namespace Exercicios05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 % num2 == 0)
                {
                    Console.WriteLine("São Multilos");
                }
                else
                {
                    Console.WriteLine("Não são Multiplos");
                }
            }
            else
            {
                if (num2 % num1 == 0)
                {
                    Console.WriteLine("São Multilos");
                }
                else
                {
                    Console.WriteLine("Não são Multiplos");
                }
            }

        }
    }
}
