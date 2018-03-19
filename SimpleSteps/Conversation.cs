using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class Conversation
    {
        public static void _Conversion()
        {
            Console.Title = "Conversion Application";
            Console.Write("Please enter a number :");

            double num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Now enter another number");
            double sum =  Convert.ToDouble(Console.ReadLine()) + num;
            Console.WriteLine("Total = " + sum);
            Console.ReadKey();
        }
    }
}
