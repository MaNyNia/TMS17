using System;
using System.Collections.Generic;

namespace tst
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Tuple<int, string, string>> authors =
            new[]
            {
              Tuple.Create(1, "Isaac", "Asimov"),
               Tuple.Create(2, "Robert", "Heinlein"),
                  Tuple.Create(3, "Frank", "Herbert"),
                    Tuple.Create(4, "Aldous", "Huxley"),
            };

            Console.WriteLine(authors.ToStringTable(
              new[] { "Id", "First Name", "Surname" },
              a => a.Item1, a => a.Item2, a => a.Item3));

        }
    }
}
