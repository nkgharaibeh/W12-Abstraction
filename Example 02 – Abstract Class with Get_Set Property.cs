using System;

namespace AbstractExample2
{
    abstract class Animal
    {
        // Protected field: accessible in child class
        protected string name;

        // Abstract property (no implementation)
        public abstract string Name { get; set; }
    }

    class Dog : Animal
    {
        // Implement abstract property
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.Name = "Tom";

            Console.WriteLine("Name: " + obj.Name);
            Console.ReadLine();
        }
    }
}
// - Abstract classes can contain abstract properties
// - Child class MUST override both get and set
// - Abstraction + Encapsulation work together here
