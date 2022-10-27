using System;
using System.Collections.Generic;
using System.Text;

namespace Pr1nters
{
    [ColorAB(ConsoleColor.Gray)]

    class Triangle : Shape
    {
        public Triangle(char symbol, int y, int x, int side) : base(symbol, y, x, side)
        {
        }
        public override void Print(Action<string> resultA, Action<char> resultD, Action occur)
        {
            for (int i = 0; i < Side; i++)
            {
                Console.SetCursorPosition(Height + Side - i, Width + i + 1);
                for (int j = 0; j <= i * 2; j++)
                {
                    if (j == 0 || j == 2 * i || i == Side - 1)
                    {
                        resultD(Symbol);
                    }
                    else
                    {
                        resultA(" ");
                    }
                }
                resultA("\n");
            }
            Console.ResetColor();
            occur();
        }
    }
}
