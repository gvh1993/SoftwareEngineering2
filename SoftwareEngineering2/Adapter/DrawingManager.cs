using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.InterfaceObjects;

namespace SoftwareEngineering2.Adapter
{
    class DrawingManager : IDrawingManager
    {
        public void DrawMonogame(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();

            
        }

        public void DrawJavaFX()
        {
            throw new NotImplementedException();
        }
    }
}
