using System;

namespace Bizruntime
{
     class Method2
    {
        private static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        private static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
        }

    }
}
