using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table("Paciente")]
    public class Paciente
    {
        [Key]

        public Guid IdPaciente { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do Paciente é obrigatório")]

        public string NomePaciente { get; set; }

        [Column(TypeName = "VARCHAR(11)")]
        [Required(ErrorMessage = "CPF do Médico é obrigatório")]
        [StringLength(11)]
        public string CPF { get; set; }
    }
}
