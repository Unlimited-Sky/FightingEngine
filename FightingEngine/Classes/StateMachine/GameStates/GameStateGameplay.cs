using FightingEngine.StateMachine;
using FightingEngine;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace FightingEngine.StateMachine
{
    public class GameStateGameplay : AState
    { 
        Character char1;

        public GameStateGameplay(FightingEngine game) : base(game) { }

        public override void Draw()
        {
            _game.spriteBatch.Begin();       
            char1.Draw(_game.spriteBatch);
            _game.spriteBatch.End();
        }

        public override void Enter()
        {
            //TODO CLEAN UP
            List<Texture2D> texs = new List<Texture2D>();
            List<string> strings = new List<string>() { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10" };
            foreach (string s in strings)
                texs.Add(_game.Content.Load<Texture2D>("Ryu/Idle/" + s));
            List<int> lengths = new List<int>() { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };

            char1 = new Character(texs, lengths);
            //END TODO
        }

        public override void Exit()
        {
            
        }

        public override void Tick()
        {
            char1.Tick();
        }
    }
}
