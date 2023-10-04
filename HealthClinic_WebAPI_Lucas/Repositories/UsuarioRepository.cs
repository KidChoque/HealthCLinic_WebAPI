using HealthClinic_WebAPI_Lucas.Contexts;
using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;
using HealthClinic_WebAPI_Lucas.Utils;

namespace HealthClinic_WebAPI_Lucas.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public UsuarioRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }
        public Usuario BuscarPorEMailSenha(string email, string senha)
        {
            Usuario usuarioBuscado = _healthClinicContext.Usuario.Select(u => new Usuario
            {
                IdUsuario = u.IdUsuario,
                Email = u.Email,
                TipoDeUsuario = new TipoDeUsuario
                {
                    IdTipoDeUsuario = u.IdTipoDeUsuario,
                    TituloTipo = u.TipoDeUsuario.TituloTipo,
                }

            }).FirstOrDefault(u => u.Email == email);

            if (usuarioBuscado != null)
            {
                bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                if (confere)
                {
                    return usuarioBuscado;
                }
            }
            return null!;
        }

        public void Cadastrar(Usuario usuario)
        {
            usuario.Senha = Criptografia.GerarHash(usuario.Senha!);
            //Senha que virá da controller será criptografada

            _healthClinicContext.Usuario.Add(usuario);
            _healthClinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Usuario usuarioBuscado = _healthClinicContext.Usuario.Find(id);

            _healthClinicContext.Usuario.Remove(usuarioBuscado);

            _healthClinicContext.SaveChanges();
        }
    }
}
