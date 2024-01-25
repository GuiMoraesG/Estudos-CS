using System;

namespace OrientacaoOBJ
{
    internal class Triangulo
    {

        public double A;
        public double B;
        public double C;

        public double Area()
        {
            return (A + B + C) / 2;
        }
    }
}
