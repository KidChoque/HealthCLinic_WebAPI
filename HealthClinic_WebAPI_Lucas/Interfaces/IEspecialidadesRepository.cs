using HealthClinic_WebAPI_Lucas.Domains;

namespace HealthClinic_WebAPI_Lucas.Interfaces
{
    public interface IEspecialidadesRepository
    {
        void Cadastrar(Especialidades especialidades);

        List<Especialidades> Listar();
    }
}
