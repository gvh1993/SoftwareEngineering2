using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using SoftwareEngineering2.Visitor;
using Microsoft.Xna.Framework.Graphics;

namespace SoftwareEngineering2.InterfaceObjects
{
    interface IGuiElement
    {
        Vector2 GetPosition();
        void Accept(IVisitor visitor);
    }
}
