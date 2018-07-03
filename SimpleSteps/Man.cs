using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    public class Man
    {
        public void speak()
        {
            Console.WriteLine("Hello: ");
        }
        public void speak(string Message)
        {
            Console.WriteLine(Message + "!\n");
        }
    }
    //after base class add derived class
    public class Hombre : Man
    {
        public new void speak(string Message)
        {
            base.speak();
            Console.WriteLine(Message);
        }

    }
}
