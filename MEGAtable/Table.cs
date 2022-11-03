using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Text;

namespace MEGAtable
{
  public  class Table<T,U,Z>
    {
       public List<T> st { get; set; }
       public List<U> su { get; set; }
       public List<Z> sz { get; set; }

      

        public void AddRow(T ST, U SU, Z SZ)
        {
            st.Add(ST);
            su.Add(SU);
            sz.Add(SZ);
        }

        public void Print()
        {

        }

        public void Golova()
        {

        }
    }
}
