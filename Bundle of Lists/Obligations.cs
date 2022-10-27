using System;
using System.Collections.Generic;
using System.Text;

namespace Bundle_of_Lists
{
   public class Obligations<T>
    {
        public T Item { get; set; }
        public Obligations(T item)
        {
            Item = item;
        }
    }
}
