using HealthClinic_WebAPI_Lucas.Contexts;
using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;

namespace HealthClinic_WebAPI_Lucas.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public PacienteRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }

        public void Atualizar(Guid id, Paciente paciente)
        {
            Paciente pacienteBuscado = _healthClinicContext.Paciente.Find(id);
            if (pacienteBuscado != null)
            {
                pacienteBuscado.Endereco = paciente.Endereco;
                pacienteBuscado.Usuario.Email = paciente.Usuario.Email;
                pacienteBuscado.Usuario.Senha = paciente.Usuario.Senha;
            }

            _healthClinicContext.Paciente.Update(pacienteBuscado);

            _healthClinicContext.SaveChanges();
        }

        public void Cadastrar(Paciente paciente)
        {
            _healthClinicContext.Paciente.Add(paciente);
            _healthClinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Paciente pacienteBuscado = _healthClinicContext.Paciente.Find(id);
            _healthClinicContext.Paciente.Remove(pacienteBuscado);
            _healthClinicContext.SaveChanges();
        }

        public List<Paciente> Listar()
        {
           return _healthClinicContext.Paciente.
                Select(u => new Paciente
            {
                IdPaciente = u.IdPaciente,
                NomePaciente = u.NomePaciente,
                RG = u.RG,
                CPF = u.CPF,
                DataNascimento = u.DataNascimento,
                Endereco = u.Endereco,
                Usuario = new Usuario
                {
                    Email = u.Usuario.Email
                }
            }).ToList();
            
        }

    }
}
