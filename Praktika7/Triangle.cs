using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika7
{
    internal class Triangle
    {
        private float[] sides;

        public Triangle(float side1, float side2, float side3)
        {
            sides = new float[3];
            sides[0] = side1;
            sides[1] = side2;
            sides[2] = side3;
        }

        public float this[int index]
        {
            get { return sides[index]; }
            set { sides[index] = value; }
        }

        public float Perimeter()
        {
            return sides[0] + sides[1] + sides[2];
        }

        public float Area()
        {
            float semiPerimeter = Perimeter() / 2;
            return (float)Math.Sqrt(semiPerimeter * (semiPerimeter - sides[0]) * (semiPerimeter - sides[1]) * (semiPerimeter - sides[2]));
        }
    }
}
