using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table(nameof(MedicoEspecialidade))]
    public class MedicoEspecialidade
    {
        [Key]
        public Guid IdMedicoEspecialidade { get; set; } = Guid.NewGuid();

        //ref.tabela Medico
        [Required(ErrorMessage ="Medico obrigatorio")]
        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico? Medico { get; set; }

        ////ref.tabela Especialidades
        [Required(ErrorMessage = "Especialidade do Médico")]
        public Guid IdEspecialidades { get; set; }

        [ForeignKey(nameof(IdEspecialidades))]
        public Especialidades? Especialidades { get; set; }

    }
}
