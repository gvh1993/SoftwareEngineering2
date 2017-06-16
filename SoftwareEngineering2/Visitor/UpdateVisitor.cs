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
using SoftwareEngineering2.Decorator;

namespace SoftwareEngineering2.Visitor
{
    class UpdateVisitor : IVisitor
    {

        public void Visit(LabelDecorator label)
        {
            // don't need to update a label right?
        }

        public void Visit(ClickableDecorator clickable)
        {
            //update button
                //checked if button is hovering
                IInputManager manager = new InputManager();

            if (!(manager.GetMouseInput().Position.X < (clickable.GetPosition().X + clickable.Texture.Width)) ||
                !(manager.GetMouseInput().Position.X > clickable.GetPosition().X) ||
                !(manager.GetMouseInput().Position.Y < (clickable.GetPosition().Y + clickable.Texture.Height)) ||
                !(manager.GetMouseInput().Position.Y > clickable.GetPosition().Y))
            {
                clickable.BackgroundColor = Color.Black;
                return;
            }
            // IsHOVERING
            clickable.BackgroundColor = clickable.HoverBackgroundColor;
            if (manager.GetMouseInput().LeftButton == ButtonState.Pressed)
            {
                // IS clicked
                Game1.CurrentScreen = clickable.GoToWindow;
            }
        }

        public void Visit(InputDecorator input)
        {
            IInputManager manager = new InputManager();

            if (manager.GetKeyboardInput().GetPressedKeys().Length == 0)
                return;

            var key = manager.GetKeyboardInput().GetPressedKeys()[0];
            switch (key)
            {
                case Keys.Space:
                    input.Text.Insert(input.Cursor, ' ');
                    input.Cursor++;
                    break;
                case Keys.Back:
                    if (input.Text.Count == 0)
                        break;
                    input.Text.RemoveAt(input.Cursor - 1);
                    input.Cursor--;
                    break;
                default:
                    //add to list where cursor is
                    //increment cursor
                    try
                    {
                        input.Text.Insert(input.Cursor, Convert.ToChar(key.ToString()));
                        input.Cursor++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }

                    break;
            }
        }

        public void Visit(IGuiElement guiElement)
        {
            // for BasicGuiElement
        }



        //public void Visit(Button button)
        //{
        //    //update button
        //    //checked if button is hovering
        //    IInputManager manager = new InputManager();
            
        //    if (!(manager.GetMouseInput().Position.X < (button.Position.X + button.Texture.Width)) ||
        //        !(manager.GetMouseInput().Position.X > button.Position.X) ||
        //        !(manager.GetMouseInput().Position.Y < (button.Position.Y + button.Texture.Height)) ||
        //        !(manager.GetMouseInput().Position.Y > button.Position.Y))
        //    {
        //        button.BackgroundColor = Color.Black;
        //        return;
        //    }
        //    // IsHOVERING
        //    button.BackgroundColor = Color.Red;
        //    if (manager.GetMouseInput().LeftButton == ButtonState.Pressed)
        //    {
        //        // IS clicked
        //        Game1.CurrentScreen = button.GoToWindow;
        //    }
        //}

        //public void Visit(Label label)
        //{
        //    //dont have to update a label right?
        //}

        //public void Visit(TextField textField)
        //{
        //    IInputManager manager = new InputManager();
            
        //    if (manager.GetKeyboardInput().GetPressedKeys().Length == 0)
        //        return;

        //    var key = manager.GetKeyboardInput().GetPressedKeys()[0];
        //    switch (key)
        //    {
        //        case Keys.Space:
        //            textField.Text.Insert(textField.Cursor, ' ');
        //            textField.Cursor++;
        //            break;
        //        case Keys.Back:
        //            if (textField.Text.Count == 0)
        //                break;
        //            textField.Text.RemoveAt(textField.Cursor - 1);
        //            textField.Cursor--;
        //            break;
        //        default:
        //            //add to list where cursor is
        //            //increment cursor
        //            try
        //            {
        //                textField.Text.Insert(textField.Cursor, Convert.ToChar(key.ToString()));
        //                textField.Cursor++;
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex);
        //            }

        //            break;
        //    }
        //}
    }
}
