using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//contains a bunch of MenuItems. A ConsoleMenu needs to be able to Display the MenuItems, and make a selection from them.

//The ConsoleMenu also has a bool Property called IsActive. This is set to true when the ConsoleMenu is selected. 
namespace Danial.Menu
{
    internal abstract class ConsoleMenu : MenuItem
    {
        protected List<MenuItem> _menuItems = new List<MenuItem>();

        public bool IsActive { get; set; }

        public abstract void CreateMenu();

        public override void Select()
        {
            IsActive = true;
            do
            {
                CreateMenu();
                string output = $"{MenuText()}{Environment.NewLine}";
                int selection = ConsoleHelpers.GetIntegerInRange(1, _menuItems.Count, this.ToString()) - 1;
                _menuItems[selection].Select();
            } while (IsActive);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(MenuText());
            for (int i = 0; i < _menuItems.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {_menuItems[i].MenuText()}");
            }
            return sb.ToString();
        }
    }
}


//In this example, MyMenuItem is a subclass of MenuItem that provides
//implementations for the Select and MenuText methods.
//You can create different subclasses for different types of menu items, each with their own behavior and text. This is a common pattern in object-oriented programming known as polymorphism. It allows you to treat different types of objects in the same way,
//which can make your code more flexible and easier to maintain.

//PL 16.5 Abstraction - ConsoleMenu and MenuItem