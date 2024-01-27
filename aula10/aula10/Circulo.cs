using System;

namespace aula10
{
    internal class Circulo
    {
        public double Raio;
        public double PI = Math.PI;

        public double Circunferencia()
        {
            return (2 * PI) * Raio;
        }

        public double Volume()
        {
            return (4.0 / 3.0) * PI * Math.Pow(Raio, 3);
        }
    }

}
