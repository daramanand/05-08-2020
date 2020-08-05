using System;

namespace Bizruntime
{
    internal class Vehicle
    {
        public string brand = "Ford";  // Vehicle field
#pragma warning disable IDE1006 // Naming Styles
        public void honk()             // Vehicle method 
#pragma warning restore IDE1006 // Naming Styles
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    internal class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }

    internal class Program1
    {
        private static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}
