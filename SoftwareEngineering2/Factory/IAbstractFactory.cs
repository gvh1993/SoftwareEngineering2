using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.InterfaceObjects;
using SoftwareEngineering2.Iterator;

namespace SoftwareEngineering2.Factory
{
    interface IAbstractFactory
    {
        IGuiElementCollection CreateMainScreen();
        IGuiElementCollection CreatInputScreen();
        IGuiElementCollection CreateLabelScreen();
    }
}
