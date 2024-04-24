using System;

namespace Estudo_Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2024, 4, 24, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            String s1 = "Good Morning dear Students";

            Console.WriteLine(s1.Cut(10));
        }
    }
}
