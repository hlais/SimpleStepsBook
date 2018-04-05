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
        }
        static string getWeight(out double theWeight)
        {
            theWeight = 10;
            return "Ten";
        }
        static double LbToKg(double pounds = 5)
        {
            return (pounds * 0.4535);
        }
        static void kgToLb(ref double weight)
        {
            weight = (weight / 0.4535);
        }
    }
}
