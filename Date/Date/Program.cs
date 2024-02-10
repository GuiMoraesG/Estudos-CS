using System;

namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2020, 3, 1);
            DateTime d3 = DateTime.Parse("2000-03-01");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(0, 1, 30);

            Console.WriteLine(t1);
            Console.WriteLine(t2);

        }
    }
}
