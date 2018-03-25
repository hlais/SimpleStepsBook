using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class Examining_Conditions
    {
        public static void Condition()
        {
            Console.Title = "Condition";

            int a = 8;
            int b = 3;

            string verb = (a != 1) ? "are" : "is :";
            Console.Write("There" + verb + a + "\n");


            string parity = (a % 2 != 0) ? "Odd" : "Even";
            Console.WriteLine(a + " is " + parity);

            parity = (b % 2 != 0) ? "Odd" : "Even";
            Console.WriteLine(b + " is " + parity);

            //we can use tenarys to assign valuese
            int max = (a > b) ? a : b;
            Console.WriteLine("\nMaxium is " + max);
            
            // test
            //int age = (8 / 3 == 2) ? 6 : 5;
            //Console.WriteLine("\nAge is " + age);

            Console.ReadKey();
        }
    }
}
