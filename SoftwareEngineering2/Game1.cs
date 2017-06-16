using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SoftwareEngineering2.Factory;
using SoftwareEngineering2.Visitor;
using SoftwareEngineering2.InterfaceObjects;
using SoftwareEngineering2.Iterator;

namespace SoftwareEngineering2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private IVisitor _drawVisitor;
        private IVisitor _updateVisitor;

        private IGuiElementCollection mainWindowElements, labelWindowElements, inputWindowElements;
        private IGuiElementCollection _collection;

        readonly GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;

        public static SpriteFont Font;

        public static ScreenManager CurrentScreen;
        
        private readonly IAbstractFactory _screenFactory;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            _screenFactory = new ScreenFactory(_graphics);



            CurrentScreen = ScreenManager.MainWindow;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // Add your initialization logic here
            IsMouseVisible = true;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Font = Content.Load<SpriteFont>("font");
            
            // TODO: use this.Content to load your game content here
            _drawVisitor = new DrawVisitor(_spriteBatch);
            _updateVisitor = new UpdateVisitor();

            mainWindowElements = _screenFactory.CreateMainScreen();
            labelWindowElements = _screenFactory.CreateLabelScreen();
            inputWindowElements = _screenFactory.CreatInputScreen();

            _collection = _screenFactory.CreateMainScreen();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            switch (CurrentScreen)
            {
                case ScreenManager.MainWindow:
                    _collection = mainWindowElements;
                    break;
                case ScreenManager.InputWindow:
                    _collection = inputWindowElements;
                    break;
                case ScreenManager.LabelWindow:
                    _collection = labelWindowElements;
                    break;
                case ScreenManager.Exit:
                    Exit();
                    break;
            }


            IIterator iterator = _collection.Iterator();
            while (iterator.HasNext())
            {
                var guiElement = iterator.Next();
                guiElement.Accept(_updateVisitor);
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            IIterator iterator = _collection.Iterator();
            while (iterator.HasNext())
            {
                var x = iterator.Next();
                x.Accept(_drawVisitor);
            }
            
            base.Draw(gameTime);
        }
    }
}
