using System;
using System.Threading;

namespace SimpleSteps
{
    class Program
    {

        static void Main(string[] args)
        {




            Rectangle rect = new Rectangle();
            Triangle cone = new Triangle();

            rect.setValue(4, 5);
            cone.setValue(4, 5);

            Console.WriteLine("Area of Rectange :" +  rect.area());
            Console.WriteLine("Area of Triangle: " + cone.area());




            //cat classes play with contructors 
            //default cat
            //Cat tigger = new Cat();
            //string tagT = string.Format("{0} is a {1} year old {2} cat",
            //                              tigger.getName(), tigger.getAge(), tigger.getColor());
            ////creating our own Cat
            //Console.WriteLine(tagT + tigger.cry());
            //
            //Cat pochie = new Cat();
            //pochie.setName("Pochie");
            //pochie.setAge(10);
            //pochie.setColor("Ginger");
            //
            //string tagP = string.Format("My name{0}, and I am {1} years wise because I am {2}",
            //                            pochie.getName(), pochie.getAge(), pochie.getColor());
            //
            //Console.WriteLine(tagP + pochie.cry());


          

            //creating instance of dog 
            //Dog fido = new Dog();
            //fido.setValues("Zak", 38, "Brown");
            //string tagZak = string.Format("{0} is a {1} year old {2} dog", fido.getName(), fido.getAge(), fido.getColor());
            //Console.WriteLine(tagZak + fido.bark());


            Console.ReadLine();
        }
       
    }
}
