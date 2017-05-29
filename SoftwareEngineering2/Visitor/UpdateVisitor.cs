using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SoftwareEngineering2.InterfaceObjects;
using Microsoft.Xna.Framework;
using SoftwareEngineering2.Adapter;

namespace SoftwareEngineering2.Visitor
{
    class UpdateVisitor : IVisitor
    {
        private readonly SpriteBatch _spriteBatch;
        public UpdateVisitor(SpriteBatch spriteBatch)
        {
            _spriteBatch = spriteBatch;
        }

        public void Visit(Button button)
        {
            //update button
            //checked if button is hovering
            if (!(Mouse.GetState().Position.X < (button.Position.X + button.Texture.Width)) ||
                !(Mouse.GetState().Position.X > button.Position.X) ||
                !(Mouse.GetState().Position.Y < (button.Position.Y + button.Texture.Height)) ||
                !(Mouse.GetState().Position.Y > button.Position.Y))
            {
                button.BackgroundColor = Color.Black;
                return;
            }
            // IsHOVERING
            button.BackgroundColor = Color.Red;
            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                // IS clicked
                Game1.CurrentScreen = button.GoToWindow;
            }
        }

        public void Visit(Label label)
        {
            //dont have to update a label right?
        }

        public void Visit(TextField textField)
        {
            if (Keyboard.GetState().GetPressedKeys().Length == 0)
                return;

            var key = Keyboard.GetState().GetPressedKeys()[0];
            switch (key)
            {
                case Keys.Space:
                    textField.Text.Insert(textField.Cursor, ' ');
                    textField.Cursor++;
                    break;
                case Keys.Back:
                    if (textField.Text.Count == 0)
                        break;
                    textField.Text.RemoveAt(textField.Cursor - 1);
                    textField.Cursor--;
                    break;
                default:
                    //add to list where cursor is
                    //increment cursor
                    try
                    {
                        textField.Text.Insert(textField.Cursor, Convert.ToChar(key.ToString()));
                        textField.Cursor++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }

                    break;
            }
        }
    }
}
