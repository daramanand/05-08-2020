using System;

namespace Bizruntime
{
    internal class Method3
    {
#pragma warning disable IDE1006 // Naming Styles
        private static void run1()
#pragma warning restore IDE1006 // Naming Styles
        {
            Console.WriteLine("running1");
        }

#pragma warning disable IDE1006 // Naming Styles
        private static void run2()
#pragma warning restore IDE1006 // Naming Styles
        {
            Console.WriteLine("running2....");
        }

#pragma warning disable IDE1006 // Naming Styles
        private static void run3()
#pragma warning restore IDE1006 // Naming Styles
        {
            Console.WriteLine("running3....");
        }

#pragma warning disable IDE1006 // Naming Styles
        private static void run()
#pragma warning restore IDE1006 // Naming Styles
        {
            Console.WriteLine("running");
        }

        private static void Main(string[] args)
        {
            run();
            run2();
            run1();
        }

    }
}
