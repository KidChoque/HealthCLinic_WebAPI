using HealthClinic_WebAPI_Lucas.Contexts;
using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;

namespace HealthClinic_WebAPI_Lucas.Repositories
{
    public class TipoDeUsuarioRepository : ITipoDeUsuarioRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public TipoDeUsuarioRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }
        public void Cadastrar(TipoDeUsuario tiposUsuario)
        {
            _healthClinicContext.TipoDeUsuario.Add(tiposUsuario);

            _healthClinicContext.SaveChanges(); 
        }

        public void Deletar(Guid id)
        {
            TipoDeUsuario tipoBuscado = _healthClinicContext.TipoDeUsuario.Find(id);

            _healthClinicContext.Remove(tipoBuscado);

            _healthClinicContext.SaveChanges();

        }
    }
}
