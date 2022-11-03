using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace Yr13
{
    class Program
    {
        private static readonly object SeekOriginal;

        static void Main(string[] args)
        {
            var obj = new Person()
            {
                
                Age = 12
                
            };

            var jsonString = JsonConvert.SerializeObject(obj);
            Console.WriteLine(jsonString);

            var deObj = JsonConvert.DeserializeObject<Person>(jsonString);
            Console.WriteLine(jsonString);
        }

        public class Person
        {
            public int Age { get; set; }

            [NonSerialized] public bool Gender;

            private string _name;

            public Adress adress { get; set; }

            public Person()
            {
                _name = "Nick";
            }

            public override string ToString()
            {
                return $"{Age} {_name}";
            }

            public class Adress
            {
                public string Street { get; set; }
                public string Country { get; set; }
                public string City { get; set; }
            }

            public void GetObjDate()
            {

            }
        }
    }
}
