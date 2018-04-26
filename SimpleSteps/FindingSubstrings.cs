using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class FindingSubstrings
    {
        public static void Substrings()
        {
            Console.Title = "Substring";

            string text = "My dog is a cute dog";
            Console.WriteLine(text + "\tLength: " + text.Length);

            Console.WriteLine("\nPlease Enter a substring to Seek: ");
            string sub = Console.ReadLine();

            //creating a character array and copy substring
            char[] arr = new char[sub.Length];
            sub.CopyTo(0, arr, 0, sub.Length);

            //IndexOf -left to right- seeks first occurance of substring 
            int pos = text.IndexOf(sub);
            report(pos, sub);

            //LastIndexOf - right to left- seek last occurence of substring, still using first letter of substring
            pos = text.LastIndexOf(sub);
            report(pos, sub);

            //seek first occurence of any character substring
            pos = text.IndexOfAny(arr);
            report(pos, text.Substring(pos, 1));

            //seek last occurance of any character of the substring
            pos = text.LastIndexOfAny(arr);
            report(pos, text.Substring(pos, 1));



        }
       static void report(int pos, string sub)
        { 
            if (pos != -1)
            {
                Console.WriteLine("'" + sub + "'Found at " + pos);
            }
            else
            {
                Console.WriteLine("'" + sub + "'Not Found!");
            }
        }
    }
}
