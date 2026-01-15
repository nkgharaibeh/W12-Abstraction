using System;

namespace AbstractExample5
{
    // Abstract base class
    abstract class Shape
    {
        public abstract int Area();
    }

    class Square : Shape
    {
        private int side;

        public Square(int x)
        {
            side = x;
        }

        public override int Area()
        {
            Console.Write("Area of Square: ");
            return side * side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Base reference, child object
            Shape sh = new Square(4);

            int result = sh.Area();
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
// - Abstract class reference can point to derived object
// - Implementation is decided at runtime
// - This prepares students for Interfaces in next lab
