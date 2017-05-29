using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace SoftwareEngineering2.Adapter
{
    interface IInputManager
    {
        MouseState GetMouseInput();
        KeyboardState GetKeyboardInput();
    }
}
