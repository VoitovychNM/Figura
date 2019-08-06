using System;
using ConsoleFig.Shapes;

namespace ConsoleFig
{
    internal class ArrayList<T>
    {
        public ArrayList()
        {
        }

        public static implicit operator ArrayList<T>(ArrayList<Circle> v)
        {
            throw new NotImplementedException();
        }
    }
}