using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SimpleSteps
{
    class WritingFile
    {
        public static void WriteText()
        {

            Console.Title = "Write Text";

            string path = "C:\\Users\\Isolated Gamerz\\AppData\\poem.text";
            string poem = "\r\n\t never saw a man who looked \r\n\t With such a wistful eye";
            poem += "\r\t Upon that little tent of blue";
            poem += "\n\t Which prisoners call the call";

            //file must include path
            if (File.Exists(path))
            {
                Console.WriteLine("File Already Exists with path" + path);
            }
            else
            {
                try
                {
                    //this overrides file and doesnt give warning!!
                    File.WriteAllText(path, poem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            Console.ReadKey();
        }

    }
}
 