using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Teste_AspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : ControllerBase
    {

        [HttpGet]
        [Route("Recursiva/{nElemento}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Recursiva(long nElemento)
        {
            return Ok(BLL.BLLFibonacci.FibonacciRecursiva(nElemento));
        }

        [HttpGet]
        [Route("Interativa/{nElemento}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Interativa(long nElemento)
        {
            return Ok(BLL.BLLFibonacci.FibonacciInterativa(nElemento));
        }
    }
}