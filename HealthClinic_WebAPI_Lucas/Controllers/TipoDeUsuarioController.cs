using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;
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

        //Nota: Ocorreu um erro 500 no construtor causada pela instância incorreta  "TipoDeUsuario"  da interface ITipoDeUsuario 

        private readonly ITipoDeUsuarioRepository _tipoDeUsuarioRepository;

        public TipoDeUsuarioController()
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

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _tipoDeUsuarioRepository.Deletar(id);
                return Ok(200);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            
        }

    }
}
