using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiServico.Controllers
{
    [Route("/")]
    [ApiController]
    public class PrincipalController : ControllerBase
    {

        [HttpGet]
        public IActionResult Principal() 
        {
            var resultado = new { situacao = "Ok", mensagem = "API Serviço" };
            return Ok(resultado);
        }

        [HttpGet("/Autor")]
        public IActionResult Get()
        {
            var dados = new { nome = "Camila Lobato", 
                telefone = "(19) 98835-3897)", 
                email = "camilalmoreira9@gmail.com" };

            return Ok(dados);
        }

    }


}
