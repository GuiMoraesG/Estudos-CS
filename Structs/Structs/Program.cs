using System;

namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? x = 2;
            double? y = 10.3;
            double z = x ?? 0.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);

            Console.WriteLine(z);
        }
    }
}
