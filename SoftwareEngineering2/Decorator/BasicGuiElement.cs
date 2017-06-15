using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using SoftwareEngineering2.Visitor;

namespace SoftwareEngineering2.InterfaceObjects
{
    class BasicGuiElement : IGuiElement
    {
        public Vector2 Position { get; set; }

        public BasicGuiElement(Vector2 position)
        {
            Position = position;
        }

        public Vector2 GetPosition()
        {
            return Position;
        }

        public void Accept(IVisitor visitor)
        {
           visitor.Visit(this);
        }
    }
}
