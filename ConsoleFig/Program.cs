using ConsoleFig.Shapes;
using System;
using System.Collections.Generic;

namespace ConsoleFig
{   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t***Figura***");
            List<Circle> circles = new List<Circle>();
            List<Rectangle> rectangles = new List<Rectangle>();
            while (true)
            {
                Console.WriteLine("1. Add shape");
                Console.WriteLine("2. View shapes");
                Console.WriteLine("3. Remove shape");
                Console.WriteLine("4. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                if(choice == 1)
                {
                    Console.Clear();
                    while (true)
                    {
                        
                        Console.WriteLine("1. Add Circle");
                        Console.WriteLine("2. Add Rectangle");
                        Console.WriteLine("3. Exit");
                        int number = Convert.ToInt32(Console.ReadLine());

                        if (number == 1) 
                        {
                            Console.Clear();
                            Console.Write("Enter radius circle: ");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            circles.Add(new Circle(radius));
                            continue;

                        }  //add circle 
                        else if (number == 2) 
                        {
                            Console.Clear();
                            Console.Write("Enter width rectangle: ");
                            double width = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter height rectangle: ");
                            double height = Convert.ToDouble(Console.ReadLine());
                            rectangles.Add(new Rectangle(width, height));
                            continue;
                        } // add rectangle
                        else if (number == 3) { break; } //exit

                        else // error
                        {
                            Error(1, 3);
                            continue;
                        }
                    }
                } // Add shape

                else if(choice == 2)
                {
                    Console.Clear();
                    int i = 1;
                    foreach(Circle c in circles)
                    {
                        Console.WriteLine($"Circle {i} area: {c.Area()} lenght: {c.Perimeter()}" );
                        i++;
                    }
                    i = 1;
                    foreach(Rectangle r in rectangles)
                    {
                        Console.WriteLine($"Rectangle {r} area: {r.Area()} Perimeter: {r.Perimeter()}");
                        i++;
                    }                                        
                } // View shapes

                else if(choice == 3)
                {                    
                    Console.WriteLine("1. Circle");
                    Console.WriteLine("2. Rectangle");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("Enter number shape what you want delete: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number == 1)
                    {
                        for (int i = 0; i < circles.Count; i++) 
                        {
                            Console.WriteLine($"Circle {i+1} area: {circles[i].Area()} lenght: {circles[i].Perimeter()}");
                        }
                        Console.WriteLine("Enter number circle what you want delete: " );
                        int num = Convert.ToInt32(Console.ReadLine());
                        circles.RemoveAt(num-1);
                    }
                    else if (number == 2)
                    {
                        for (int i = 0; i < rectangles.Count; i++)
                        {
                            Console.WriteLine($"Rectangle {i+1} area: {circles[i].Area()} Perimeter: {circles[i].Perimeter()}");
                        }
                        Console.WriteLine("Enter number rectangle what you want delete: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        rectangles.RemoveAt(num-1);
                    }
                    else if(number == 3)
                    {
                        continue;
                    }
                    else
                    {
                        Error(1, 3);
                    }
                } // Remove shapes

                else if(choice == 4)
                {
                    return;
                } // Exit

                else
                {
                    Error(1, 4);
                    continue;
                } // Error
            }

            void Error(int from, int to)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"\a Error: enter number form {from} to {to}");
                Console.ResetColor();
            }
        }
    }
}
