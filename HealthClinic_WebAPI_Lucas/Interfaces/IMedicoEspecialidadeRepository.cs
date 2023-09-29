using HealthClinic_WebAPI_Lucas.Domains;

namespace HealthClinic_WebAPI_Lucas.Interfaces
{
    public interface IMedicoEspecialidadeRepository
    {
        void Cadastrar(MedicoEspecialidade medicoEspecialidade);

        List<MedicoEspecialidade> Listar();

        void Deletar(Guid id);
    }
}
