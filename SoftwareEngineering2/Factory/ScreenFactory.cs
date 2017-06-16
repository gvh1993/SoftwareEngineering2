using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SoftwareEngineering2.Decorator;
using SoftwareEngineering2.InterfaceObjects;
using SoftwareEngineering2.Iterator;

namespace SoftwareEngineering2.Factory
{
    class ScreenFactory : IAbstractFactory
    {
        private readonly GraphicsDeviceManager _graphicsDeviceManager;
        private IGuiElementCollection _collection;
        public ScreenFactory(GraphicsDeviceManager graphicsDeviceManager)
        {
            _graphicsDeviceManager = graphicsDeviceManager;
           
        }

        public IGuiElementCollection CreateMainScreen()
        {
            var mainWindowElements = new List<IGuiElement>()
            {
                //label
                new LabelDecorator(new BasicGuiElement(new Vector2(5,5)), "Main window", Color.White),

                //buttons
                new LabelDecorator(new ClickableDecorator(new BasicGuiElement(new Vector2(250, 50)), Color.Black, Color.Red,
                            new Texture2D(_graphicsDeviceManager.GraphicsDevice, 150, 40), ScreenManager.InputWindow), "Input Window", Color.White),

                new LabelDecorator(new ClickableDecorator(new BasicGuiElement(new Vector2(250, 100)), Color.Black, Color.Red,
                            new Texture2D(_graphicsDeviceManager.GraphicsDevice, 150, 40), ScreenManager.LabelWindow), "Label Window", Color.White),

                new LabelDecorator(new ClickableDecorator(new BasicGuiElement(new Vector2(250, 250)), Color.Black, Color.Red,
                            new Texture2D(_graphicsDeviceManager.GraphicsDevice, 150, 40), ScreenManager.Exit), "Exit Window", Color.White),


               // new Label("MainWindow", new Vector2(5, 5), Color.Black),
                //new Button(Color.Black, Color.White, new Vector2(250, 50), "Input window",
                //    new Texture2D(_graphicsDeviceManager.GraphicsDevice, 150, 40), ScreenManager.InputWindow),
                //new Button(Color.Black, Color.White, new Vector2(250, 100), "Label window",
                //    new Texture2D(_graphicsDeviceManager.GraphicsDevice, 150, 40), ScreenManager.LabelWindow),
                //new Button(Color.Black, Color.White, new Vector2(250, 250), "Exit",
                //    new Texture2D(_graphicsDeviceManager.GraphicsDevice, 150, 40), ScreenManager.Exit)
            };
            _collection = new GuiElementCollection(mainWindowElements);

            return _collection;
        }

        public IGuiElementCollection CreatInputScreen()
        {
            var inputWindowElements = new List<IGuiElement>()
            {
                new LabelDecorator(new BasicGuiElement(new Vector2(5,5)), "Input window", Color.White),

                new InputDecorator(new BasicGuiElement(new Vector2(250,90)),Color.White, Color.Black, new List<char>(), new Texture2D(_graphicsDeviceManager.GraphicsDevice, 500, 40)),

                new LabelDecorator(new ClickableDecorator(new BasicGuiElement(new Vector2(250, 150)), Color.Black, Color.Red,
                            new Texture2D(_graphicsDeviceManager.GraphicsDevice, 150, 40), ScreenManager.MainWindow), "Back", Color.White),

                //new Label("InputWindow", new Vector2(5, 5), Color.Black),
                //new TextField(Color.White, Color.Black, new Vector2(250, 90), new List<char>(), new Texture2D(_graphicsDeviceManager.GraphicsDevice, 150, 40)),
                //new Button(Color.Black, Color.White, new Vector2(250, 150), "Back",
                //    new Texture2D(_graphicsDeviceManager.GraphicsDevice, 150, 40), ScreenManager.MainWindow)
            };
            _collection = new GuiElementCollection(inputWindowElements);

            return _collection;
        }

        public IGuiElementCollection CreateLabelScreen()
        {
            var labelWindowElements = new List<IGuiElement>()
            {
                new LabelDecorator(new BasicGuiElement(new Vector2(5,5)), "Label window", Color.White),

                new LabelDecorator(new BasicGuiElement(new Vector2(250, 50)), "I am a label", Color.Black),

                new LabelDecorator(new ClickableDecorator(new BasicGuiElement(new Vector2(250, 150)), Color.Black, Color.Red,
                            new Texture2D(_graphicsDeviceManager.GraphicsDevice, 150, 40), ScreenManager.MainWindow), "Back", Color.White),

                //new Label("LabelWindow", new Vector2(5, 5), Color.Black),
                //new Label("I am a label", new Vector2(250, 50), Color.Black),
                //new Button(Color.Black, Color.White, new Vector2(250, 150), "Back",
                //    new Texture2D(_graphicsDeviceManager.GraphicsDevice, 150, 40), ScreenManager.MainWindow)
            };
            _collection = new GuiElementCollection(labelWindowElements);

            return _collection;
        }
    }
}
