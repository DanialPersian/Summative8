using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danial.Menu
{
    internal abstract class MenuItem
    {
        //we could make this an interface
        public abstract void Select();
        public abstract string MenuText();

    }
}
