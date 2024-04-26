using Danial.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Danial.Shapes.Shape;

namespace Danial.Shapes
{
    internal class AddCircleMenuItem : MenuItem
    {
        private ShapeManager _manager;

        public AddCircleMenuItem(ShapeManager manager)
        {
            _manager = manager;
        }

        public override string MenuText()
        {
            return "Add circle menu";
        }

        public override void Select()
        {
            //when calling this method , the goal is to create a circle and add it to the shapemanager 
            StringBuilder sb = new StringBuilder($"{MenuText()}{Environment.NewLine}");
            int i = 1;
            foreach (Shape.Colour c in Enum.GetValues(typeof(Shape.Colour)))
            {
                sb.AppendLine($"{i}. {c}");
                i++;
            }
            string colourMenu = sb.ToString();
            int selectedIndex = ConsoleHelpers.GetIntegerInRange(1, Enum.GetValues(typeof(Shape.Colour)).Length, colourMenu) - 1;
            Colour colour = (Shape.Colour)selectedIndex;
            int radius = ConsoleHelpers.GetIntegerInRange(Circle.MIN_RADIUS, Circle.MAX_RADIUS, "What is the radius");
            Circle circle = new Circle(radius, colour);
            _manager.AddShape(circle);
        }
    }
}
