using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Job_refugio_bd.Models
{
    [Table("Vaga")]
    public class Vaga
    {
        [Key]
        public int Id { get; set; }

        public int EmpregadorId { get; set; } //chave estrangeira//

        [ForeignKey("EmpregadorId")]
        public Empregador Empregador { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do cargo")]
        public string NomeCargo { get; set; }

        public string Local { get; set; }

        public string MetodoContratacao { get; set; }

        public bool VagaPCD { get; set; }

        [Required(ErrorMessage = "Obrigatório informar regime de trabalho")]
        public string RegimeTrabalho { get; set; }

        public string SobreEmpresa { get; set; }

        [Required(ErrorMessage = "Obrigatório descrever as características da vaga")]

        public string DescVaga { get; set; }

        public string RequisitosQualificacao { get; set; }

        public string InfoAdicional { get; set; }

        public List<Inscrito> Inscritos { get; set; }

        public DateOnly DataPublicacao { get; set; }

    }
}
