using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class ForEach
    {
        public static void WebSites()
        {
            string[] websites = new string[5] { "Google", "YouTube", "Facebook", "Baidu", "Yashoo!" };

            Console.WriteLine("Popular Websites ...");

            int rank = 1;
            foreach (string site in websites)
            {
                Console.WriteLine("Position " + rank + "\t" + site);
                rank++;
            }
            Console.ReadKey();
        }
    }
}

