namespace Classes_Abstratas.Entites
{
    abstract internal class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
