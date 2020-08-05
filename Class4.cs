using System;

namespace Bizruntime
{
    internal class Class4
    {
        private string model;
        private string color;
        private int year;
        private string brand;

        private static void Main(string[] args)
        {
            Class4 Ford = new Class4();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Class4 Opel = new Class4();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Class4 tte = new Class4();
            tte.brand = "Volvo";
            tte.brand = "bmw";
            tte.brand = "honda";

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            Console.WriteLine(tte.brand);
        }
    }
}
