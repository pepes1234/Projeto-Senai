using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Projeto_Senai.Model
{
    public partial class ExemploSenaiContext : DbContext
    {
        public ExemploSenaiContext()
        {
        }

        public ExemploSenaiContext(DbContextOptions<ExemploSenaiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Follow> Follows { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SNCCH01LABF121\\TEW_SQLEXPRESS;Initial Catalog=ExemploSenai;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Follow>(entity =>
            {
                entity.HasKey(e => e.Idsegue)
                    .HasName("PK__Follow__C1C692AC98E37B1F");

                entity.ToTable("Follow");

                entity.Property(e => e.Idsegue).HasColumnName("IDsegue");

                entity.Property(e => e.SeguidoId).HasColumnName("SeguidoID");

                entity.Property(e => e.SeguindoId).HasColumnName("SeguindoID");

                entity.HasOne(d => d.Seguido)
                    .WithMany(p => p.FollowSeguidos)
                    .HasForeignKey(d => d.SeguidoId)
                    .HasConstraintName("FK__Follow__SeguidoI__164452B1");

                entity.HasOne(d => d.Seguindo)
                    .WithMany(p => p.FollowSeguindos)
                    .HasForeignKey(d => d.SeguindoId)
                    .HasConstraintName("FK__Follow__Seguindo__15502E78");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Conteudo)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Momento).HasColumnType("datetime");

                entity.HasOne(d => d.PublicanteNavigation)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.Publicante)
                    .HasConstraintName("FK__Post__Publicante__1273C1CD");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
