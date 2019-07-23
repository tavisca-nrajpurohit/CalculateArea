using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Circle:IShape
    {
        const double _PI = 3.14;
        int _radius;

        public Circle(int radius)
        {
            this._radius = radius;
        }

        public double GetArea()
        {
            return ( _PI * this._radius * this._radius);
        }
    }
}
