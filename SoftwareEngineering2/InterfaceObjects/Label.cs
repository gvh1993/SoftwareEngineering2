//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.Xna.Framework;
//using SoftwareEngineering2.Visitor;
//using Microsoft.Xna.Framework.Graphics;
//using SoftwareEngineering2.Decorator;

//namespace SoftwareEngineering2.InterfaceObjects
//{
//    class Label : IGuiElement
//    {
//        public LabelGuiElement LabelGuiElement { get; set; }

        
//        //public string LabelText { get; set; }
//        //public Vector2 Position { get; set; }
//        //public Color TextColor { get; set; }

//        public Label(LabelGuiElement decorator)
//        {
//            LabelGuiElement = decorator;
//            //LabelText = labelText;
//            //Position = position;
//            //TextColor = textColor;
//        }



//        public void Accept(IVisitor visitor)
//        {
//            visitor.Visit(this);
//        }
//    }
//}
