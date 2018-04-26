using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class FormatStrings
    {
        public static void Format()
        {
            Console.Title = "Format";

            int sum = 6900;
            //"C" will convert string lit to currency 
            Console.WriteLine("Currency String " + sum.ToString("C"));

            Console.WriteLine(string.Format("\nGeneral:\t {0:G}", sum));
            Console.WriteLine(string.Format("\nFixed Point:\t {0:F}",sum));
            Console.WriteLine(string.Format("\nFixed Number:\t {0:n}", sum));
            Console.WriteLine(string.Format("\nFixed Currency:\t {0:c}", sum));

            sum /= 1000;
            Console.WriteLine(string.Format("\nPercentenage: \t {0:P}",sum));
            //padded zeros
            Console.WriteLine(string.Format("\nZero Padded: \t {0:00.0000}", sum));

            string data = "Mike,Iso,TheGreatest";
            string[] items = data.Split(',');

            foreach (var item in items)
            {
                Console.WriteLine(string.Format("\n*{0} ", item));
            }
        

        }
    }
}
