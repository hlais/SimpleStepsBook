using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class FormatDateStrings
    {
        public static void TimeTicker()
        {
            Console.Title = "Date Format";

            DateTime now = DateTime.Now;
          
            Console.WriteLine("Current Date and Time : " + now);

            
            Console.WriteLine("\n Day Name: " + now.DayOfWeek);
            Console.WriteLine("\n Date Name: " + now.ToShortDateString());
            Console.WriteLine("\n Time Only: " + now.ToShortTimeString());

            now = now.AddYears(4);
            
            Console.WriteLine("Date in 4 years: " + now);

            DateTime dt = new DateTime(1985, 5, 28,8,15,59);
            
            Console.WriteLine("\n\n Set Date and Time : {0:f}", dt);

            // Save today's date.

            //working out my age 
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - dt.Year;
            if (dt > today.AddYears(-age)) age--;
            Console.WriteLine("halim age is " + age);


            //dddd =Day name  = tuesday
            Console.WriteLine("\n\nSet Day name: {0:dddd}", now);
            Console.WriteLine("\nLong Date {0:D}", now);
            Console.WriteLine("\nLong Time: {0:t}", now);
           
        }
    }
}
