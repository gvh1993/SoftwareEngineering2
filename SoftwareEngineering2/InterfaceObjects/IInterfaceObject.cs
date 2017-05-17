using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareEngineering2.Visitor;


namespace SoftwareEngineering2.InterfaceObjects
{
    interface IInterfaceObject
    {
        void Accept(IVisitor visitor);
    }
}
