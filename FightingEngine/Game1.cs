using FightingEngine.Classes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace FightingEngine
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        RenderTarget2D renderTarget;

        List<RenderableObject> RenderObjects;

        Character char1;
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            RenderObjects = new List<RenderableObject>();
        }

        protected override void Initialize()
        {

            TargetElapsedTime = TimeSpan.FromSeconds(1f / 60.0f);
            IsFixedTimeStep = true;

            base.Initialize();

            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            graphics.ApplyChanges();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //TODO CLEAN UP
            List<Texture2D> texs = new List<Texture2D>();
            List<string> strings = new List<string>() { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10" };
            foreach (string s in strings)
                texs.Add(Content.Load<Texture2D>("RyuIdle/" + s));
            List<int> lengths = new List<int>() { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3};

            char1 = new Character(texs, lengths);
            RenderObjects.Add(char1.Animator);
            //END TODO

            renderTarget = new RenderTarget2D(GraphicsDevice, 1920, 1080);

        }

        protected override void UnloadContent()
        {
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            char1.Tick();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            foreach (RenderableObject obj in RenderObjects)
                obj.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
