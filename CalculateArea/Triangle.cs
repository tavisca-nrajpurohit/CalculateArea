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

        public Triangle(int height, int baseLength)
        {
            this.height = height;
            this.baseLength = baseLength;
        }
        public double GetArea()
        {
            return (0.5 * this.height * this.baseLength);
        }
    }
}
