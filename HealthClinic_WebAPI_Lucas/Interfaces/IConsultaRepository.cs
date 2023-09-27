using HealthClinic_WebAPI_Lucas.Domains;

namespace HealthClinic_WebAPI_Lucas.Interfaces
{
    public interface IConsultaRepository
    {
        void Cadastrar(Consultas consulta);

        void Deletar(Guid id);

        List<Consultas> Listar();

        List<Consultas> ListarDoMedico(Consultas consultas, Medico medico);

        List<Consultas> ListarDoPaciente(Consultas consultas, Paciente paciente);
    }
}
