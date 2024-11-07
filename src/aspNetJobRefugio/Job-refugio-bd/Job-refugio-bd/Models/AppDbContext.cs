using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

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

            base.OnModelCreating(modelBuilder);

            // Configurar o relacionamento muitos-para-muitos
            modelBuilder.Entity<Inscrito>()
                .HasOne(i => i.Candidato)
                .WithMany(c => c.Inscritos)
                .HasForeignKey(i => i.CandidatoId);

            modelBuilder.Entity<Inscrito>()
                .HasOne(i => i.Vaga)
                .WithMany(v => v.Inscritos)
                .HasForeignKey(i => i.VagaId);

            // Impor restrição de unicidade para CandidatoId e VagaId
            modelBuilder.Entity<Inscrito>()
                .HasIndex(i => new { i.CandidatoId, i.VagaId })
                .IsUnique();

        }

        internal async Task AddClaimAsync(object user, Claim claim)
        {
            throw new NotImplementedException();
        }

        internal async Task CreateAsync(IdentityUser user, object password)
        {
            throw new NotImplementedException();
        }
    }
}
