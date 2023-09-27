using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table(nameof(Situacao))]
    [Index(nameof(Titulo), IsUnique = true)]

    public class Situacao
    {
        [Key]
        public Guid IdSituacao { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Titulo { get; set; }

        
    }
}
