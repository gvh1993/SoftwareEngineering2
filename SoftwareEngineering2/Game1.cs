﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SoftwareEngineering2.Visitor;
using SoftwareEngineering2.InterfaceObjects;


namespace SoftwareEngineering2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private IVisitor _drawVisitor;
        private IVisitor _updateVisitor;

        private Label _label;
        private TextField _textField;
        private Button _button;

        readonly GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;

        public static SpriteFont font;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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
            font = Content.Load<SpriteFont>("font");
            
            // TODO: use this.Content to load your game content here
            _drawVisitor = new DrawVisitor(_spriteBatch);
            _updateVisitor = new UpdateVisitor(_spriteBatch);

            _label = new Label("I am a label", new Vector2(50, 35), Color.Black);
            _textField = new TextField(Color.White, Color.Black, new Vector2(50, 90), new List<char>(), new Texture2D(_graphics.GraphicsDevice, 75, 20));
            _button = new Button(Color.Black, Color.White, new Vector2(50, 150), "Exit", new Texture2D(_graphics.GraphicsDevice, 75, 20));

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
            _updateVisitor.Visit(_button);
            _updateVisitor.Visit(_textField);

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
            _drawVisitor.Visit(_button);
            _drawVisitor.Visit(_label);
            _drawVisitor.Visit(_textField);
            
            base.Draw(gameTime);
        }
    }
}
