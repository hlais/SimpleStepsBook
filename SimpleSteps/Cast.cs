using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class Cast
    {
        public static void _Cast()
        {
            double num = 10.5;
            int interger = 2;

            num = num + interger;
            Console.WriteLine("Implicit cast v1 \t" + num);
            //interger = interger + (int)num;
            //Console.WriteLine("Explicit cast int \t" + interger);

            num = (double)7 / interger;
            Console.WriteLine("Explicit Cast \t" + num);

            char letter = (char)65;
            Console.WriteLine("Cast integer \t" + letter);
            int ascii = (int) 'g';
            Console.WriteLine("Cast Letter: \t" +ascii);

            Console.WriteLine(num.GetType());
        }
    }
}
