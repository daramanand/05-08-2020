using System;

namespace Bizruntime
{
    internal class Obj8
    {
        private string Name1 = "raju";
        private string Name2 = "anand";
        private string Name3 = "john";
        private string Name4 = "mark";
        private string Name5 = "luke";
#pragma warning disable IDE1006 // Naming Styles
        public static void main()
#pragma warning restore IDE1006 // Naming Styles
        {
            Obj8 myData1 = new Obj8();
            Obj8 myData2 = new Obj8();
            Obj8 myData3 = new Obj8();
            Obj8 myData4 = new Obj8();
            Obj8 myData5 = new Obj8();

            Console.WriteLine(myData1.Name1);
            Console.WriteLine(myData2.Name2);
            Console.WriteLine(myData3.Name3);
            Console.WriteLine(myData4.Name4);
            Console.WriteLine(myData5.Name5);
        }
    }
}

