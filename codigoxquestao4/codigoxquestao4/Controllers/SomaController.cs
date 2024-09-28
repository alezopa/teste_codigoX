using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace codigoxquestao4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SomaController : ControllerBase
    {
       

        private readonly ILogger<SomaController> _logger;

        public SomaController(ILogger<SomaController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public async Task<ActionResult<ResultadoResponse>> Get(string num1,string num2)
        {

            
            if (!num1.All(char.IsDigit)  || !num2.All(char.IsDigit))
            {
                return BadRequest("Um dos paramêtros não é inteiro!");
            }


            var teste = new ResultadoResponse();
            teste.Result = Convert.ToInt32(num1) + Convert.ToInt32(num2 );
  
            return Ok(JsonConvert.SerializeObject(teste));
        }
    }
}