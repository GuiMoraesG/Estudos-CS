using System;

namespace OrientacaoOBJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double areaX, areaY;
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os valores do triangulo X: ");

            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            areaX = (x.A + x.B + x.C) / 2;

            Console.WriteLine("Digite os valores do triangulo Y: ");

            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            areaY = (y.A + y.B + y.C) / 2;

            Console.WriteLine($"A area de X é {areaX.ToString("F2")}");
            Console.WriteLine($"A area de Y é {areaY.ToString("F2")}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior valor: X");
            }
            else
            {
                Console.WriteLine("Maior valor: Y");
            }
        }
    }
}
