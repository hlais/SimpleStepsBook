using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class Refactoring_code
    {
        public static void Refactor()
        {
            Console.Title = "Refactor";
            

        }
        public static int factorial(int num)
        {
            int result;
            if (num == 1)
            {
                result = 1;
            }
            else
            {
                result = (factorial(num - 1) * num);
            }
            return result;
        }
        public static void computeFactorials(int num, int max)
        {
            while (num <= max)
            {
                Console.WriteLine("Factorial of " + num + ": " + (factorial(num)));
                num++;
            }
        }
    }
}
