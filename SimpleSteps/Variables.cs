using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class Variables
    {
        public static void _Variable()
        {
            Console.Title = "Variables";

            char letter; letter = 'A';
            int number; number = 100;
            float body; body = 98.4f;
            double pi; pi = 3.14;
            decimal sum = 100.00m;
            bool flag = false;
            string text = "C# is fun!!";

            Console.WriteLine("char letter: \t" + letter);
            Console.WriteLine("int letter: \t" + number);
            Console.WriteLine("float body: \t" + body);
            Console.WriteLine("double pi: \t" + pi);
            Console.WriteLine("decimal sum: \t" + sum);
            Console.WriteLine("bool flag: \t" + flag);
            Console.WriteLine("Text letter: \t" + text);

            Console.ReadKey();

        }
    }
}
