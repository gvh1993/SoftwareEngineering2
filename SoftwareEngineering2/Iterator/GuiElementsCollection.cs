using SoftwareEngineering2.InterfaceObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering2.Iterator
{
    class GuiElementCollection : IGuiElementCollection
    {
        private List<IGuiElement> _guiElements;


        public GuiElementCollection()
        {
            _guiElements = new List<IGuiElement>();
        }

        public void AddGuiElement(IGuiElement guiElement)
        {
            _guiElements.Add(guiElement);
        }

        public void RemoveGuiElement(IGuiElement guiElement)
        {
            _guiElements.Remove(guiElement);
        }

        public IIterator Iterator()
        {
            return new GuiElementIterator(_guiElements);
        }
    }
}
