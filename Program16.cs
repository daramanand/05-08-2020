using System;

namespace Bizruntime
{
    internal class Program16
    {
#pragma warning disable IDE1006 // Naming Styles
        public static void main()
#pragma warning restore IDE1006 // Naming Styles
        {
            Program16 p = new Program16();
            p.EvenNumbers();
        }
        public void EvenNumbers()
        {
            int Start = 0;

            while (Start <= 20)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }
    }
}



