using System;

namespace Bizruntime
{
    internal class MethodOverriding2
    {
        public virtual void Greetings()
        {
            Console.WriteLine("baseClass Saying Hello!");
        }
    }

    internal class M
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

#pragma warning disable IDE1006 // Naming Styles
        private class l
#pragma warning restore IDE1006 // Naming Styles
        {
            private static void Main(string[] args)
            {
                MethodOverriding2 obj1 = new MethodOverriding2();
                obj1.Greetings();
                _ = Console.ReadLine();
            }
        }
    }
}
