using System;
using System.Collections.Generic;
using System.Text;

namespace Pr1nters
{
    [ColorAB(ConsoleColor.Green)]

    class Paragraph : IPrintable
    {
        public int Width { get; set; }
        public int Height { get; set; }     
        public string Message { get; set; }

        public Paragraph(string message,int x, int y )
        {
            Message = message;
            Width = x;
            Height = y;
           

        }
         public void Print(Action<string> resultA, Action<char> resultD, Action occur)
        {
            Console.SetCursorPosition(Width, Height);
            resultA(Message);
            Console.ResetColor();
            occur();
        }


    } 
}
