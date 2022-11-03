using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hw_do_4ga
{

    public class Decerializer : IDecerializer
    {
        private readonly IConfiguration _config;
        public List<Camera> Decerialize(string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                var json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Camera>>(json);
            }
        }
    }

}
