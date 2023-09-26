using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table("Clinica")]
    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome Fantasia da Clínica obrigatória")]
        public string NomeFantasia { get; set; }
        
        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "CNPJ da Clínica é obrigatória")]
        public string CNPJ { get; set; }

        [Column(TypeName = "VARCHAR(256)")]
        [Required(ErrorMessage = "Razão social da Clínica é obrigatória")]
        public string RazaoSocial { get; set; }

        [Column(TypeName = "T"]
        public TimeSpan HoraAbertura  { get; set; }



        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Endereço obrigatório ")]
        public string Endereco { get; set; }

        [Column(TypeName = "VARCHAR(9)")]
        [Required(ErrorMessage = "Telefone obriigatório")]
        public string Telefone { get; set; }



        
    }
}
