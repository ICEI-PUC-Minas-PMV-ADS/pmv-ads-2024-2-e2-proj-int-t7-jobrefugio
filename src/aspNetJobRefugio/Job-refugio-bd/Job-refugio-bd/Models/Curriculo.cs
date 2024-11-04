using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Job_refugio_bd.Models
{
    [Table("Curriculo")]
    public class Curriculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatótio informar o nome de Usuário")]
        [Display(Name = "Nome")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "Obrigatótio informar a Cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Obrigatótio informar a Formação Academica")]
        [Display(Name = "Formação Acadêmica")]
        public string FormAcad { get; set; }

        [Required(ErrorMessage = "Obrigatótio informar o Resumo das Qualificações")]
        public string ResumoQualific { get; set; }

        [Display(Name = "Principais Realizações")]
        public string PrincRealiza { get; set; }

        public string ExpProf { get; set; }

        [Required(ErrorMessage = "Obrigatótio informar o Objetivo Profissional")]
        public string ObjProf { get; set; }

        public string CursosComplIdioma { get; set; }

        public int CandidatoId { get; set; }

        public Candidato Candidato { get; set; }
    }
}
