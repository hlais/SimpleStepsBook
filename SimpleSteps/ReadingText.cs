using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SimpleSteps
{
    class ReadingText
    {
        public static void ReadText()
        {
            Console.Title = "Read Text";
            string path = "C:\\Users\\Isolated Gamerz\\AppData\\word.txt";

            if (File.Exists(path))
            {
                //step 5 - try catch
                try
                {
                    // text file contents to variable

                    string text = File.ReadAllText(path);
                    Console.WriteLine("File Read: " + path + "\n");
                    Console.WriteLine(text + "\n");

                    // statements to assign the text file contents 
                    string[] lines = File.ReadAllLines(path);
                    int num = 1;
                    foreach (string line in lines)
                    {
                        Console.WriteLine(num + " : " + line);
                        num++;
                    }
                    //now opening a text doc and writing stuff.


                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }

            }
            else
            {
                Console.WriteLine("File Not Found: " + path);
            }
         

        }
    }
}
