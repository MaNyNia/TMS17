using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vot
{
    public class HomeServise : IHomeService 
    {
        public string SaySomething()
        {
            return "Hello Di";
        }
    }

    public interface IHomeService
    {
        string SaySomething();
    }
}
