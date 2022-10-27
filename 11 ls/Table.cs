﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_ls
{
    public class Table<T, U, Z>
    {
        public static List<T> St { get; set; }
        public static List<U> Su { get; set; }
        public static List<Z> Sz { get; set; }
        public Table()
        {
            St = new List<T>();
            Su = new List<U>();
            Sz = new List<Z>();
        }

        public void AddRow(T st, U su, Z sz)
        {
            St.Add(st);
            Su.Add(su);
            Sz.Add(sz);
        }
      
    }
}
