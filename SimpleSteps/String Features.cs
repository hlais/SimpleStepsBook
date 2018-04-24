using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class String_Features
    {
        public static void Features()
        {
            Console.Title = "Features";
            Console.Write("Please Enter Text:");
            //test sample : my name Halim
            string text = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("\nERROR: No Text Found!");
            }
            else
            {
                Console.WriteLine("\nThanks.You Entered:\n'" + text+"'" );
                Console.WriteLine($"The length of text is {text.Length} ");

                string query = text.StartsWith('H') ? "Does" : "Does not";

                Console.WriteLine("Text " + query + " Starts with H");

                query = text.EndsWith("m") ? "Does" : "Does not";
                Console.WriteLine("Text " + query + " End With m");

                query = text.Contains("ali")? "Does" : " Does Not";
                Console.WriteLine("Text" + query + " contain ali");

                //extra randomtests
                query = text.Normalize();
                Console.WriteLine("normalize" + query);

                query = text.Replace("ali", "iso");
                Console.WriteLine("replace iso with ali = " + query);

                    
                
            }
            Console.ReadKey();
        }
    }
}
