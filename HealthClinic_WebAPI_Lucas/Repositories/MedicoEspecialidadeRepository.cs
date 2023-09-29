using HealthClinic_WebAPI_Lucas.Contexts;
using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace HealthClinic_WebAPI_Lucas.Repositories
{
    public class MedicoEspecialidadeRepository : IMedicoEspecialidadeRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public MedicoEspecialidadeRepository() 
        {
            _healthClinicContext = new HealthClinicContext();
        }

        public void Cadastrar(MedicoEspecialidade medicoEspecialidade)
        {
           _healthClinicContext.MedicoEspecialidade.Add(medicoEspecialidade);
        }

        public void Deletar(Guid id)
        {
            MedicoEspecialidade medicoEspecialidadeBuscado = _healthClinicContext.MedicoEspecialidade.Find(id);

            _healthClinicContext.MedicoEspecialidade.Remove(medicoEspecialidadeBuscado);

            _healthClinicContext.SaveChanges();

        }

        public List<MedicoEspecialidade> Listar()
        {

            return (_healthClinicContext.MedicoEspecialidade.ToList());
        }
    }
}
