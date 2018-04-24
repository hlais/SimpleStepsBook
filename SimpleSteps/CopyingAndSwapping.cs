using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class CopyingAndSwapping
    {
        public static void Copied()
        {
            Console.Title = "Copied";

            string car1 = "Ghibli";
            string car2 = "GranTurismo";

            Console.Write("Original: ");
            Console.WriteLine("\tCar 1: " + car1 + "\t\tCar 2: " + car2);

            car1 = String.Copy(car2);
            Console.Write("\nCopied: ");
            Console.WriteLine("\tCar 1: " + car1 + "\tCar 2: " + car2);

            int num = car1.Length;
            char[] model = new char[num];

            //copying to an array 
            car1.CopyTo(0, model, 0, num);
            //char[] model = car1.ToCharArray();
            Console.Write("\nCharacter Array: ");
            foreach (char c in model) { Console.Write(c + " "); }

            car1 = car1.Remove(4);
            Console.WriteLine("\n\nRemoved...\tCar 1: " + car1);

            car1 = car1.Insert(0, "Maserati ");
            car1 = car1.Insert(13, "Cabrio");
            Console.WriteLine("\nInserted...\tCar 1: " + car1);

            car1 = car1.Replace("GranCabrio", "Quattroporte");
            Console.WriteLine("\nReplaced...\tCar 1: " + car1);
            Console.ReadKey();




        }
    }
}
