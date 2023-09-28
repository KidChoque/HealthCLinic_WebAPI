using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace HealthClinic_WebAPI_Lucas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TipoDeUsuarioController : ControllerBase
    {
        TipoDeUsuarioRepository _tipoDeUsuarioRepository;

        TipoDeUsuarioController()
        {
            _tipoDeUsuarioRepository = new TipoDeUsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(TipoDeUsuario tipoDeUsuario)
        {
            try
            {
            _tipoDeUsuarioRepository.Cadastrar(tipoDeUsuario);
            return Ok(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
