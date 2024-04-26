using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//List<Shape>: This is a generic list in C#. It means that Shapes is a list that can hold instances of the Shape clas
//So, in simple terms, public List<Shape> Shapes is a list named Shapes that can hold Shape objects and can be accessed from anywhere in the program. It doesn’t do anything by itself; it’s just a declaration. You can add to the list, remove from the list, or iterate over the list elsewhere in your code. For example:

namespace Danial.Shapes
{
    internal class ShapeManager
    {
        //{ get; private set; } means that it can be read but cant be changed , This means the property can be written to, but only from within the same class where it is defined.
        public List<Shape> Shapes { get; private set; }

        public ShapeManager()
        {
            Shapes = new List<Shape>();
        }

        public void AddShape(Shape pShape)
        {
            Shapes.Add(pShape);
        }
    }
}
