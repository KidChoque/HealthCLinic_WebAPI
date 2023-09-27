using HealthClinic_WebAPI_Lucas.Domains;

namespace HealthClinic_WebAPI_Lucas.Interfaces
{
    public interface IComentarioRepository
    {
        void Comentar(Comentario comentario);

        void AtualizarComentario(Guid id, Comentario comentario);

        void Deletar(Guid id);
    }
}
