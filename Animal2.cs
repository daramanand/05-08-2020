using System;

namespace Bizruntime
{
    internal class Animal2
    {
        private class Animal  // Base class (parent) 
        {
#pragma warning disable IDE1006 // Naming Styles
            public void animalSound()
#pragma warning restore IDE1006 // Naming Styles
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        private class Pig : Animal2  // Derived class (child) 
        {
#pragma warning disable IDE1006 // Naming Styles
            public void animalSound()
#pragma warning restore IDE1006 // Naming Styles
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        private class Dog : Animal2  // Derived class (child) 
        {
#pragma warning disable IDE1006 // Naming Styles
            public void animalSound()
#pragma warning restore IDE1006 // Naming Styles
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }

        private class Aanimal3
        {
            private static void Main(string[] args)
            {
                Animal2 myAnimal = new Animal2();  // Create a Animal object
                Animal2 myPig = new Pig();  // Create a Pig object
                Animal2 myDog = new Dog();  // Create a Dog object

                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void animalSound()
#pragma warning restore IDE1006 // Naming Styles
        {
            throw new NotImplementedException();
        }
    }
}
