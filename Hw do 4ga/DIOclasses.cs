using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hw_do_4ga
{
    public interface IDecerializer
    {
        public List<Camera> Decerialize(string path);
    }

}
