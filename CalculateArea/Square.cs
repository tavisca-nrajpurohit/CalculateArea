using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Square : IShape
    {
        int _side;
        public Square(int side)
        {
            this._side = side;
        }
        public double GetArea()
        {
            return (_side*_side);
        }
    }
}
