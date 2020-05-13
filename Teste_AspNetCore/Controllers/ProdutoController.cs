using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MODEL;

namespace Teste_AspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {

        [HttpGet]
        [Route("Consulta/{CodigoSKU}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Consulta(long CodigoSKU)
        {
            BLL.BLLProduto oBllProduto = new BLL.BLLProduto();
            
            var oConsulta = oBllProduto.Consulta(CodigoSKU);

            if (oConsulta == null)
            {
                return NotFound();
            }

            if (oConsulta.FirstOrDefault().Sku == 0)
            {
                return NotFound();
            }

            return Ok(oConsulta);
        }

        [HttpGet]
        [Route("Consulta")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Consulta()
        {
            BLL.BLLProduto oBllProduto = new BLL.BLLProduto();

            var oConsulta = oBllProduto.Consulta();

            if (oConsulta.Count() == 0)
            {
                return NotFound();
            }

            if (oConsulta.FirstOrDefault().Sku == 0)
            {
                return NotFound();
            }

            return Ok(oConsulta);
        }

        [HttpPost]
        [Route("Inclusao")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Inclusao(produto Produto)
        {
            BLL.BLLProduto oBllProduto = new BLL.BLLProduto();

            var oConsulta = oBllProduto.Consulta(Produto.Sku) ;

            var rProcessamento = oBllProduto.Inclusao(Produto);

            return Ok(rProcessamento);
        }

        [HttpDelete]
        [Route("Remover/{CodigoSKU}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Remover(long CodigoSKU)
        {
            BLL.BLLProduto oBllProduto = new BLL.BLLProduto();

            var oConsulta = oBllProduto.Consulta(CodigoSKU);

            if (oConsulta.Count() == 0)
            {
                return NotFound();
            }

            if (oConsulta.FirstOrDefault().Sku == 0)
            {
                return NotFound();
            }

            oBllProduto.Remover(CodigoSKU);

            return Ok(oBllProduto.Consulta(CodigoSKU));
        }
    }
}
