using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hw_do_4ga.Controller
{
    


    [ApiController]
    [Route("сhapter")]
    public class StartController : ControllerBase
    {
        private readonly IDecerializer _decerializer;
        private readonly IConfiguration _config;

        public StartController(IDecerializer decerializer, IConfiguration config)
        {
            _decerializer = decerializer;
            _config = config;
        }


       [HttpGet("home")]
       public string GetHome()
        {
            return _config.GetValue<string>("DataFile");
        }


        [HttpGet("showcase")]
        public string GetAssortment()
        {
            var path = _config.GetValue<string>("DataFile");

            using (StreamReader streamReader = new StreamReader(path))
            {
                return streamReader.ReadToEnd();
            }
        }


        [HttpGet("transfer")]
        public List<Camera> GetTransfer()
        {
            var path = _config.GetValue<string>("DataFile");

            return _decerializer.Decerialize(path);
        }
    }
}
