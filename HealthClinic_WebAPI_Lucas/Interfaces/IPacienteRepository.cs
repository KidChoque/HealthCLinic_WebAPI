using HealthClinic_WebAPI_Lucas.Domains;

namespace HealthClinic_WebAPI_Lucas.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);

        void Deletar(Guid id);

        List<Medico> Listar();

        void Atualizar(Guid id, Paciente paciente);
    }
}
