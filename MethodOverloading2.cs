using System;

namespace Bizruntime
{
    internal class MethodOverloading2
    {
        private static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        private static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        private static void Main(string[] args)
        {
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }
}

