using System;

namespace Bizruntime
{
    internal class Obj2
    {
        private string color = "red";

        private static void Main(string[] args)
        {
            Obj2 myObj1 = new Obj2();
            Obj2 myObj2 = new Obj2();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
        }
    }
}
