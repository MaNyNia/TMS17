using System;
using System.Collections.Generic;
using System.Text;

namespace diagramma
{
    public class Pica 
    {
        public class Pica : Telephone
        {
            public Pica()
            {
            }

            public override bool Equals(object obj)
            {
                return obj is Pica pica &&
                       bell == pica.bell &&
                       CalculatingTheOperator == pica.CalculatingTheOperator;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(bell, CalculatingTheOperator);
            }
        }

        private readonly string _CPU;

        public string cpu;

        
       public int NumbeOfSockets { get; set; }

        public string Model { get; set; }





    }
}
