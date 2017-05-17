using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareEngineering2.InterfaceObjects;

namespace SoftwareEngineering2.Visitor
{
    interface IVisitor
    {
        void Visit(Label label);
        void Visit(TextField textField);
        void Visit(Button button);
    }
}
