using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle : Shape,iDrawable
    {
        public double Length { get; set; }

        public double Breadth { get; set; }

        double area, pm;

        public Rectangle(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public override double CalculateArea()
        {
            area = Length * Breadth;
            return area;
        }

        public override double CalculatePerimeter()
        {
            pm = 2 * (Length + Breadth);
            return pm;
        }

        public void Draw()
        {
            Console.WriteLine("Shape : Rectangle \n Area : {0} \n Perimeter: {1}", CalculateArea(), CalculatePerimeter());
        }
    }
}
