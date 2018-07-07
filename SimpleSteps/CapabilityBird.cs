using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    public abstract class CapabilityBird
    {
        public abstract void talk();

        public abstract void fly();

    }
    public sealed class CabilityPigeon : CapabilityBird // sealed prevents class being used a base class
    {
        public override void talk()
        {
            Console.WriteLine("Cability Pigeon says; \"CO CO!! \"");
            
        }
        public override void fly()
        {
            Console.WriteLine("Pigeon is flapping its wing");
        }
    }
    public  sealed class CabilityChicken : CapabilityBird
    {
        public override void talk()
        {
            Console.WriteLine("CabilityChicken says: CLUCK! CLUCK!");
        }

        public override void fly()
        {
            Console.WriteLine("I am a chicken -  I Cant fly");
           
        }
     

    }
    public sealed class Caller
    {
        public void describe(CapabilityBird obj)
        {
            obj.talk();
            obj.fly();
        }
    }
  
}
