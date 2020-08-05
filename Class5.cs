using System;

namespace Bizruntime
{
    internal class Class5
    {
        private string color;                 // field
        private int maxSpeed;                 // field
#pragma warning disable IDE1006 // Naming Styles
        public void fullThrottle()    // method
#pragma warning restore IDE1006 // Naming Styles
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
#pragma warning disable IDE1006 // Naming Styles
        public void test()
#pragma warning restore IDE1006 // Naming Styles
        {
            Console.WriteLine("aaaaa...");
        }

        private static void Main(string[] args)
        {
            Class5 myObj = new Class5();
            myObj.fullThrottle();  // Call the method
            myObj.test();

        }
    }
}
