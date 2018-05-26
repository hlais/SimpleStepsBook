using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace SimpleSteps
{
    class ReadStream
    {
        public static void ReadingStream()
        {
            Console.Title = "Read Stream";

            string path = "C:\\Users\\Isolated Gamerz\\AppData\\TopFive.txt";

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains("Rank"))
                        {
                           line = line.ToUpper();
                        }
                        if (line.Contains("Sia"))
                        {
                            line += " ft.Sean Paul";
                        }

                        string[] sub = line.Split(',');
                        line = string.Format("{0,-30}{1,-30}", sub[1], sub[2]);
                        Console.WriteLine(line);
                    }
                }

            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }
            Console.ReadKey();

        }
    }
}
