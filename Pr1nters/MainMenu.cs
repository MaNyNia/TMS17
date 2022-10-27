using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Pr1nters
{
    public abstract class MainMenu
    {
        public static object[] Requests(string answers)
        {
            Console.WriteLine("Enter X:");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Y:");
            var y = Convert.ToInt32(Console.ReadLine());

            object[] option;
            if (answers != "Paragraph")
            {
                Console.WriteLine("Enter the symbol :");
                var symbol = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter the length :");
                var side = Convert.ToInt32(Console.ReadLine());

                option = new object[] { symbol, x, y, side };
            }
            else
            {
                Console.WriteLine("Enter text");
                var message = Console.ReadLine();
                option = new object[] { message, x, y };
            }
            return option;
        }

        public static void Menu()
        {

            Action occur = Menu;
            Action<string> resultA = (str) => Console.Write(str);
            Action<char> resultD = (ch) => Console.Write(ch);
            object[] optionMet = new object[] { resultA, resultD, occur };

            Console.WriteLine("Choose a shape: \n||" + "1.Square \n||" + "|| 2.Circle \n||" + "||| 3.Triangle \n||" + "|| 4.Paragraph \n||" + "5.Exit");
            Console.WriteLine();

            string answers = Console.ReadLine();
            if (answers == "Exit")
            {

                return;
            }
            Console.WriteLine();
            object[] optionRip = Requests(answers);



        }
    }
}
