using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Rectangle : IShape
    {
        int _length, _breadth;
        public Rectangle(int length, int breadth)
        {
            this._length = length;
            this._breadth = breadth;
        }
        public double GetArea()
        {
            return (this._length * this._breadth);
        }
    }
}
