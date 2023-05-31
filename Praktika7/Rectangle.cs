using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika7
{
    internal class Rectangle
    {
        private float[] sides;

        public Rectangle(float Side1, float Side2)
        {
            sides = new float[2];
            sides[0] = Side1;
            sides[1] = Side2;
        }

        public float this[int index]
        {
            get { return sides[index]; }
            set { sides[index] = value; }
        }

        public float PerimeterR()
        {
            return (sides[0] + sides[1]) * 2;
        }

        public float AreaR()
        {
            return sides[0] * sides[1] / 2;
        }
    }
}
