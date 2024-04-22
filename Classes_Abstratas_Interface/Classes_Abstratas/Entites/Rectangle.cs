namespace Classes_Abstratas.Entites
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(Color color, double width, double height)
        {
            Width = width; 
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
