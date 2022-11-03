using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vot.Controller
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        private readonly  IHomeService _homeService;
        private readonly IConfiguration _config;
        private readonly IConfiguration _param;
        private readonly IConfiguration _camera;



        public HomeController(IHomeService homeService , IConfiguration config, IConfiguration param, IConfiguration camera)
        {
            _homeService = homeService;
            _config = config;
            _param = param;
            _camera = camera;
        }


        [HttpGet("say")]
        public string Say()
        {
            return _homeService.SaySomething();          
        }

        [HttpGet("htp-code ")]
        public string GetCode()
        {
            return _param.GetValue<string>("ParamCode");
        }
        
        [HttpGet("secret-key")]
        public string GetKey()
        {
            return _config.GetValue<string>("SecretKey");
        }

        [HttpGet("Head")]
        public int GetScore()
        {
            return _camera.GetValue<int>("Camera");
        }
    }
}
