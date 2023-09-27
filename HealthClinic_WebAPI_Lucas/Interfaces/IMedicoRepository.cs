using HealthClinic_WebAPI_Lucas.Domains;

namespace HealthClinic_WebAPI_Lucas.Interfaces
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);

        void Deletar(Guid id);

        List<Medico> Listar();

        void Atualizar(Guid id, Medico medico);
    }
}
