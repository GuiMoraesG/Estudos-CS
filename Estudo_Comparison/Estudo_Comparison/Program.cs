using System;
using Estudo_Comparison.Entities;
using Estudo_Comparison.Service;

namespace Estudo_Comparison
{
    internal class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 4;
            double b = 5;

            BinaryNumericOperation op = CalculationService.Sum;
            double result = op(a, b);

            Console.WriteLine(result);
        }
    }
}
