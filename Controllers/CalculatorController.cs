using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        // GET api/calculator/add?a=5&b=3
        [HttpGet("add")]
        [ProducesResponseType(typeof(object), 200)]
        public IActionResult Add([FromQuery] int a, [FromQuery] int b)
        {
            int result = a + b;
            return Ok(new { operation = "add", result });
        }

        // GET api/calculator/subtract?a=5&b=3
        [HttpGet("subtract")]
        [ProducesResponseType(typeof(object), 200)]
        public IActionResult Subtract([FromQuery] int a, [FromQuery] int b)
        {
            int result = a - b;
            return Ok(new { operation = "subtract", result });
        }

        // GET api/calculator/multiply?a=5&b=3
        [HttpGet("multiply")]
        [ProducesResponseType(typeof(object), 200)]
        public IActionResult Multiply([FromQuery] int a, [FromQuery] int b)
        {
            int result = a * b;
            return Ok(new { operation = "multiply", result });
        }

        // GET api/calculator/divide?a=6&b=3
        [HttpGet("divide")]
        [ProducesResponseType(typeof(object), 200)]
        public IActionResult Divide([FromQuery] int a, [FromQuery] int b)
        {
            if (b == 0)
            {
                return BadRequest(new { error = "Division by zero is not allowed." });
            }
            int result = a / b;
            return Ok(new { operation = "divide", result });
        }

// GET api/calculator/modulus?a=6&b=3
        [HttpGet("modulus")]
        [ProducesResponseType(typeof(object), 200)]

         public IActionResult Modulus([FromQuery] int a, [FromQuery] int b)
        {
            if (b == 0)
            {
                return BadRequest(new { error = "Division by zero is not allowed." });
            }
            int result = a % b;
            return Ok(new { operation = "modulus", result });
        }

    }
}
