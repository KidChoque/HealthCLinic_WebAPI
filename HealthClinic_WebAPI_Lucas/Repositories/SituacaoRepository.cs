using HealthClinic_WebAPI_Lucas.Contexts;
using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;

namespace HealthClinic_WebAPI_Lucas.Repositories
{
    public class SituacaoRepository : ISituacaoRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public SituacaoRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }
        public void Cadastrar(Situacao situacao)
        {
            throw new NotImplementedException();
        }
    }
}
