using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Triangle : IShape
    {
        double _area;

        public Triangle(int height, int baseLength)
        {
            this._area = (0.5 * height * baseLength);
        }
        public Triangle(int side1, int side2, int side3)
        {
            int s = (side1 + side2 + side3) / 2;
           this. _area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

        }
        public double GetArea()
        {
            return this._area;
        }
    }
}
