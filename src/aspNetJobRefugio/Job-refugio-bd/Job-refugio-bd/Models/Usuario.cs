using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Job_refugio_bd.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public int? IdCandidato { get; set; } // Nullable para relacionar com Candidato
        public Candidato Candidato { get; set; }

        public int? IdEmpregador { get; set; } // Nullable para relacionar com Empregador
        public Empregador Empregador { get; set; }
    }

}
