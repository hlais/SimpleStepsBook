using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class AssigningValues
    {
        public static void Assign()
        {
            Console.Title = "Assign";

            int a;
            int b;

            Console.WriteLine("Assign Values");
            Console.WriteLine("\t a = " + (a=8));
            Console.WriteLine("\t a = " + (b = 4));

            Console.WriteLine("\n\nAdd and assign: ");
            Console.WriteLine("\t a+=b (8+=4) \t a= " + (a += b));

            Console.WriteLine("\n\nAdd and assign: ");
            Console.WriteLine("\t a+=b (12-=4) \t a= " + (a -= b));

            Console.WriteLine("\n\nAdd and assign: ");
            Console.WriteLine("\t a+=b (8*=4) \t a= " + (a *= b));

            Console.WriteLine("\n\nAdd and assign: ");
            Console.WriteLine("\t a+=b (32/=4) \t a= " + (a /= b));

            Console.WriteLine("\n\nAdd and assign: ");
            Console.WriteLine("\t a+=b (8%=4) \t a= " + (a %= b));

            Console.ReadKey();

        }
    }
}
