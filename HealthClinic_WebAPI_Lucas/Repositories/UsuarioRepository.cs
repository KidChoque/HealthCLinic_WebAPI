using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;

namespace HealthClinic_WebAPI_Lucas.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario BuscarPorEMailSenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
