using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareEngineering2.Visitor;
using Microsoft.Xna.Framework.Graphics;

namespace SoftwareEngineering2.InterfaceObjects
{
    interface IGuiElement
    {
        void Accept(IVisitor visitor);
    }
}
