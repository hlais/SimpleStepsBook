using System;

namespace SimpleSteps
{
    class Program
    {
        static void Main(string[] args)
        {

            CreatingFunction.bodyTemp();
            Console.WriteLine("Fahrinathit: + " + CreatingFunction.bodyTempF());
            Console.WriteLine("Kelvin: " + CreatingFunction.bodyTempK());


            Console.ReadLine();
        }
    }
}
