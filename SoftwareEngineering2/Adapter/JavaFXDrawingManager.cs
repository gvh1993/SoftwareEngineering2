using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.InterfaceObjects;

namespace SoftwareEngineering2.Adapter
{
    class JavaFXDrawingManager : IDrawingManager
    {
        public void Draw(Button button)
        {
            throw new NotImplementedException();
        }

        public void Draw(TextField textField)
        {
            throw new NotImplementedException();
        }

        public void Draw(Label label)
        {
            throw new NotImplementedException();
        }
    }
}
