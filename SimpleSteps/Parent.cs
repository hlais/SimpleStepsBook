using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Called");
        }
        public Parent(int num)
        {
            Console.WriteLine($"Parent Called number {num }");
        }
    }
    public class Daughter : Parent
    {
        public Daughter()
        {
            Console.WriteLine("\tDaughter Called it\n");
        }

    }
    public class Son : Parent
    {
        public Son()
        {
            Console.WriteLine("\tSon Called\n");
        }
        public Son(int num): base (num)
        {
            Console.WriteLine($"Son Called number {num}");
        }
    }
}
