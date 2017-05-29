using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.InterfaceObjects;

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
            _spriteBatch.Begin();
            //fill in the pixels of the texture2D
            Color[] colorData = new Color[button.Texture.Width * button.Texture.Height];

            for (int i = 0; i < button.Texture.Height * button.Texture.Width; i++)
            {
                colorData[i] = button.BackgroundColor;
            }

            button.Texture.SetData(colorData);

            //textScale
            Vector2 size = Game1.Font.MeasureString(button.ButtonText);
            float xScale = (button.Texture.Width / size.X);
            float yScale = (button.Texture.Height / size.Y);
            float scale = Math.Min(xScale, yScale);

            Vector2 stringDimensions = new Vector2((int)Math.Round(size.X * scale), (int)Math.Round(size.Y * scale));
            Vector2 buttonLabelPosition = new Vector2(button.Position.X + (button.Texture.Width / 2) - (stringDimensions.X / 2), button.Position.Y + (button.Texture.Height / 2) - (stringDimensions.Y / 2));

            _spriteBatch.End();
        }

        public void Visit(Label label)
        {
            _spriteBatch.Begin();
            _spriteBatch.DrawString(Game1.Font, label.LabelText, label.Position, label.TextColor);
            _spriteBatch.End();
        }

        public void Visit(TextField textField)
        {
            // draw the textfield
            _spriteBatch.Begin();

            //draw the box
            //fill in the pixels of the texture2D
            Color[] colorData = new Color[textField.Texture.Width * textField.Texture.Height];

            for (int i = 0; i < textField.Texture.Height * textField.Texture.Width; i++)
            {
                colorData[i] = textField.BackgroundColor;
            }

            textField.Texture.SetData(colorData);

            _spriteBatch.Draw(textField.Texture, new Rectangle((int)textField.Position.X, (int)textField.Position.Y, (int)textField.Texture.Width, (int)textField.Texture.Height), textField.BackgroundColor);

            //draw the text + cursor

            string text = "";
            for (int i = 0; i < textField.Text.Count; i++)
            {
                //check if cursor is on this place
                if (textField.Cursor == i)
                {
                    text += "|";
                }
                text += textField.Text[i];
            }

            _spriteBatch.DrawString(Game1.Font, text, textField.Position, textField.TextColor);

            _spriteBatch.End();
        }
    }
}
