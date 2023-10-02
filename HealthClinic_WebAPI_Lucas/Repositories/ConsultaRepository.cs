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
            _healthClinicContext.Consultas.Add(consulta);
        }

        public void Deletar(Guid id)
        {
            Consultas consultaBuscada = _healthClinicContext.Consultas.Find(id);
            _healthClinicContext.Consultas.Remove(consultaBuscada);

        }

        public List<Consultas> Listar()
        {          
            return(_healthClinicContext.Consultas.ToList());
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
