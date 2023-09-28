using HealthClinic_WebAPI_Lucas.Contexts;
using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;

namespace HealthClinic_WebAPI_Lucas.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public ClinicaRepository()
        {
            _healthClinicContext= new HealthClinicContext();
        }

        public void Cadastrar(Clinica clinica)
        {
            throw new NotImplementedException();
        }

        public List<Clinica> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
