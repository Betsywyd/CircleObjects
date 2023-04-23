using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    public class Circle
    {
    public double Radius { get; set; }

    public Circle(double Radius)   
    {
            this.Radius = Radius;

    }
       public double Diameter()
        {
            double d = 2 * Radius;
            return d;
        }

        public double Circumference()
        {
            double c = 2 * Radius * Math.PI;
            return c;
        }

        public double Area()
        {
            double s = Radius * Radius * Math.PI;
            return s;
        }

        public double Grow(double r)
        {
            double Radius = 2 * r;
            return Radius;
        }

        public double GetRadius()
        {
            return Radius;
        }












    }
}
