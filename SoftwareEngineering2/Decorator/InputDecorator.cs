using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareEngineering2.InterfaceObjects;
using SoftwareEngineering2.Visitor;

namespace SoftwareEngineering2.Decorator
{
    class InputDecorator : GuiElementDecorator
    {
        public InputDecorator(IGuiElement guiElement) : base(guiElement)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            this.GuiElement.Accept(visitor);
        }
    }
}
