using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;
using HealthClinic_WebAPI_Lucas.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic_WebAPI_Lucas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]

        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);
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
                _usuarioRepository.Deletar(id);
                return Ok(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
    
          
        }
    }
}
