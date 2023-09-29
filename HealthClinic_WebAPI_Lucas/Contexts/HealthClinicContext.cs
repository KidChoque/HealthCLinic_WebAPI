using HealthClinic_WebAPI_Lucas.Domains;
using Microsoft.EntityFrameworkCore;

namespace HealthClinic_WebAPI_Lucas.Contexts
{
    public class HealthClinicContext : DbContext
    {
       public DbSet<TipoDeUsuario> TipoDeUsuario { get; set; } 
       public DbSet<Usuario> Usuario { get; set; } 
       public DbSet<Clinica> Clinica { get; set; } 
       public DbSet<Consultas> Consultas { get; set; } 
       public DbSet<Prontuario> Prontuario { get; set; } 
       public DbSet<Situacao> Situacao { get; set; } 
       public DbSet<Medico> Medico { get; set; } 
       public DbSet<Especialidades> Especialidades { get; set; } 
       public DbSet<Paciente> Paciente { get; set; } 
       public DbSet<Comentario> Comentario { get; set; }
       public DbSet<MedicoEspecialidade> MedicoEspecialidade { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE08-S14; Database=HealthClinic_Manha_Lucas;User Id=sa; Pwd=Senai@134; TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }    
}
