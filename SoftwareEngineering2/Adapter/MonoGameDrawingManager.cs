using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.InterfaceObjects;
using Microsoft.Xna.Framework;
using SoftwareEngineering2.Decorator;

namespace SoftwareEngineering2.Adapter
{
    class MonoGameDrawingManager : IDrawingManager
    {
        private readonly SpriteBatch _spriteBatch;
        public MonoGameDrawingManager(SpriteBatch spriteBatch)
        {
            _spriteBatch = spriteBatch;
        }
        public void Draw(LabelDecorator label)
        {
              _spriteBatch.Begin();
              _spriteBatch.DrawString(Game1.Font, label.LabelText, label.GetPosition(), label.TextColor);
              _spriteBatch.End();
        }

        public void Draw(ClickableDecorator clickable)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(clickable.Texture, new Rectangle((int)clickable.GetPosition().X, (int)clickable.GetPosition().Y, (int)clickable.Texture.Width, (int)clickable.Texture.Height), clickable.BackgroundColor);
            _spriteBatch.End();
        }

        public void Draw(InputDecorator input)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(input.Texture, new Rectangle((int)input.GetPosition().X, (int)input.GetPosition().Y, (int)input.Texture.Width, (int)input.Texture.Height), input.BackgroundColor);
            _spriteBatch.DrawString(Game1.Font, input.TextString, input.GetPosition(), input.TextColor);
            _spriteBatch.End();
        }
    }
}
