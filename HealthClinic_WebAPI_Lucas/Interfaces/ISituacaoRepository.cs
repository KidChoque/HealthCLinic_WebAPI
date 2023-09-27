using HealthClinic_WebAPI_Lucas.Domains;

namespace HealthClinic_WebAPI_Lucas.Interfaces
{
    public interface ISituacaoRepository
    {
        void Cadastrar(Situacao situacao);
    }
}
