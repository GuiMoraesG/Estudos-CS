using System;

namespace Vetores3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            Calc.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
