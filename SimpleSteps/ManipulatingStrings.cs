using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class ManipulatingStrings
    {
        public static void Manipulate()
        {
            Console.Title = "Manipulate";

            Console.WriteLine("Please enter Text");
            string text = Console.ReadLine();

            Console.WriteLine("Thanks you have entered" + text);
            Console.WriteLine("\t\t Text length " + text.Length);
            //removing trailing white spaces

            text = text.Trim();
            Console.WriteLine("\nTrimmed:\t" + text + "");
            Console.WriteLine("\n Text length after trim is +" + text.Length);

            string upper = text.ToUpper();
            Console.WriteLine("\nUpperCase:\t " + upper + "");

            string lower = text.ToLower();
            Console.WriteLine("LowerCase: \t" + lower + "");

            upper = upper.PadLeft(40);
            lower = lower.PadRight(40, '#');
            text = text.PadLeft(30, '*').PadRight(40, '*');

            Console.WriteLine("\nPadded Left: \t" + upper + "");
            Console.WriteLine("Padded Right:\t" + lower + "");
            Console.WriteLine("Padded Both: \t" + text + "");

            Console.WriteLine("Trimmed Start:\t" + upper.TrimStart() + "'");
            Console.WriteLine("Trimmed End: \t" + text.TrimEnd('*') + "");
            Console.ReadKey();

        }
    }
}
