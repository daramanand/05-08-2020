using System;

namespace Bizruntime
{
    public class Animal1
    {
#pragma warning disable IDE1006 // Naming Styles
        public void eat() { Console.WriteLine("Eating..."); }
#pragma warning restore IDE1006 // Naming Styles
    }
    public class Dog1 : Animal1
    {
#pragma warning disable IDE1006 // Naming Styles
        public void bark() { Console.WriteLine("Barking..."); }
#pragma warning restore IDE1006 // Naming Styles
    }
    public class BabyDog : Dog1
    {
#pragma warning disable IDE1006 // Naming Styles
        public void weep() { Console.WriteLine("Weeping..."); }
#pragma warning restore IDE1006 // Naming Styles
    }

    internal class TestInheritance3
    {
        public static void Main(string[] args)
        {
            BabyDog d1 = new BabyDog();
            d1.eat();
            d1.bark();
            d1.weep();
        }
    }

}