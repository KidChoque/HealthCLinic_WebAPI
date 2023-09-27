using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table(nameof(TipoDeUsuario))]
    public class TipoDeUsuario
    {
        [Key]
        public Guid IdTipoDeUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Titulo do tipo de usuário é obrigatório")]
        public string TituloTipo { get; set; }
    }
}
