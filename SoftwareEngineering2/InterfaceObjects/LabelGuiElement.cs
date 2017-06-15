//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.Xna.Framework;
//using SoftwareEngineering2.Decorator;

//namespace SoftwareEngineering2.InterfaceObjects
//{
//    class LabelGuiElement : GuiElementDecorator
//    {

//        public string LabelText { get; set; }
//        public Vector2 Position { get; set; }
//        public Color TextColor { get; set; }

//        public LabelGuiElement(IGuiElement guiElement, string labelText, Color textColor) : base(guiElement)
//        {
//            LabelText = labelText;
//            Position = guiElement.GetPosition();
//            TextColor = textColor;
//        }
//    }
//}
