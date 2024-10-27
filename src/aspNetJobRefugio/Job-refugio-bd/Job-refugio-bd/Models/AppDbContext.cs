using Microsoft.EntityFrameworkCore;

namespace Job_refugio_bd.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }  
        
        public DbSet<Empregador> Empregadores { get; set; }

        public DbSet<Vaga> Vagas { get; set; }

        public DbSet<Candidato> Candidatos { get; set; }

        public DbSet<Curriculo> Curriculos { get; set; }

        public DbSet<Inscrito> Inscritos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Candidato)
                .WithOne()
                .HasForeignKey<Usuario>(u => u.IdCandidato);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Empregador)
                .WithOne()
                .HasForeignKey<Usuario>(u => u.IdEmpregador);
        }
    }
}
