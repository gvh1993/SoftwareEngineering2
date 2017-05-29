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
        private readonly SpriteBatch _spriteBatch;
        public MonoGameDrawingManager(SpriteBatch spriteBatch)
        {
            _spriteBatch = spriteBatch;
        }
        public void Draw(Button button)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(button.Texture, new Rectangle((int)button.Position.X, (int)button.Position.Y, (int)button.Texture.Width, (int)button.Texture.Height), button.BackgroundColor);
            _spriteBatch.DrawString(Game1.Font, button.ButtonText, button.ButtonLabelPosition, Color.White, 0.0f, new Vector2(0, 0), button.Scale, new SpriteEffects(), 0.0f);
            _spriteBatch.End();
        }

        public void Draw(TextField textField)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(textField.Texture, new Rectangle((int)textField.Position.X, (int)textField.Position.Y, (int)textField.Texture.Width, (int)textField.Texture.Height), textField.BackgroundColor);
            _spriteBatch.DrawString(Game1.Font, textField.TextString, textField.Position, textField.TextColor);
            _spriteBatch.End();
        }

        public void Draw(Label label)
        {
            _spriteBatch.Begin();
            _spriteBatch.DrawString(Game1.Font, label.LabelText, label.Position, label.TextColor);
            _spriteBatch.End();
        }
    }
}
