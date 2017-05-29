using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace SoftwareEngineering2.Adapter
{
    class InputManager : IInputManager
    {
        public MouseState GetMouseInput()
        {
            return new MouseState();
        }

        public KeyboardState GetKeyboardInput()
        {
            return new KeyboardState();
        }
    }
}
