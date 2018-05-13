using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace SimpleSteps
{
    class WriteStream
    {
        public static void WrittingStream()
        {
            string path = "C:\\Users\\Isolated Gamerz\\AppData\\TuPac.txt";
            string[] tuPacLyrics = new string[] {
                    "\tI ain't got no motherfuckin friends",
                    "\tThat's why I fucked yo' bitch, you fat motherfucker",
                    "\t(Take money) West side, Bad Boy killers(take money)",
                    "\tYou know who the realest is niggaz we bring it to you(take money)"
            };

            string albumDetails = "Album Name: How Do U Want It, Released June 4, 1996";

            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (var line in tuPacLyrics)
                    {
                        writer.WriteLine(line);
                    }
                }

                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(albumDetails);
                    Console.WriteLine("File written: " + path);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
       }
    }
}
 