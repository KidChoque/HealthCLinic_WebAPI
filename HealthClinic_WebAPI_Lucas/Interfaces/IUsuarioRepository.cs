using HealthClinic_WebAPI_Lucas.Domains;

namespace HealthClinic_WebAPI_Lucas.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        void Deletar(Guid id);

        Usuario BuscarPorEMailSenha(string email, string senha);
    }
}
