using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class Constant
    {
        //enums are a list of constant names;
        enum Days {Sat, Sun, Mon, Tue, Wen, Thu, Fri };

        public static void _Constants()
        {
            const double pi = 3.14325343;
            //enum methods require data type of list. ***
            //requiring the datta type
            var daysType = typeof(Days);
            

            Console.WriteLine("Pi Type: " + pi.GetType());
            Console.WriteLine("Circumference: " + (pi*3));

            Console.WriteLine("\nFirst Name: " + Days.Sat);
            Console.WriteLine("1st index: " + (int)Days.Sat);

            //using Enum method ***
            string name = Enum.GetName(daysType, 1);

            //to check list at index off. 
            Console.WriteLine("\n2nd Index: " + name);
            //using Enum method *** 
            //to check if list contains "Mon".
            bool flag = Enum.IsDefined(daysType, "Mon");
            Console.WriteLine("Contains Mon?: " + flag);
            Console.ReadKey();

        }
    }
}
