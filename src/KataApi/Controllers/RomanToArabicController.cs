using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KataNumber;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;

namespace KataApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RomanToArabicController : ControllerBase
    {
        private readonly RomanToArabic _converter;

        public RomanToArabicController(RomanToArabic converter)
        {
            _converter = converter;
        }

        [HttpGet]
        public IActionResult Get(string number)
        {
            string value = _converter.Convert(number);
            return Ok(value);
        }
    }
}
