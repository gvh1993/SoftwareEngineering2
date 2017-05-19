using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.Visitor;

namespace SoftwareEngineering2.InterfaceObjects
{
    class TextField : IInterfaceObject
    {
        public Color BackgroundColor { get; set; }
        public Color TextColor { get; set; }
        public Vector2 Position { get; set; }
        public List<char> Text { get; set; }
        public Texture2D Texture { get; set; }
        public int Cursor { get; set; }

        public TextField(Color backgroundColor, Color textColor, Vector2 position, List<char> text, Texture2D texture )
        {
            BackgroundColor = backgroundColor;
            TextColor = textColor;
            Position = position;
            Text = text;
            Texture = texture;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
