using HealthClinic_WebAPI_Lucas.Contexts;
using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;

namespace HealthClinic_WebAPI_Lucas.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public ConsultaRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }
        public void Cadastrar(Consultas consulta)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Consultas> Listar()
        {
            throw new NotImplementedException();
        }

        public List<Consultas> ListarDoMedico(Consultas consultas, Medico medico)
        {
            throw new NotImplementedException();
        }

        public List<Consultas> ListarDoPaciente(Consultas consultas, Paciente paciente)
        {
            throw new NotImplementedException();
        }
    }
}
