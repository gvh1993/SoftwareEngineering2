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
    class LabelDecorator : GuiElementDecorator
    {
        public string LabelText { get; set; }
        public Color TextColor { get; set; }


        public LabelDecorator(IGuiElement guiElement, string labelText, Color textColor) : base(guiElement)
        {
            LabelText = labelText;
            TextColor = textColor;
        }

        public override void Accept(IVisitor visitor)
        {
            //visitor.Visit(GuiElement);
            GuiElement.Accept(visitor);
            visitor.Visit(this);

        }
    }
}


