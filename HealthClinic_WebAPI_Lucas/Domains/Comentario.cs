using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table(nameof(Comentario))]
    public class Comentario
    {
        [Key]
        public Guid IdComentario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "TEXT")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Indique a consulta a ser comentada")]
        public Guid IdConsulta { get; set; }

        [ForeignKey(nameof(IdConsulta))]
        public Consultas Consultas { get; set; }

    }
}
