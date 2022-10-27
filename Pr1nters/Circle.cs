using System;
using System.Collections.Generic;
using System.Text;

namespace Pr1nters
{
    [ColorAB(ConsoleColor.Yellow)]

    public class Circle : Shape
    {

        public Circle(char symbol, int x , int y, int side) : base(symbol, x , y , side)
        {
        }
        public override void Print(Action<string> resultA, Action<char> resultD, Action occur)
        {
            for (int i = Side; i >= -Side; i--)
            {
                Console.SetCursorPosition(Height,Width);
                for (int j = Side; j >= -Side; j--)
                {
                    if (Convert.ToInt32(Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2))) == Side)
                    {
                       resultD(Symbol);
                    }
                    else
                    {
                       resultA(" ");
                    }

                }

                resultA("\n");
                Width++;
            }
            Console.ResetColor();
           occur();

        }
    }
    
}
