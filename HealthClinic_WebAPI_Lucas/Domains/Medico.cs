using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table("Medico")]
    public class Medico
    {
        [Key]

        public Guid IdMedico { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do Médico é obrigatório")]

        public string NomeMedico { get; set;}

        [Column(TypeName = "VARCHAR(12)")]
        [Required(ErrorMessage = "CRM do Médico é obrigatório")]
        [StringLength(8)]
        public string CRM { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data de Nascimento do Médico é obrigatório")]
        public DateTime DataNascimento { get; set; }

        //ref.tabela usuario FK
        [Required(ErrorMessage ="Usuario do Médico é obrigatório")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Usuario Usuario { get; set; }

        //ref.tabela Especialidades
        [Required(ErrorMessage ="Especialidade do Médico")]
        public Guid IdEspecialidades { get; set; }

        [ForeignKey(nameof(IdEspecialidades))]
        public Especialidades Especialidades { get; set; }

        //ref.tabela Clinica
        [Required(ErrorMessage = "Clinica do Médico")]
        public Guid IdClinica { get; set; }

        [ForeignKey(nameof(IdClinica))]
        public Clinica Clinica { get;set; }








    }
}
