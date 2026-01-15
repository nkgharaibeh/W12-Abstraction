using System;

namespace AbstractExample4
{
    abstract class MotorBike
    {
        // Abstract method
        public abstract void Brake();
    }

    class SportsBike : MotorBike
    {
        public override void Brake()
        {
            Console.WriteLine("Sports Bike Brake");
        }
    }

    class MountainBike : MotorBike
    {
        public override void Brake()
        {
            Console.WriteLine("Mountain Bike Brake");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SportsBike s1 = new SportsBike();
            s1.Brake();

            MountainBike m1 = new MountainBike();
            m1.Brake();

            Console.ReadLine();
        }
    }
}
// - Same abstract method, different implementations
// - This is a clear example of abstraction + polymorphism
// - User does not care HOW brake works, only THAT it works
