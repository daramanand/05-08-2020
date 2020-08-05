using System;

namespace Bizruntime
{
    internal class Class2
    {
        private string color = "blue";
        private int maxSpeed = 150;

        private static void Main(string[] args)
        {
            Class2 myObj = new Class2();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
        }
    }
}
