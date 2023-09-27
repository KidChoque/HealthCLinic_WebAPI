using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table(nameof(Especialidades))]
    public class Especialidades
    {
        [Key]
        public Guid IdEspecialidades { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Titulo das especialidades é obrigatório")]

        public string TituloEspecialidades { get; set; }

    }
}
