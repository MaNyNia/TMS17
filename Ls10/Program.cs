using System;

namespace Ls10
{
    delegate void SomeMetdot();

    class Program
    {
        private static SomeMetdot _someMetdot;


        static void Main(string[] args)
        {
            _someMetdot = SomeMetdot;
        }

        static void callDelegate(SomeMetdot metdotCall)
        {
            metdotCall();
        }
        static void SomeMetdot()
        {
            Console.WriteLine("ASDASD")
        }
    }

}
