using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class IteratingForEach
    {
        public static void KeyValue()
        {
            Console.Title = "KeyValue";

            Dictionary<string, string> GamesList = new Dictionary<string, string>();
            GamesList.Add("Nintendo", "Mario");
            GamesList.Add("Sega", "Sonic the hoog");
            GamesList.Add("Microsoft", "Master Cheif");
            //GamesList.Add("Nintendo", "UnderWear");

            Console.WriteLine("Popular Games... ");

            foreach (KeyValuePair <string,string> game in GamesList)
            {
                Console.WriteLine("Key +" + game.Key + "\tValue: " + game.Value + "in easy steps");
            }
            Console.ReadKey();
        }
    }
}
