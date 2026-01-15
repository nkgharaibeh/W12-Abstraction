using System;

namespace AbstractExample3
{
    abstract class Animal
    {
        // Abstract class CAN have constructors
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            Console.ReadLine();
        }
    }
}
// - Abstract class constructors are executed FIRST
// - Even though we cannot create object of abstract class
// - Constructor is used to initialize common state
