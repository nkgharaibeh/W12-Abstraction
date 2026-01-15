using System;

namespace AbstractExample1
{
    // Abstract base class
    abstract class BaseClass
    {
        public int num = 5;

        // Abstract method has NO body
        // Child class MUST implement it
        public abstract void Sum();
    }

    // Derived class
    class ChildClass : BaseClass
    {
        // override is mandatory here
        public override void Sum()
        {
            Console.WriteLine("Total Sum: " + num * num);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Cannot create object of abstract class
            // BaseClass obj = new BaseClass(); ❌

            ChildClass ch = new ChildClass();
            ch.Sum();

            Console.ReadKey();
        }
    }
}

// - Abstract methods do not have implementation
// - Any non-abstract child class MUST override abstract methods
// - Abstract class cannot be instantiated


