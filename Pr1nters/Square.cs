using System;
using System.Collections.Generic;
using System.Text;

namespace Pr1nters
{
    [ColorAB(ConsoleColor.Red)]

    public class Square : Shape
    {
        public Square(char symbol, int y, int x, int side) : base(symbol, y, x, side)
        {
        }
        public override void Print(Action<string> resultA, Action<char> resultD, Action occur)
        {
            for (int i = 0; i < Side; i++)
            {
                Console.SetCursorPosition(Height, Width);
                for (int j = 0; j < Side; j++)
                {
                    if (i == 0 || i == Side - 1)
                    {
                        resultD(Symbol);
                    }
                    else
                    {
                        if (j == 0 || j == Side - 1)
                        {
                           resultD(Symbol);
                        }
                        else
                        {
                            resultA(" ");
                        }
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
