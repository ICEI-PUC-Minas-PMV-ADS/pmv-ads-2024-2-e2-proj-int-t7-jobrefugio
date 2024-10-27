using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Job_refugio_bd.Models
{
    [Table("Candidato")]
    public class Candidato
    {
        [Key]
        public int IdCandidato { get; set; }

        [Display(Name = "Nome")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "Favor Informar a data")]
        [Display(Name = "Data Nascimento ")]
        public DateOnly DataNascimento { get; set; }

        [Required(ErrorMessage = "Favor Informar a Nacionalidade")]
        public string Nacionalidade { get; set; }
        public string Endereco { get; set; }

        [Display(Name = "CPF ou Passaporte ")]
        public string CPF { get; set; }
        public string Celular { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o E-mail!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Compare("Senha")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public Curriculo Curriculo { get; set; }

        public List<Inscrito> Inscritos { get; set; }

    }
}
