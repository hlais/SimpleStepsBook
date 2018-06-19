using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class Dog
    {
        private string name, color;
        private int age;

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
