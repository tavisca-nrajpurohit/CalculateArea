using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Circle:IShape
    {
        const double PI = 3.14;
        int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return (PI * this.radius * this.radius);
        }
    }
}
