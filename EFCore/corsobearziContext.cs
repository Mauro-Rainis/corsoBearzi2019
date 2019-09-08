using CorsoBearziWebAppMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace CorsoBearziWebAppMvc.EFCore
{
    public partial class CorsobearziContext : DbContext
    {
        public CorsobearziContext()
        {
        }

        public CorsobearziContext(DbContextOptions<CorsobearziContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Corso> Corsi { get; set; }
        public virtual DbSet<Studente> Studenti { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Corso>(entity =>
            {
                entity.ToTable("corsi");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Anno).HasColumnName("anno");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Studente>(entity =>
            {
                entity.ToTable("studenti");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cognome)
                    .HasColumnName("cognome")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CorsoId).HasColumnName("corso_id");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Corso)
                    .WithMany(p => p.Studenti)
                    .HasForeignKey(d => d.CorsoId)
                    .HasConstraintName("FK__studenti__corso___398D8EEE");
            });
        }
    }
}
