using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFig.Shapes
{
    class Circle : Shape
    {
        double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }
        public override double Perimeter()
        {
            return 2 * 3.14 * Radius;
        }
    }
}
