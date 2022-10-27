using System;
using System.Collections.Generic;
using System.Text;

namespace Pr1nters
{
  public interface IPrintable
    {
       public abstract void Print(Action<string> resultA, Action<char> resultD, Action occur);     
    }
}
