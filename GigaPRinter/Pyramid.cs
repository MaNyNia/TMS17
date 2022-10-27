using System;
using System.Collections.Generic;
using System.Text;

namespace GiGaPrinter
{
    class Pyramid
    {
        private static void ConsolePyramid(int rowCount)
        {
            int consoleCenter = Console.WindowWidth / 2;
            for (int row = 0; row < rowCount; row++)
                Console.WriteLine(
                    "".PadLeft(1 + row * 2, '^').PadLeft(consoleCenter + row, ' '));
        }
    }
}
