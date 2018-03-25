using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class AssessingLogic
    {
        public static void Logic()
        {
            Console.Title = "Logic";

            bool yes = true, no = false;

            Console.Write("AND Logic:");
            Console.Write("\t (yes && yes) : " + (yes && yes));
            Console.Write("\n\t\t (yes && no ) : " + (yes && no));
            Console.Write("\n\t\t (no  && no ) : " + (no && no));

            Console.Write("\n\nOR Logic:");
            Console.Write("\t (yes || yes) : " + (yes || yes));
            Console.Write("\n\t\t (yes || no ) : " + (yes || no));
            Console.Write("\n\t\t (no  || no ) : " + (no || no));

            Console.Write("\n\nNOT Logic:");
            Console.Write("\t yes = " + yes);
            Console.Write("\t !yes = " + !yes);
            Console.Write("\n\t\t no  = " + no);
            Console.Write("\t !no  = " + !no);

            Console.WriteLine("\n Yes = !yes" + (yes = !yes));

            Console.WriteLine("\n Yes: " + yes);
            Console.ReadKey();
        }
    }
}
