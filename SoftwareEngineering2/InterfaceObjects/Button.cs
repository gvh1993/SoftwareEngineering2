using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.Visitor;
using Microsoft.Xna.Framework.Input;
using SoftwareEngineering2.Adapter;

namespace SoftwareEngineering2.InterfaceObjects
{
    class Button : IGuiElement
    {
        public Color BackgroundColor { get; set; }
        public Color HoverBackgroundColor { get; set; }
        public Vector2 Position { get; set; }
        public string ButtonText { get; set; }
        public Texture2D Texture { get; set; }
        public ScreenManager GoToWindow { get; set; }
        public float Scale { get; set; }
        public Vector2 ButtonLabelPosition { get; set; }

        public Button(Color backgroundColor, Color hoverBackgroundColor, Vector2 position, string buttonText, Texture2D texture, ScreenManager goToWindow)
        {
            BackgroundColor = backgroundColor;
            HoverBackgroundColor = hoverBackgroundColor;
            Position = position;
            ButtonText = buttonText;
            Texture = texture;
            GoToWindow = goToWindow;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            ////fill in the pixels of the texture2D
            //Color[] colorData = new Color[Texture.Width * Texture.Height];

            //for (int i = 0; i < Texture.Height * Texture.Width; i++)
            //{
            //    colorData[i] = BackgroundColor;
            //}

            //Texture.SetData(colorData);

            ////textScale
            //Vector2 size = Game1.Font.MeasureString(ButtonText);
            //float xScale = (Texture.Width / size.X);
            //float yScale = (Texture.Height / size.Y);
            //Scale = Math.Min(xScale, yScale);

            //Vector2 stringDimensions = new Vector2((int)Math.Round(size.X * Scale), (int)Math.Round(size.Y * Scale));
            //ButtonLabelPosition = new Vector2(Position.X + (Texture.Width / 2) - (stringDimensions.X / 2), Position.Y + (Texture.Height / 2) - (stringDimensions.Y / 2));



            //// adapter aanroepen
            //IDrawingManager drawManager = new MonoGameDrawingManager(spriteBatch);
            //drawManager.Draw(this);
        }

        public void Update()
        {
            ////checked if button is hovering
            //if (!(Mouse.GetState().Position.X < (Position.X + Texture.Width)) ||
            //    !(Mouse.GetState().Position.X > Position.X) ||
            //    !(Mouse.GetState().Position.Y < (Position.Y + Texture.Height)) ||
            //    !(Mouse.GetState().Position.Y > Position.Y))
            //{
            //    BackgroundColor = Color.Black;
            //    return;
            //}
            //// IsHOVERING
            //BackgroundColor = Color.Red;
            //if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            //{
            //    // IS clicked
            //    Game1.CurrentScreen = GoToWindow;
            //}
        }
    }
}
