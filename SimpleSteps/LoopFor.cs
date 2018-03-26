using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class LoopFor
    {
        public static void ForLoop()
        {
            Console.Title = "ForLoop";

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Loop iteration: " + i);
                for (int j = 1; j < 4; j++)
                {
                    Console.WriteLine("\tInner Loop Iteration: " + j);
                }

            }

        }
    }
}
