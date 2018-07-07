using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    public class Bird
    {
        public virtual void talk()
        {
            Console.WriteLine("A fucking Bird is talking!");
        }
        public virtual void fly() //to be overidded
        {
            Console.WriteLine("I'm A BIRD im flying I am!! \n");
        }
    }
    public class Pigeon : Bird
    {
        public override void talk()
        {
            Console.WriteLine("I am PIGEON, I am talking");
            
        }
        public override void fly()
        {
            Console.WriteLine("Pigeon fly dirty");
            base.fly(); // this calls the base class directly
        }
    }
    public class Chicken : Bird
    {
        public override void talk()
        {
            Console.WriteLine("Chicken says: CLUCK CLUK");
        }
        public override void fly()
        {
            Console.WriteLine("I am a chicken I cant fly! :(");
            base.fly();
        }
    }

    
}
