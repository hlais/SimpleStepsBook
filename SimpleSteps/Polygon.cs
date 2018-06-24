using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps
{
    public class Polygon
    {
        protected int width, height;

        public void setValue(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
    public class Rectangle : Polygon
    {
        public int area() { return (width * height); }
     
    }
    public class Triangle : Polygon
    {
        public int area() { return ((width * height) / 2); }
    }
}
