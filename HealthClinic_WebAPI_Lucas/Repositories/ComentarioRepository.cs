using HealthClinic_WebAPI_Lucas.Contexts;
using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;

namespace HealthClinic_WebAPI_Lucas.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public ComentarioRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }
        public void AtualizarComentario(Guid id, Comentario comentario)
        {
            throw new NotImplementedException();
        }

        public void Comentar(Comentario comentario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
