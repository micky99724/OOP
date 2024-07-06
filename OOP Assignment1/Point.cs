using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment1
{
    internal struct Point
    {
        public double X {  get; set; } 
        public double Y { get; set; }

        public Point(double _Y, double _X)
        {
            Y = _Y;
            X = _X;
        }
    }
}
