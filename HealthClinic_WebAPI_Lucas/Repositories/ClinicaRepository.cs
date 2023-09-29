using HealthClinic_WebAPI_Lucas.Contexts;
using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace HealthClinic_WebAPI_Lucas.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public ClinicaRepository()
        {
            _healthClinicContext= new HealthClinicContext();
        }

        public void Cadastrar(Clinica clinica)
        {
            _healthClinicContext.Clinica.Add(clinica);
        }

        public List<Clinica> Listar()
        {
            return (_healthClinicContext.Clinica.ToList());
           
        }
    }
}
