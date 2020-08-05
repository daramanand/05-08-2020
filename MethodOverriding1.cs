using System;

namespace Bizruntime
{
    internal class MethodOverriding1
    {
        public virtual void Greetings()
        {
            Console.WriteLine("baseClass Saying Hello!");
        }
    }

#pragma warning disable IDE1006 // Naming Styles
    internal class subClass : MethodOverriding1
#pragma warning restore IDE1006 // Naming Styles
    {
        public override void Greetings()
        {
            base.Greetings();
            Console.WriteLine("subClass Saying Hello!");
        }
    }

    internal class MethodOverloding1
    {
        private static void Main(string[] args)
        {
            MethodOverriding1 obj1 = new subClass();
            obj1.Greetings();
            _ = Console.ReadLine();
        }
    }
}

