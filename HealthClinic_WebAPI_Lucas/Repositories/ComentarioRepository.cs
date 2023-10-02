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
            Comentario comentarioBuscado = _healthClinicContext.Comentario.Find(id);

            if (comentarioBuscado != null)
            {
                comentarioBuscado.IdComentario = comentario.IdComentario;
                comentarioBuscado.Descricao = comentario.Descricao;
                comentarioBuscado.IdConsulta = comentario.IdConsulta;
                comentarioBuscado.Consultas = comentario.Consultas;
            }
            _healthClinicContext.Comentario.Update(comentarioBuscado);
            _healthClinicContext.SaveChanges();


        }

        public void Comentar(Comentario comentario)
        {
            _healthClinicContext.Comentario.Add(comentario);
            _healthClinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
             Comentario comentarioBuscado= _healthClinicContext.Comentario.Find(id);
            _healthClinicContext.Comentario.Remove(comentarioBuscado);
            _healthClinicContext.SaveChanges(); 

        }
    }
}
