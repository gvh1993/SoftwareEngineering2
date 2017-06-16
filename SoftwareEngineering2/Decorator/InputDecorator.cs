using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.InterfaceObjects;
using SoftwareEngineering2.Visitor;

namespace SoftwareEngineering2.Decorator
{
    class InputDecorator : GuiElementDecorator
    {
        public Color BackgroundColor { get; set; }
        public Color TextColor { get; set; }
        public List<char> Text { get; set; }
        public Texture2D Texture { get; set; }
        public int Cursor { get; set; }
        public string TextString { get; set; }

        public InputDecorator(IGuiElement guiElement, Color backgroundColor, Color textColor, List<char> text, Texture2D texture) : base(guiElement)
        {
            BackgroundColor = backgroundColor;
            TextColor = textColor;
            Text = text;
            Texture = texture;
        }

        public override void Accept(IVisitor visitor)
        {
            GuiElement.Accept(visitor); //visit parameter GuiElement
            visitor.Visit(this);//visit with this object
        }
    }
}
