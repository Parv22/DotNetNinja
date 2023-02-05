using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _23_WebAPI.Models;

namespace _23_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiplyController : ControllerBase
    {
        // POST: api/Multiply
        [HttpPost]
        public IActionResult Post(NumInput data)
        {
            int total = data.Num1 * data.Num2;
            return Ok(total);        
        }
    }
}