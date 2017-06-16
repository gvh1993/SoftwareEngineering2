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
    class ClickableDecorator : GuiElementDecorator
    {
        public Color BackgroundColor { get; set; }
        public Color HoverBackgroundColor { get; set; }
        public Texture2D Texture { get; set; }
        public ScreenManager GoToWindow { get; set; }
        public float Scale { get; set; }
        public Vector2 ButtonLabelPosition { get; set; }

        public ClickableDecorator(IGuiElement guiElement, Color backgroundColor, Color hoverBackgroundColor, Texture2D texture, ScreenManager goToWindow) : base(guiElement)
        {
            BackgroundColor = backgroundColor;
            HoverBackgroundColor = hoverBackgroundColor;
            Texture = texture;
            GoToWindow = goToWindow;
        }

        public override void Accept(IVisitor visitor)
        {
            GuiElement.Accept(visitor);
            visitor.Visit(this);
        }
    }
}
