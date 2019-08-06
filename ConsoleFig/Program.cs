using ConsoleFig.Shapes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleFig
{   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t***Figura***");
            ArrayList shape = new ArrayList();
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
                            shape.Add(new Circle(radius));
                            continue;

                        }  //add circle 
                        else if (number == 2) 
                        {
                            Console.Clear();
                            Console.Write("Enter width rectangle: ");
                            double width = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter height rectangle: ");
                            double height = Convert.ToDouble(Console.ReadLine());
                            shape.Add(new Rectangle(width, height));
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
                    foreach(Shape s in shape)
                    {
                        Console.WriteLine($"Circle {i} area: {s.Area()} lenght: {s.Perimeter()}" );
                        i++;
                    }                                                      
                } // View shapes

                else if(choice == 3)
                {
                    Console.Clear();
                    
                    
                    int i = 1;
                    foreach (Shape s in shape)
                    {
                        Console.WriteLine($"Circle {i} area: {s.Area()} lenght: {s.Perimeter()}");
                        i++;
                    }
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("Enter number shape what you want delete or 0 for exit : " );
                    int number = Convert.ToInt32(Console.ReadLine());
                    if(number == 0)
                    {
                        continue;
                    }
                    shape.RemoveAt(number-1);                   
                 
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
