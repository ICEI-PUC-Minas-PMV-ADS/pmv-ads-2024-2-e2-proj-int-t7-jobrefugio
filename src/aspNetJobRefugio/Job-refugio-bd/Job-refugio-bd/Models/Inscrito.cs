using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Job_refugio_bd.Models
{
    [Table("Inscrito")]
    public class Inscrito
    {
        [Key]
        public int Idinscricao { get; set; }

        [Required(ErrorMessage = "Favor Informar a data")]
        [Display(Name = "Data Inscrição ")]
        public DateTime DataInscricao { get; set; }

        [Required(ErrorMessage = "Favor Informar a data")]
        [Display(Name = "Status Inscrição")]
        public string StatusInscricao { get; set; }

        public int CandidatoId { get; set; }

        public Candidato Candidato { get; set; }

        public int VagaId { get; set; }

        public Vaga Vaga { get; set; }
    }
}
