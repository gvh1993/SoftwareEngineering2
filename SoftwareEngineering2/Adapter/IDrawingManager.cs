using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.Decorator;
using SoftwareEngineering2.InterfaceObjects;

namespace SoftwareEngineering2.Adapter
{
    interface IDrawingManager
    {
        //void Draw(Button button);
        //void Draw(TextField textField);
        //void Draw(Label label);

        void Draw(LabelDecorator label);
        void Draw(ClickableDecorator clickable);

        void Draw(InputDecorator input);

    }
}
