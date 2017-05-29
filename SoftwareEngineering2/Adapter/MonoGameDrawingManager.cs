using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.InterfaceObjects;
using Microsoft.Xna.Framework;

namespace SoftwareEngineering2.Adapter
{
    class MonoGameDrawingManager : IDrawingManager
    {
        public SpriteBatch SpriteBatch { get; set; }
        public MonoGameDrawingManager(SpriteBatch spriteBatch)
        {
            SpriteBatch = spriteBatch;
        }
        public void Draw(Button button)
        {
            SpriteBatch.Begin();
            SpriteBatch.Draw(button.Texture, new Rectangle((int)button.Position.X, (int)button.Position.Y, (int)button.Texture.Width, (int)button.Texture.Height), button.BackgroundColor);
            SpriteBatch.DrawString(Game1.Font, button.ButtonText, button.ButtonLabelPosition, Color.White, 0.0f, new Vector2(0, 0), button.Scale, new SpriteEffects(), 0.0f);
            SpriteBatch.End();
        }

        public void Draw(TextField textField)
        {

        }

        public void Draw(Label label)
        {

        }



        public void DrawJavaFX()
        {
            throw new NotImplementedException();
        }
    }
}
