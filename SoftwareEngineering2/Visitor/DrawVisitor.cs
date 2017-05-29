using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.InterfaceObjects;
using SoftwareEngineering2.Adapter;

namespace SoftwareEngineering2.Visitor
{
    class DrawVisitor : IVisitor
    {
        private readonly SpriteBatch _spriteBatch;
        public DrawVisitor(SpriteBatch spriteBatch)
        {
            //need something like spritebatch/screenmanager or something so i can start drawing
            _spriteBatch = spriteBatch;
        }
        //public void Visit(IGuiElement guiElement)
        //{
        //    guiElement.Draw(_spriteBatch);
        //}

        public void Visit(Button button)
        {
            //draw my button
            //use adapter
            //_spriteBatch.Begin();

            //fill in the pixels of the texture2D
            Color[] colorData = new Color[button.Texture.Width * button.Texture.Height];

            for (int i = 0; i < button.Texture.Height * button.Texture.Width; i++)
            {
                colorData[i] = button.BackgroundColor;
            }

            button.Texture.SetData(colorData);
            //
            

            //textScale
            Vector2 size = Game1.Font.MeasureString(button.ButtonText);
            float xScale = (button.Texture.Width / size.X);
            float yScale = (button.Texture.Height / size.Y);
            button.Scale = Math.Min(xScale, yScale);

            Vector2 stringDimensions = new Vector2((int)Math.Round(size.X * button.Scale), (int)Math.Round(size.Y * button.Scale));
            button.ButtonLabelPosition = new Vector2(button.Position.X + (button.Texture.Width / 2) - (stringDimensions.X / 2), button.Position.Y + (button.Texture.Height / 2) - (stringDimensions.Y / 2));
            
            //
            //_spriteBatch.End();
            IDrawingManager drawingManager = new MonoGameDrawingManager(_spriteBatch);
            drawingManager.Draw(button);
        }

        public void Visit(Label label)
        {
            IDrawingManager drawingManager = new MonoGameDrawingManager(_spriteBatch);
            drawingManager.Draw(label);
        }

        public void Visit(TextField textField)
        {
            // draw the textfield
           // _spriteBatch.Begin();

            //draw the box
            //fill in the pixels of the texture2D
            Color[] colorData = new Color[textField.Texture.Width * textField.Texture.Height];

            for (int i = 0; i < textField.Texture.Height * textField.Texture.Width; i++)
            {
                colorData[i] = textField.BackgroundColor;
            }

            textField.Texture.SetData(colorData);

            

            //draw the text + cursor

            textField.TextString = "";
            for (int i = 0; i < textField.Text.Count; i++)
            {
                //check if cursor is on this place
                if (textField.Cursor == i)
                {
                    textField.TextString += "|";
                }
                textField.TextString += textField.Text[i];
            }

            IDrawingManager drawingManager = new MonoGameDrawingManager(_spriteBatch);
            drawingManager.Draw(textField);
        }
    }
}
