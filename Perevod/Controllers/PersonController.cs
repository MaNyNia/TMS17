using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Perevod.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private static readonly string[] Adrs= new[]
      {
            "Michael", "Vasya", "Katia", "Max", "Kirill", "Vasilisa", "Valera", "Sonya", "Danya", "Petya"
        };

        private static readonly string[] str = new[]
        {
            "Timiryazev", "Pushkin", "Mayskaya", "Bangalore", "Midovaya"
        };

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<Address> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Address
            {
                Date = DateTime.Now.AddDays(index),
                Street = str[rng.Next(str.Length)],
                House = rng.Next(1, 143),
                Recipient = Adrs[rng.Next(Adrs.Length)]
            })
            .ToArray();

        }

        }
}
