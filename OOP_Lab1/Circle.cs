using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1
{
    internal class Circle
    {
        double Radius { get; set; }

        public double GetArea()
        {
            double area = Radius * Radius * Math.PI;
            Console.WriteLine($"The area of a circle with radius {Radius} cm is {area} cm²");
            return area;
        }
    }

}

