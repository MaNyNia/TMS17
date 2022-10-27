using System;

namespace YROK12
{
    class Program
    {
       public  static void Main(string[] args)
        {
            Console.WriteLine("Imput number:");
            var imput = Console.ReadLine();
            try
            {
                ProcessImput(imput);
            }
            catch(IIE e) when (string.IsNullOrWhiteSpace(e.Message))
            {
                Console.WriteLine($"Invalid imput {e.Message}");

                throw;
            }
           
           
        }
        public static void ProcessImput(string imput)
        {

            var isNumber = int.TryParse(imput, out int nunber);

            throw new IIE("Imput must be number:");
        }

        
    }
    public class SomeClass
    {
        private string _someNumber;

        public SomeClass(string someNumber)
        {
           
        }
    }
}
