using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine
{
    //TODO this class
    //Handles all input for all game states
    public class InputManager
    {
        public Dictionary<Keys, Input> BindingsKeyboard;
        public Dictionary<Buttons, Input> BindingsController;

        public List<Keys> ActiveKeys;
        public List<Buttons> ActiveButtons;

        public bool InputsChanged { get; private set; }

        private int _lastInputs;
        private int _currentInputs;
        private int _changedInputs;

        readonly int LR = (int)(Input.Left | Input.Right);
        readonly int UD = (int)(Input.Up | Input.Down);

        public InputManager()
        {
            BindingsKeyboard = new Dictionary<Keys, Input>();
            BindingsController = new Dictionary<Buttons, Input>();

            ActiveKeys = new List<Keys> { Keys.W, Keys.S, Keys.A, Keys.D };
            ActiveButtons = new List<Buttons>(); //TODO

            _lastInputs = 0;
            _currentInputs = 0;
            _changedInputs = 0;

            BindDefaults();
        }

        public void Tick()
        {
            foreach(Keys key in ActiveKeys)
            {
                if (Keyboard.GetState().IsKeyDown(key))
                    _currentInputs |= (int)BindingsKeyboard[key];
                else
                    _currentInputs &= ~(int)BindingsKeyboard[key];
            }

            //TODO 
            //foreach(Buttons button in ActiveButtons)
            //{
            //    if (GamePad.GetState(???).IsButtonDown(button))
            //        _currentInputs |= (int)BindingsController[button];
            //    else
            //        _currentInputs &= ~(int)BindingsController[button];
            //}

            CleanInputs();

            if (_currentInputs != _lastInputs)
            {
                InputsChanged = true;
                _changedInputs = _lastInputs ^ _currentInputs;
                _lastInputs = _currentInputs;
            }
            else
            {
                InputsChanged = false;
                _changedInputs = 0;
            }
        }

        //TODO: This stuff
        public void BindDefaults()
        {
            BindingsKeyboard.Clear();
            BindingsKeyboard.Add(Keys.W, Input.Up);
            BindingsKeyboard.Add(Keys.S, Input.Down);
            BindingsKeyboard.Add(Keys.A, Input.Left);
            BindingsKeyboard.Add(Keys.D, Input.Right);

            //BindingsKeyboard.Add(Keys.I, Input.Right);
            //BindingsKeyboard.Add(Keys.O, Input.Right);
            //BindingsKeyboard.Add(Keys.K, Input.Right);
            //BindingsKeyboard.Add(Keys.L, Input.Right);
        }

        //Cleans out any "illegal" inputs like left + right
        //or up + down
        private void CleanInputs()
        {
            if ((_currentInputs & LR) == LR)
                _currentInputs ^= LR;


            if ((_currentInputs & UD) == UD)
                _currentInputs ^= UD;
        }

        public bool IsDown(Input flag)
        {
            return (_currentInputs & (int)flag) > 0;
        }

        public bool IsUp(Input flag)
        {
            return (_currentInputs & (int)flag) == 0;
        }

        public bool WasPressed(Input flag)
        {
            return ((int)flag & _changedInputs & _currentInputs) > 0;
        }

        public bool WasReleased(Input flag)
        {
            return ((int)flag & _changedInputs & _currentInputs) == 0;
        }

        public bool WasPressedOrReleased(Input flag)
        {
            return ((int)flag & _changedInputs) > 0;
        }
    }
}
