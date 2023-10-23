using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Circle : Shape, iDrawable
    {
        public double Radius { get; set; }
        
        double area,pm;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            area = 3.14 * Radius * Radius;
            return area;
        }
        
        public override double CalculatePerimeter()
        {
            pm = 2 * 3.14 * Radius;
            return pm;
        }

        public void Draw()
        {
            Console.WriteLine("Shape : Circle \n Area : {0} \n Perimeter: {1}", CalculateArea(), CalculatePerimeter());
        }
    }
}
