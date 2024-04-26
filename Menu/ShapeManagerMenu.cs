using Danial.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danial.Menu
{
    class ShapeManagerMenu : ConsoleMenu
    {
        private ShapeManager _manager;

        public ShapeManagerMenu(ShapeManager manager)
        {
            _manager = manager;
        }
        public override void CreateMenu()
        {
            _menuItems.Clear();
            //_menuItems.Add(new AddCircleMenuItem(_manager));
            _menuItems.Add(new ExitMenuItem(this));
        }

        public override string MenuText()
        {
            return "Shape Manager Menu";
        }
    }
}
