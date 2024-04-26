using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danial.Shapes
{
    class Circle : Shape
    {
        public override float Area()
        {
            return MathF.PI * _Radius * _Radius;
        }

        public override float Perimeter()
        {
            return 2 * MathF.PI * _Radius;
        }
        //You can also override the ToString method from the object class. This will be useful later on.
        public const int MIN_RADIUS = 0;
        public const int MAX_RADIUS = 50;

        private float _Radius;

        public float Radius
        {
            get { return _Radius; }
            set { if (value >= MIN_RADIUS && value <= MAX_RADIUS) { _Radius = value; } }
        }

        public Circle(float radius, Colour colour)
        {
            Radius = radius;
            ShapeColour = colour;
        }

        public override string ToString()
        {
            return $"{ShapeColour} circle with radius {Radius}.";
        }
    }
}

//Here the Circle inherits from the Shape class, but this code won't compile because the Circle does not provide
//an implementation of the abstract methods in the Shape parent class. This is why an abstract class is sometimes called a "Bossy Parent",
//because it forces any instantiable class that inherits from it to provide an implementation for the abstract methods.
//Add those methods now using the override keyword.