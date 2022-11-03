using System;
using System.IO;
namespace Zadacha13
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Person()
            { 
                Age = 12

            };

            
        }
    }



    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address address { get; set; }

         public Person()
        {
           
        }
    }

    public class Address
    {
        public string Street { get; set; }
        public int State { get; set; }
        public string Country { get; set; }


        public override string ToString()
        {
            return $"{Street} {State} {Country}";
        }

    }
}
