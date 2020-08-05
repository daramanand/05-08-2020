using System;

namespace Bizruntime
{
    internal class MethodOverloading1
    {
        private static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        private static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }

        private static void Main(string[] args)
        {
            int myNum1 = PlusMethodInt(8, 5);
            double myNum2 = PlusMethodDouble(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }
}

