using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class PassingArguments
    {
        public static void Parameter()
        {

            Console.Title = "Parameter";

            double weight;
            string num;

            num = getWeight(out weight);
            Console.WriteLine(num + " lb = " + lbToKg(weight) + " kg");
            kgToLb(ref weight);
            Console.WriteLine(num + " kg = " + weight + " lb");
            Console.ReadKey();
        }

        static string getWeight(out double theWeight)
        {
            theWeight = 10;
            return "Ten";
        }

        static double lbToKg(double pounds = 5)
        {
            return (pounds * 0.45359237);
        }

        static void kgToLb(ref double weight)
        {
            weight = (weight / 0.45359237);
        }
    }
}

