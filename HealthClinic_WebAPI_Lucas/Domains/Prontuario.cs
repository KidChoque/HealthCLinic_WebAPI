﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table("Prontuario")]
    public class Prontuario
    {
        [Key]
        public Guid IdProntuario { get; set; }

        [Column("DescricaoExame")]
        [Required(ErrorMessage ="Descrição obrigatória")]
        public string Descricao { get; set; }
    }
}
