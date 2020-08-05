using System;

namespace Bizruntime
{
    public class Animal
    {
#pragma warning disable IDE1006 // Naming Styles
        public void eat() { Console.WriteLine("Eating..."); }
#pragma warning restore IDE1006 // Naming Styles
    }
    public class Dog : Animal
    {
#pragma warning disable IDE1006 // Naming Styles
        public void bark() { Console.WriteLine("Barking..."); }
#pragma warning restore IDE1006 // Naming Styles
    }

    internal class TestInheritance2
    {
        public static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.eat();
            d1.bark();
        }
    }

}