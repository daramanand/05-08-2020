using System;

namespace Bizruntime
{
    internal class Obj7
    {
        private double a = 1.2;
        private double b = 2.2;
        private double c = 34.2;
        private double d = 4.5;
        private double e = 5.6;
#pragma warning disable IDE1006 // Naming Styles
        public static void main()
#pragma warning restore IDE1006 // Naming Styles
        {
            Obj7 myData1 = new Obj7();
            Obj7 myData2 = new Obj7();
            Obj7 myData3 = new Obj7();
            Obj7 myData4 = new Obj7();
            Obj7 myData5 = new Obj7();

            Console.WriteLine(myData1.a);
            Console.WriteLine(myData2.b);
            Console.WriteLine(myData3.c);
            Console.WriteLine(myData4.d);
            Console.WriteLine(myData5.e);
        }
    }
}
