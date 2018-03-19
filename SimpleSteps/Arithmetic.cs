using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class Arithmetic
    {
        public static void _Arithemtic()
        {
            Console.Title = "Arithemtic";
            int a = 8;
            int b = 4;
            Console.WriteLine(" a:\t:" + a);
            Console.WriteLine(" b:\t:" + b);

            Console.WriteLine("Addition:\t:" + (a+b));
            Console.WriteLine("Subtraction:\t:" + (a-b));
            Console.WriteLine("Multiplication:\t:" + (a*b));
            Console.WriteLine("Division:\t:" + (a/b));
            Console.WriteLine("Modulus:\t:" + (a%b));

            //trying out post fix 
            //postfix operators changes values subsequently 
            Console.WriteLine("\nPostfix:\t:" + (a++));
            Console.WriteLine("Postfix Result...:\t:" + a);

            //trying out preFix
            // changes are applied immeditatly 
            Console.WriteLine("\nPrefix:\t:" + (++b));
            Console.WriteLine("Prefix Result...:\t:" +b);
            Console.ReadKey();

        }
    }
}
