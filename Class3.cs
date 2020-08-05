using System;

namespace Bizruntime
{
    internal class Class3
    {
        private string color;
        private int maxSpeed;
        private int limit;

        private static void Main(string[] args)
        {
            Class3 myObj = new Class3();
            myObj.color = "red";
            myObj.maxSpeed = 200;
            myObj.limit = 150;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
            Console.WriteLine(myObj.limit);
        }
    }
}
