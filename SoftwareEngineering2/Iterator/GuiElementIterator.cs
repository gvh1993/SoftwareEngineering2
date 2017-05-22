using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareEngineering2.InterfaceObjects;

namespace SoftwareEngineering2.Iterator
{
    class GuiElementIterator : IIterator
    {
        private List<IGuiElement> _guiElements;
        private int position;
        public GuiElementIterator(List<IGuiElement> guiElements)
        {
            _guiElements = guiElements;
        }
        public bool HasNext()
        {
            if (position < _guiElements.Count())
            {
                return true;
            }
            return false;
        }

        public IGuiElement Next()
        {
            IGuiElement guiElement = _guiElements[position];
            position++;
            return guiElement;
        }
    }
}
