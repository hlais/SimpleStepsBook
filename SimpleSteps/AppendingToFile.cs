using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SimpleSteps
{
    class AppendingToFile
    {
        public static void AppendText()
        {
            Console.Title = "Append Text";

            string path = "C:\\Users\\Isolated Gamerz\\AppData\\oscar.text";
            //string oldfile = "C:\\Users\\Isolated Gamerz\\AppData\\poem.text";
            string[] poem = new string[]
                {
                    "\tIn Debtors' Yard the stones are hard", "\tAnd the dripping wall is high"
                };

            string attrib = "\r\n\tThe Ballad Of Reading Gaol";
            attrib += "(Oscar Wilde 1898)";

            attrib = Console.ReadLine();    


            //deleting old file from previous chapter
            //if (File.Exists(oldfile))
            //{
            //    File.Delete(oldfile);
            //}
            ////end of

            if (File.Exists(path))
            {
                //AppendAllText adds extra lines +=
                File.AppendAllText(path, attrib);
                Console.WriteLine("Appended To Tile" + path);
            }
            else
            {
                try
                {
                    File.WriteAllLines(path, poem);
                    Console.WriteLine("File Written :" + path);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
