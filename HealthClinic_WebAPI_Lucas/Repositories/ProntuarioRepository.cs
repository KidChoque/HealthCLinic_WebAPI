using HealthClinic_WebAPI_Lucas.Contexts;
using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;

namespace HealthClinic_WebAPI_Lucas.Repositories
{
    public class ProntuarioRepository : IProntuarioRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public ProntuarioRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }
        public void Adicionar(Prontuario prontuario)
        {
            throw new NotImplementedException();
        }
    }
}
