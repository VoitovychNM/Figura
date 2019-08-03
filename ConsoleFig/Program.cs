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
            Console.WriteLine("\t***Figura***");

            while (true)
            {             
                int number = MainMenu();

                switch (number)
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
                        while (true)
                        {
                            int n = read();
                            if (n == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Perimeter rectangle is {rec1.Perimeter()}");
                                Console.ResetColor();
                                break;
                            }
                            else if (n == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Area rectangle is {rec1.Area()}");
                                Console.ResetColor();
                                break;
                            }
                            else
                            {
                                Error();
                                continue;
                            }
                        }
                        return;


                    case 2:
                        Console.Clear();
                        Console.WriteLine("\t***Figura***");
                        Console.Write("Enter radius of the Circle: ");
                        float radius = Convert.ToSingle(Console.ReadLine());
                        Circle cir1 = new Circle(radius);

                        Console.Clear();                        
                        while (true)
                        {                            
                            int k = read();
                            if (k == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Perimeter rectangle is {cir1.Perimeter()}");
                                Console.ResetColor();
                                break;
                            }
                            else if (k == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Area rectangle is {cir1.Area()}");
                                Console.ResetColor();
                                break;
                            }
                            else
                            {
                                Error();
                                continue;
                            }
                        }
                        return;
                    default:
                        Error();
                        continue;

                }
            }
            int MainMenu()
            {
                Console.WriteLine("1.Rectangle");
                Console.WriteLine("2.Circle");
                Console.Write("\nEnter figure nubmer: ");
                return Convert.ToInt32(Console.ReadLine());
            }
           
            int read()
            {
                Console.WriteLine("1.Perimeter");
                Console.WriteLine("2.Area");
                Console.Write("Enter number: ");
                return Convert.ToInt32(Console.ReadLine());
            }
            void Error()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\aError: \"The number should be from 1 to 2\"");
                Console.ResetColor();
            }
        }
    }
}
