using System;

namespace Classes_Abstratas.Entites
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
