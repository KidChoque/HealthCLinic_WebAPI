using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table("Tipo de Usuario")]
    public class TipoDeUsuario
    {
        [Key]
        public Guid IdTipoDeUsuario { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Titulo do tipo de usuário é obrigatório")]
        public string TituloTipo { get; set; }
    }
}
