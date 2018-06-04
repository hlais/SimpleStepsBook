using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class Run_TimeErros
    {
        public static void RunTimeErrors()
        {
            try
            {

                //right click snippet=> insert snippet => visual c# = >trycath 
            Console.WriteLine("Please Enter A number: ");
            double num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Now enter Another Number: ");
            double num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Total: " + (num1 + num2));

                //short cut for indent ctrl+k, ctrl+f


            }
            catch (Exception error)
            {
                error.GetType();

                Console.WriteLine("\n Maximum: " + Int16.MaxValue);
            }

            //can add multiple catch blocks
            //catch (Exception error)
            //{
            //    error.GetType();

            //    Console.WriteLine("\n Maximum: " + Int16.MaxValue);
            //}

        }
    }
}
