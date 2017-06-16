﻿using System;
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
        //public void Draw(Button button)
        //{
        //    _spriteBatch.Begin();
        //    _spriteBatch.Draw(button.Texture, new Rectangle((int)button.Position.X, (int)button.Position.Y, (int)button.Texture.Width, (int)button.Texture.Height), button.BackgroundColor);
        //    _spriteBatch.DrawString(Game1.Font, button.ButtonText, button.ButtonLabelPosition, Color.White, 0.0f, new Vector2(0, 0), button.Scale, new SpriteEffects(), 0.0f);
        //    _spriteBatch.End();
        //}

        //public void Draw(TextField textField)
        //{
        //    _spriteBatch.Begin();
        //    _spriteBatch.Draw(textField.Texture, new Rectangle((int)textField.Position.X, (int)textField.Position.Y, (int)textField.Texture.Width, (int)textField.Texture.Height), textField.BackgroundColor);
        //    _spriteBatch.DrawString(Game1.Font, textField.TextString, textField.Position, textField.TextColor);
        //    _spriteBatch.End();
        //}

        //public void Draw(Label label)
        //{
        //    _spriteBatch.Begin();
        //    _spriteBatch.DrawString(Game1.Font, label.LabelGuiElement.LabelText, label.LabelGuiElement.Position, label.LabelGuiElement.TextColor);
        //    _spriteBatch.End();
        //}
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
