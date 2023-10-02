using HealthClinic_WebAPI_Lucas.Contexts;
using HealthClinic_WebAPI_Lucas.Domains;
using HealthClinic_WebAPI_Lucas.Interfaces;

namespace HealthClinic_WebAPI_Lucas.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public MedicoRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }
        public void Atualizar(Guid id, Medico medico)
        {
            Medico medicoBuscado = _healthClinicContext.Medico.Find(id);
            if (medicoBuscado != null)
            {
                medicoBuscado.Usuario.Email = medico.Usuario.Email;
                medicoBuscado.Usuario.Senha = medico.Usuario.Senha;
            }

            _healthClinicContext.Medico.Update(medicoBuscado);

            _healthClinicContext.SaveChanges();
        }

        public void Cadastrar(Medico medico)
        {
            _healthClinicContext.Medico.Add(medico);
            _healthClinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Medico medicoBuscado = _healthClinicContext.Medico.Find(id);
            _healthClinicContext.Medico.Remove(medicoBuscado);
            _healthClinicContext.SaveChanges();
        }

        public List<Medico> Listar()
        {
            return _healthClinicContext.Medico.
               Select(u => new Medico
               {
                   IdMedico = u.IdMedico,
                   NomeMedico = u.NomeMedico,
                   CRM = u.CRM,
                   DataNascimento = u.DataNascimento,
                   Usuario = new Usuario
                   {
                       Email = u.Usuario.Email
                   },
                   Clinica = new Clinica
                   {
                       NomeFantasia = u.Clinica.NomeFantasia,
                       Endereco = u.Clinica.Endereco,
                       HoraAbertura = u.Clinica.HoraAbertura,
                       HoraFechamento = u.Clinica.HoraFechamento,
                       Telefone= u.Clinica.Telefone

                   }
               }).ToList();
        }
    }
}
