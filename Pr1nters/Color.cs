using System;
using System.Collections.Generic;
using System.Text;

namespace Pr1nters
{
   public class ColorAB : Attribute
    {
        public ConsoleColor ShapeColor { get; set; }
        public ColorAB(ConsoleColor color)
        {
            ShapeColor = color;
        }
    }
}
