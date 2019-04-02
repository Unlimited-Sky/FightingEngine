using FightingEngine;
using FightingEngine.StateMachine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace FightingEngine
{
    public class FightingEngine : Game
    {
        GraphicsDeviceManager graphics;
        RenderTarget2D renderTarget;

        public SpriteBatch spriteBatch;
        public InputManager inputManager;

        StateMachine<AGameState> GameStateMachine;
        
        public FightingEngine()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {

            TargetElapsedTime = TimeSpan.FromSeconds(1f / 60.0f);
            IsFixedTimeStep = true;

            base.Initialize();

            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            graphics.ApplyChanges();

            inputManager = new InputManager();

            //TODO Change this to "Splash Screen / Main Menu stuff"
            GameStateMachine = new StateMachine<AGameState>();
            GameStateMachine.PushState(new GameStateGameplay(this));
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            renderTarget = new RenderTarget2D(GraphicsDevice, 1920, 1080);
        }

        protected override void UnloadContent()
        {
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            inputManager.Tick();

            GameStateMachine.Tick();
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            GameStateMachine.Draw();
        
        }
    }
}
