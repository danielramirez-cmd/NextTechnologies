using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NextTechnologies.Modelos;

namespace NextTechnologies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumeroController : ControllerBase
    {

        [HttpGet]
        public IActionResult ExtraerNumero(int num)
        {
            try
            {
                NumeroFaltanteModel numeros = new NumeroFaltanteModel(); // instancia al modelo para acceder a los metodos
                numeros.ExtraerNum(num); // llama al metodo ExtraerNum

                // Calcular el número faltante
                int faltante = numeros.NumFaltante(); // llama al metodo NumFaltante

                return Ok(new
                {
                    numero_extraido = num,
                    numero_faltante = faltante,
                    Lista_restante = numeros.NumerosRestantes() // llama al metodo NumerosRestantes
                });

            }

            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }







    } // fin controller
} // fin namespace
