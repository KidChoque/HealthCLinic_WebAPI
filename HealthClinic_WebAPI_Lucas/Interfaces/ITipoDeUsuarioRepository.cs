using HealthClinic_WebAPI_Lucas.Domains;

namespace HealthClinic_WebAPI_Lucas.Interfaces
{
    public interface ITipoDeUsuarioRepository
    {
        void Cadastrar(TipoDeUsuario tiposUsuario);

        void Deletar(Guid id);
    }
}
