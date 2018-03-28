using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class CreatingFunction
    {
        public static void bodyTemp()
        {
            Console.Title = "Functions";
            Console.WriteLine("Body Temp...");
            Console.WriteLine("Centrigrade:\t 37c" );
        }
        public static double bodyTempF()
        {
            double temp = 98.5;
            return temp;
        }
        public static int bodyTempK()
        {
            int temp = 310;
            return temp;
        }
    }
}
