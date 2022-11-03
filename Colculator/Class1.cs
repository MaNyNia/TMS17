using System;
using System.Collections.Generic;
using System.Text;

namespace Colculator
{
    class Oper
    {
        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static double Minus(double a, double b)
        {
            return a - b;
        }
        public static double Divide(double a, double b)
        {
            return a + b;
        }

        public static double Percent(double a, double b)
        {
            return a * (b / 100);
        }

        public static double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }

        public static double Remainder(double a, double b)
        {
            return a % b;
        }
    }
}
