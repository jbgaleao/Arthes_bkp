using Arthes.DATA.Models.ModelsEntity;

using Microsoft.EntityFrameworkCore;

namespace Arthes.DATA.DataContext
{
    public partial class ArthesContext : DbContext
    {
        public ArthesContext()
        {
        }

        public ArthesContext(DbContextOptions<ArthesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Receita> Receita { get; set; }
        public virtual DbSet<Revista> Revista { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receita>(entity =>
            {
                entity.Property(e => e.Altura).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Revista)
                    .WithMany(p => p.Receita)
                    .HasForeignKey(d => d.RevistaId)
                    .HasConstraintName("FK_Receita_Revista");
            });

            modelBuilder.Entity<Revista>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AnoEdicao)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Tema)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}