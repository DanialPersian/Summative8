using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danial.Shapes
{
    internal class Square : Shape
    {
        public const int MIN_SIDE = 0;
        public const int MAX_SIDE = 50;

        private float _Width;

        public float Height { get { return _Width; } }

        public Square(float width, Colour colour)
        {
            Width = width;
            ShapeColour = colour;
        }

        public float Width
        {
            get { return _Width; }
            set { if (value >= MIN_SIDE && value <= MAX_SIDE) { _Width = value; } }
        }
        public override float Area()
        {
            return _Width * _Width;
        }

        public override float Perimeter()
        {
            return 4 * _Width;
        }

        public override string ToString()
        {
            return $"{ShapeColour} Square with width {Width}.";
        }
    }
}
