using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class Arrays
    {
        public static void _Arrays()
        {
            Console.Title = "Hip Hop Arrays ";

            string[] cars = new string[3] {"BMW", "NISSIAN", "OPEL" };

            int[,] coords = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("Second Car: \t" + cars[1]);
            Console.WriteLine("X1, Y1: \t" + coords[0,0]);
            Console.WriteLine("X2, Y3: \t" + coords[1,2]);
            Console.ReadKey();
                
        }
    }
}
