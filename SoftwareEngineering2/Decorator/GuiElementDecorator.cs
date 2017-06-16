using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using SoftwareEngineering2.InterfaceObjects;
using SoftwareEngineering2.Visitor;

namespace SoftwareEngineering2.Decorator
{
    abstract class GuiElementDecorator : IGuiElement
    {
        protected IGuiElement GuiElement;

        protected GuiElementDecorator(IGuiElement guiElement)
        {
            GuiElement = guiElement;
        }

        public virtual Vector2 GetPosition()
        {
           return GuiElement.GetPosition();
        }

        public virtual void Accept(IVisitor visitor)
        {
            GuiElement.Accept(visitor);
        }
    }
}
