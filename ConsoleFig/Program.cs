using System;

namespace ConsoleFig
{
    abstract class Figura
    {
        public abstract float Area();
        public abstract float Perimeter();
    }
    class Rectangle:Figura
    {
        float Width { get; set; }
        float Height { get; set; }
        public Rectangle(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override float Area()
        {
            return Width * Height;
        }
        public override float Perimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
    class Circle : Figura
    {
        float Radius { get; set; }
        public Circle(float radius)
        {
            this.Radius = radius;
        }
        public override float Area()
        {
            return (float)3.14 * Radius * Radius;
        }
        public override float Perimeter()
        {
            return 2 * (float)3.14 * Radius;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\t***Figura***");
                Console.WriteLine("1.Rectangle");
                Console.WriteLine("2.Circle");
                Console.Write("\nEnter figure nubmer: ");
                int number = Convert.ToInt32(Console.ReadLine());
                
                switch(number)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\t***Figura***");
                        Console.Write("Enter width of the rectangle: ");
                        float width = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Enter height of the rectangle: ");
                        float height = Convert.ToSingle(Console.ReadLine());
                        Rectangle rec1 = new Rectangle(width, height);

                        Console.Clear();
                        Console.WriteLine("1.Perimeter");
                        Console.WriteLine("2.Area");
                        Console.Write("Enter number: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        if(n ==1)
                        {
                            Console.WriteLine($"Perimeter rectangle is {rec1.Perimeter()}");
                        }
                        else if(n==2)
                        {
                            Console.WriteLine($"Area rectangle is {rec1.Area()}");
                        }
                        else
                        {
                            Console.WriteLine("\aError");
                        }
                        return;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\t***Figura***");
                        Console.Write("Enter radius of the Circle: ");
                        float radius = Convert.ToSingle(Console.ReadLine());
                        Circle cir1 = new Circle(radius);

                        Console.Clear();
                        Console.WriteLine("1.length circle");
                        Console.WriteLine("2.Area circle");
                        Console.Write("Enter number: ");
                        int k= Convert.ToInt32(Console.ReadLine());
                        if (k == 1)
                        {
                            Console.WriteLine($"Perimeter rectangle is {cir1.Perimeter()}");
                        }
                        else if (k == 2)
                        {
                            Console.WriteLine($"Area rectangle is {cir1.Area()}");
                        }
                        else
                        {
                            Console.WriteLine("\aError");
                        }
                        return;
                    default:
                        return;

                }
            }
        }
    }
}
