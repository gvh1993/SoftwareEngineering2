using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareEngineering2.Decorator;
using SoftwareEngineering2.InterfaceObjects;

namespace SoftwareEngineering2.Visitor
{
    interface IVisitor
    {
        void Visit(LabelDecorator label);
        void Visit(ClickableDecorator clickable);
        void Visit(InputDecorator input);

        void Visit(IGuiElement guiElement);
    }
}
