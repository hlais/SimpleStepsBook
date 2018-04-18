using System;

namespace SimpleSteps
{
    class Program
    {
        static void Main(string[] args)
        {


            Refactoring_code.computeFactorials(1, 8);




            Console.ReadLine();
        }

        private static void AddNumber(int first, AClass second)
        {
            second.Avalue = first;

           
        }


    }
    public class AClass
    {
        public int Avalue { get; set; }
    }
}
