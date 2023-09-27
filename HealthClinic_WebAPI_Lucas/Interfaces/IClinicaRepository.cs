using HealthClinic_WebAPI_Lucas.Domains;

namespace HealthClinic_WebAPI_Lucas.Interfaces
{
    public interface IClinicaRepository
    {
        void Cadastrar(Clinica clinica);

        List<Clinica> Listar();
    }
}
