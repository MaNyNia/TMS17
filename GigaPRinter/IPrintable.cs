    using System;
using System.Collections.Generic;
using System.Text;

namespace GiGaPrinter
{
    interface IPrintable
    {
         try
            {
                Console.Write("Введите количество строк пирамиды: ");
                int lineCount = int.Parse(Console.ReadLine());
        ConsolePyramid(lineCount);

        Console.WriteLine();
                Console.Write("Введите количество пирамид: ");
                int pyrCount = int.Parse(Console.ReadLine());
        ConsolePyramidBunch(pyrCount);
    }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
Console.WriteLine();
Console.Write("Нажмите любую клавишу для выхода ...");
Console.ReadKey(true);
    }
}
