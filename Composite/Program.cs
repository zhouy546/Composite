using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Item nut = new Part("Nut", 5);
            Item bot = new Part("Bolt", 9);
            Item panel = new Part("Panel", 35);
            Item gizmo = new Assembly("Gizmo");

            gizmo.AddItem(panel);
            gizmo.AddItem(nut);
            gizmo.AddItem(bot);
            Item widget = new Assembly("Widget");
            widget.AddItem(gizmo);
            widget.AddItem(nut);

            Console.WriteLine(gizmo.ToString());
            Console.WriteLine(widget.ToString());

        }
    }
}
