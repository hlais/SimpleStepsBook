using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class Setting_Precedence
    {
        public static void Precedence()
        {
            Console.Title = "Precedence";
            int sum;

            sum = 1 + 4 * 3;
            Console.Write("Default Order:\t\t" + sum);

            sum = (1 + 4) * 3;
            Console.Write("Forced Oderd: \t\t" + sum);

            sum = 7-4 + 2;
            Console.Write("\nDefault Direction:\t" + sum);

            sum = 7 - (4 + 2);
            Console.Write("\nForced Direction: \t" + sum);
        }
    }
}
