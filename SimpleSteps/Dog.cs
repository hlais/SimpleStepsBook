using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    public class Dog
    {
        private string name, color;
        private int age;

        //constructor that requires initiazation 
        //public Dog(string name, string color, int age)
        //{
        //    this.name = name;
        //    this.color = color;
        //    this.age = age;

        //}



        public void setValues(string name, int age, string color)
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }
        public string getName() { return name; }
        public string getColor() { return color; }
        public int getAge() { return age; }

        public string bark()
        {
            return "\n\t\rWOOOD FORD WOFF!";
        }


    }

}
