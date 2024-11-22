using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Job_refugio_bd.Models.Vaga;

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

        public ICollection<Inscrito> Inscritos { get; set; }

        public DateOnly DataPublicacao { get; set; }

        public StatusInscricaoEnum StatusAtual { get; set; }

        public static implicit operator Vaga(StatusInscricao v)
        {
            throw new NotImplementedException();
        }
    }

    public enum StatusInscricaoEnum
    {
        INSCRITO = 1,
        EM_ANALISE = 2,
        ENTREVISTA = 3,
        ADMISSAO = 4
    }
    public class StatusInscricao
    {
        public int Id { get; set; }
        public StatusInscricaoEnum StatusAtual { get; set; }
    }
}
