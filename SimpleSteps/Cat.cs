using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    public class Cat
    {
        private string name, color;
        private int age;

        public Cat()
        {
            name = "Tony the tiger";
            color = "Orange";
            age = 69;
        }

        //setter methods
        public void setName(string name)
        {
            this.name = name; 
        }
        public void setColor(string color) { this.color = color; }
        public void setAge(int age) { this.age = age; }

        //getter methods
        public string getName() { return name; }
        public string getColor() { return color; }
        public int getAge() { return age; }

        //miscellaneous method
        public string cry() { return " Meoww Meow"; }
        
        

    }
}
