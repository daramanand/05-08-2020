using System;

namespace Bizruntime
{
    internal class Class1
    {
        // Class members
        private string color = "red";        // field
        private int maxSpeed = 200;          // field
#pragma warning disable IDE1006 // Naming Styles
        public void fullThrottle()   // method
#pragma warning restore IDE1006 // Naming Styles
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
#pragma warning disable IDE1006 // Naming Styles
        public static void main()
#pragma warning restore IDE1006 // Naming Styles
        {
            Class1 myTest1 = new Class1();
            Class1 myTest2 = new Class1();
            Console.WriteLine(myTest1.color);
            Console.WriteLine(myTest2.maxSpeed);

        }
    }

}

