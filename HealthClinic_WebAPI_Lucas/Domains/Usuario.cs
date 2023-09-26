using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email do Usuario é obrigatório")]
        public string Email { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        [Required(ErrorMessage = "Email do Usuario é obrigatório")]
        [StringLength(20,MinimumLength = 6,ErrorMessage = "Senha de mínimo 6 e máximo de 20 caracteres")]
        public string Senha { get; set; }

        //Refereância da chave estrangeira (Tabela TipoDeUsuario)

        [Required(ErrorMessage ="TipoDeUsuario é obrigatório")]
        public Guid IdTipoDeUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]

        public TipoDeUsuario TipoDeUsuario { get; set; }
    }
}
