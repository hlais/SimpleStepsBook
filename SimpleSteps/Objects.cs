using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    class Objects
    {
        public class Dog
        {
            //memeber variables
            private string name;
            private int age;
            private string color;

            //member methods
            public void setName(string tag)
            {
                this.name = tag;//store the argument value
            }

            public string getName()
            {
                return name; //retrieve the stored value
            }

            public void setAge(int yrs)
            {
                this.age = yrs;
            }
            public int getAge()
            {
                return age;
            }
            public void setColor(string color)
            {
                this.color = color;
            }

            //other methods 
            public string bark()
            {
                return "I am not realy a dog";
            }


        }
    }
}
    