using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Triangle : IShape
    {
        int height, baseLength;
        int side1, side2, side3;
        double area;

        public Triangle(int height, int baseLength)
        {
            this.height = height;
            this.baseLength = baseLength;
            this.area = (0.5 * this.height * this.baseLength);
        }
        public Triangle(int side1, int side2, int side3)
        {
            this.side1 = side1;
            this.baseLength = baseLength;
            int s = (side1 + side2 + side3) / 2;
            area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

        }
        public double GetArea()
        {
            return this.area;
        }
    }
}
