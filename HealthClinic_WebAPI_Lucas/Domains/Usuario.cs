using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table(nameof(Usuario))]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email do Usuario é obrigatório")]
        public string? Email { get; set; }


        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "Senha do Usuario é obrigatória")]
        [StringLength(60,MinimumLength = 6,ErrorMessage = "Senha de mínimo 6 e máximo de 20 caracteres")]
        public string? Senha { get; set; }

        //Refereância da chave estrangeira (Tabela TipoDeUsuario)

        [Required(ErrorMessage ="TipoDeUsuario é obrigatório")]
        public Guid IdTipoDeUsuario { get; set; }

        [ForeignKey(nameof(IdTipoDeUsuario))]

        public TipoDeUsuario? TipoDeUsuario { get; set; }
    }
}
