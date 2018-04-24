using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class JoingAndComparing
    {
        public static void Joined()
        {
            Console.Title = "Joined";

            string[] a = new string[3] { "Alpha", "Bravo", "Charlie" };

            string s = string.Concat(a[0], a[1]);
            Console.WriteLine("Concatenated:\t" + s);

            s = string.Join(" ", a[0], a[1]);
            Console.WriteLine("Joined:\t\t" + s);

            s = string.Join("<br>", a);
            Console.WriteLine("HTML:\t" + s + "\n");

            s = string.Join(" ", a);
            Console.WriteLine("This test:" + s);

            //comparing in turn all three array elements in alphetic order
            int num = string.Compare(a[0], a[1]);
            Console.WriteLine(a[0] + " v " + a[1] + "\n" + num);

            num = string.Compare(a[2], a[1]);
            Console.WriteLine(a[2] + " v " + a[1] + "\t" + num);

            num = a[1].CompareTo(a[1]);
            Console.WriteLine(a[1] + " v " + a[1] + "\t" + num + "\n");

            bool flag = (a[1] == a[0]);
            Console.WriteLine(a[1] + "==" +a[0] + "\t\t" + flag );

            flag = a[2].Equals(a[2]);
            Console.WriteLine(a[2] + "==" + a[2] + "\t\t" + flag);
            Console.ReadKey();
                
                
;            
        }
    }
}
