using System;

namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Point p = new Point();
            Point t;
            t = p;

            t.x = 100;
            t.y = 200;

            Console.WriteLine(p);

            p.x = 10;
            p.y = 20;

            Console.WriteLine(num);
        }
    }
}
