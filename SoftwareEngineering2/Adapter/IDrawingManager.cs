using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace SoftwareEngineering2.Adapter
{
    interface IDrawingManager
    {
        void DrawMonogame(SpriteBatch spriteBatch);
        void DrawJavaFX();
    }
}
