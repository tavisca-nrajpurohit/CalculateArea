using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Square : IShape
    {
        int side;
        public Square(int side)
        {
            this.side = side;
        }
        public double GetArea()
        {
            return (side*side);
        }
    }
}
