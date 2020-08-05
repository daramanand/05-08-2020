using System;

namespace Bizruntime
{
    internal class Obj5
    {
        private int a = 1;
        private int b = 2;
        private int c = 3;
        private int d = 4;
        private int e = 5;
#pragma warning disable IDE1006 // Naming Styles
        public static void main()
#pragma warning restore IDE1006 // Naming Styles
        {
            Obj5 myData1 = new Obj5();
            Obj5 myData2 = new Obj5();
            Obj5 myData3 = new Obj5();
            Obj5 myData4 = new Obj5();
            Obj5 myData5 = new Obj5();

            Console.WriteLine(myData1.a);
            Console.WriteLine(myData2.b);
            Console.WriteLine(myData3.c);
            Console.WriteLine(myData4.d);
            Console.WriteLine(myData5.e);
        }
    }
}
