using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SoftwareEngineering2.InterfaceObjects;

namespace SoftwareEngineering2.Visitor
{
    class UpdateVisitor : IVisitor
    {
        private readonly SpriteBatch _spriteBatch;
        public UpdateVisitor(SpriteBatch spriteBatch)
        {
            _spriteBatch = spriteBatch;
        }

        public void Visit(Label label)
        {
            //idunno what to update

        }

        public void Visit(TextField textField)
        {
            if (Keyboard.GetState().GetPressedKeys().Length == 0)
                return;

            var key = Keyboard.GetState().GetPressedKeys()[0];
            switch (key)
            {
                case Keys.Back:
                    if (textField.Text.Count == 0)
                        break;
                    textField.Text.RemoveAt(textField.Cursor - 1);
                    textField.Cursor--;
                    break;
                default:
                    //add to list where cursor is
                    //increment cursor
                    textField.Text.Insert(textField.Cursor, Convert.ToChar(key.ToString()));
                    textField.Cursor++;
                    break;
            }
        }

        public void Visit(Button button)
        {
            //checked if button is hovering
            if (!(Mouse.GetState().Position.X < (button.Position.X + button.Texture.Width)) ||
                !(Mouse.GetState().Position.X > button.Position.X) ||
                !(Mouse.GetState().Position.Y < (button.Position.Y + button.Texture.Height)) ||
                !(Mouse.GetState().Position.Y > button.Position.Y)) return;
            // IsHOVERING

            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                // IS clicked

            }
        }
    }
}
