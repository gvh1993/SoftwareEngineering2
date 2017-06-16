using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.InterfaceObjects;
using SoftwareEngineering2.Adapter;
using SoftwareEngineering2.Decorator;

namespace SoftwareEngineering2.Visitor
{
    class DrawVisitor : IVisitor
    {
        private readonly SpriteBatch _spriteBatch;
        public DrawVisitor(SpriteBatch spriteBatch)
        {
            _spriteBatch = spriteBatch;
        }

        public void Visit(IGuiElement guiElement)
        {
            // for BasicGuiElement
        }

        public void Visit(LabelDecorator label)
        {
            IDrawingManager drawingManager = new MonoGameDrawingManager(_spriteBatch);
            drawingManager.Draw(label);
        }

        public void Visit(ClickableDecorator clickable)
        {
            //draw my button
            //fill in the pixels of the texture2D
            Color[] colorData = new Color[clickable.Texture.Width * clickable.Texture.Height];

            for (int i = 0; i < clickable.Texture.Height * clickable.Texture.Width; i++)
            {
                colorData[i] = clickable.BackgroundColor;
            }

            clickable.Texture.SetData(colorData);

            IDrawingManager drawingManager = new MonoGameDrawingManager(_spriteBatch);
            drawingManager.Draw(clickable);
        }

        public void Visit(InputDecorator input)
        {
            // draw the textfield

            //draw the box
            //fill in the pixels of the texture2D
            Color[] colorData = new Color[input.Texture.Width * input.Texture.Height];

            for (int i = 0; i < input.Texture.Height * input.Texture.Width; i++)
            {
                colorData[i] = input.BackgroundColor;
            }

            input.Texture.SetData(colorData);


            //draw the text + cursor
            input.TextString = "";
            for (int i = 0; i < input.Text.Count; i++)
            {
                //check if cursor is on this place
                if (input.Cursor == i)
                {
                    input.TextString += "|";
                }
                input.TextString += input.Text[i];
            }

            IDrawingManager drawingManager = new MonoGameDrawingManager(_spriteBatch);
            drawingManager.Draw(input);
        }
    }
}
