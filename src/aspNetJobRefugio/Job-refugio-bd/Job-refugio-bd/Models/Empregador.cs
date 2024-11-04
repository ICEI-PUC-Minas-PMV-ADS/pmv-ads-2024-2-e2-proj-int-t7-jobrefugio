using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Job_refugio_bd.Models
{
    [Table("Empregador")]
    public class Empregador
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome da empresa!")]
        public string NomeEmpresa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Cnpj da empresa!")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome fantasia!")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Obrigatório informar uma descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o endereço!")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Cep!")]
        public int Cep { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o telefone de contato!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o E-mail!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public List<Vaga> Vagas { get; set; }
    }
}
