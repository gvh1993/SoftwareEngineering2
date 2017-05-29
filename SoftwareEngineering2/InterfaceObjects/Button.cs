using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.Visitor;
using Microsoft.Xna.Framework.Input;
using SoftwareEngineering2.Adapter;

namespace SoftwareEngineering2.InterfaceObjects
{
    class Button : IGuiElement
    {
        public Color BackgroundColor { get; set; }
        public Color HoverBackgroundColor { get; set; }
        public Vector2 Position { get; set; }
        public string ButtonText { get; set; }
        public Texture2D Texture { get; set; }
        public ScreenManager GoToWindow { get; set; }
        public float Scale { get; set; }
        public Vector2 ButtonLabelPosition { get; set; }

        public Button(Color backgroundColor, Color hoverBackgroundColor, Vector2 position, string buttonText, Texture2D texture, ScreenManager goToWindow)
        {
            BackgroundColor = backgroundColor;
            HoverBackgroundColor = hoverBackgroundColor;
            Position = position;
            ButtonText = buttonText;
            Texture = texture;
            GoToWindow = goToWindow;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
