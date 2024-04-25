using System;
using System.Collections.Generic;
using System.Linq;

namespace Estudo_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
