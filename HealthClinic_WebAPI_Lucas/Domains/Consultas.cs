using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_WebAPI_Lucas.Domains
{
    [Table("Consultas")]
    public class Consultas
    {
        [Key] 
        public Guid IdConsulta { get; set; } = Guid.NewGuid();

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data de Agendamento é obrigatória")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"YYYY-MM-DD")]
        public TimeSpan DataAgendamento { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "Horário do Agendamento é obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"hh\:mm")]
        public TimeSpan HorarioAgendamento { get; set; }

        //ref.tabela Paciente
        [Required(ErrorMessage = "Paciente a ser consultado é obrigatório")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente Paciente { get; set; }

        //ref.tabela Médico
        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico Medico { get; set; }

        //ref.tabela Situacao

        [Required(ErrorMessage ="Confirmação da situação da consulta é obrigatória")]
        public Guid IdSituacao { get; set; }

        [ForeignKey(nameof(IdSituacao))]
        public Situacao Situacao { get; set; }

    }
}
