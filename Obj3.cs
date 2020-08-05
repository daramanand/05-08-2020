using System;

namespace Bizruntime
{
    internal class Obj3
    {
        private String color = "blue";

#pragma warning disable IDE1006 // Naming Styles
        private static void main(string[] args)
#pragma warning restore IDE1006 // Naming Styles
        {
            Obj3 myObj5 = new Obj3();

            Console.WriteLine(myObj5.color);

        }
    }
}
