using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danial.Shapes
{
    internal abstract class Shape
    {
        public enum Colour { Red, Green, Blue }
        public Colour ShapeColour { set; get; }

        public abstract float Area();
        public abstract float Perimeter();
    }
}

//This is where abstraction comes in handy. Instead of making a virtual method we can make an abstract method and then we don't have to provide an implementation. You can only create an abstract method inside an abstract class, so both the method and the class have to be made abstract.