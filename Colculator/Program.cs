



using System;

namespace Lesson_4
{
    class Program
    {



        static void Main(string[] args)
        {

            do
            {
                Console.Clear();

                double num1 = 0;
                double num2 = 0;
                double result = 0;
                string oper = "+";

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.WriteLine("Enter an options: ");
                Console.WriteLine("1.+ ");
                Console.WriteLine("2.- ");
                Console.WriteLine("3.* ");
                Console.WriteLine("4./ ");
                Console.WriteLine("5.% ");
                Console.Write("Your option: ");

                oper = Console.ReadLine();


                Console.WriteLine("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                

                Console.WriteLine("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());




                switch (oper)
                {
                    case "1":
                        Plus(num1, num2);
                        break;
                    case "2":
                        Minus(num1, num2);

                        break;
                    case "4":
                        Division(num1, num2);
                        while (num2 == 0)
                        {
                            Console.WriteLine("Enter a non-zero divisor: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine($"Your result:{num1 / num2}");
                        break;
                    case "3":
                        Multiplication(num1, num2);
                        break;
                    case "5":
                        Percent(num1, num2);
                        break;
                    case "f":
                        Full(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Wrong operation");
                        break;

                }

                static void Plus(double a, double b)
                {
                    Console.WriteLine($"Your result:{a + b}");

                }

                static void Minus(double a, double b)
                {
                    Console.WriteLine($"Your result: {a - b}");
                }

                static void Multiplication(double a, double b)
                {

                    Console.WriteLine($"Your result: {a * b}");

                }

                static void Division(double a, double b)
                {
                    Console.WriteLine($"Your result: {a / b}");
                }

                static void Percent(double a, double b)
                {
                    Console.WriteLine($"Your result:{a % b}");
                }
                static void Full(double a, double b)
                {
                    Console.WriteLine($"Your result: {a + b}");
                }
                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine("Would you like to continue?(Y =yes , N =no):  ");
                Console.WriteLine("\n");

            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("----");
            Console.WriteLine("Bye!");
            Console.ReadKey();

        }
        private static double DoOperation(double num1, double num2, string oper)
        {
            throw new NotImplementedException();
        }

    }
          
}




    
