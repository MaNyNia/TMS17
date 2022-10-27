using System;
using System.Collections.Generic;
using System.Text;

namespace Pr1nters
{
  public abstract class Shape : IPrintable
    {
        public Action<string> WriteA { get; set; }
        public Action<char> WriteD { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Side { get; set; }
        public char Symbol { get; set; }

        public Shape(char symbol, int x, int y, int side)
        {
            Symbol = symbol;
            Width = x;
            Height = y;
            Side = side;
        }
        public abstract void Print(Action<string> resultA, Action<char> resultD, Action occur);
    }

        
}
