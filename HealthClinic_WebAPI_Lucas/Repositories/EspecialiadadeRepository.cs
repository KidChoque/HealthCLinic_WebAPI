using HealthClinic_WebAPI_Lucas.Contexts;
using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;

namespace HealthClinic_WebAPI_Lucas.Repositories
{
    public class EspecialiadadeRepository : IEspecialidadesRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public EspecialiadadeRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }
        public void Cadastrar(Especialidades especialidades)
        {
            throw new NotImplementedException();
        }

        public List<Especialidades> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
