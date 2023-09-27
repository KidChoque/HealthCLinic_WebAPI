using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table(nameof(Paciente))]
    public class Paciente
    {
        [Key] 
        public Guid IdPaciente { get; set; } = Guid.NewGuid();


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do Paciente é obrigatório")]

        public string NomePaciente { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage ="Data de nascimento do pasciente obrigatória")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"YYYY-MM-DD")]
        public TimeSpan DataNascimento { get; set; }

        [Column(TypeName = "VARCHAR(11)")]
        [Required(ErrorMessage = "CPF do Paciente é obrigatório")]
        [StringLength(11,ErrorMessage = " Os 11 caracteres são obrigatórios")]
        public string CPF { get; set; }

        [Column(TypeName = "VARCHAR(7)")]
        [Required(ErrorMessage = "RG do Paciente é obrigatório")]
        [StringLength(7,ErrorMessage =" Os 7 caracteres são obrigatórios")]
        public string RG { get; set; }


        [Column(TypeName = "VARCHAR(256)")]
        [Required(ErrorMessage = "Endereço do Paciente é obrigatório")]
        public string Endereco { get; set; }

        //ref.tabela usuario FK
        [Required(ErrorMessage = "Usuario do Médico é obrigatório")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Usuario Usuario { get; set; }
    }
}
