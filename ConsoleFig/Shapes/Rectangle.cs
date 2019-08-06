namespace ConsoleFig.Shapes
{
    class Rectangle : Shape
    {
        double Width { get; set; }
        double Height { get; set; }
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
        public override double Perimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
}
