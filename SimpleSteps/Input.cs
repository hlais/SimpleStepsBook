using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class Input
    {
        public static void _Input()
        {
            Console.Title = "Input";

            Console.Write("What is your name mofo: ");
            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + name +"!");
            Console.ReadKey();
        }
    }
}
