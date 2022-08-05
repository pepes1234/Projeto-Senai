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
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-HFCS9QS\\SQLEXPRESS;Initial Catalog=ExemploSenai;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Follow>(entity =>
            {
                entity.ToTable("Follow");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.SeguidoNavigation)
                    .WithMany(p => p.FollowSeguidoNavigations)
                    .HasForeignKey(d => d.Seguido)
                    .HasConstraintName("FK__Follow__Seguido__2A4B4B5E");

                entity.HasOne(d => d.SeguindoNavigation)
                    .WithMany(p => p.FollowSeguindoNavigations)
                    .HasForeignKey(d => d.Seguindo)
                    .HasConstraintName("FK__Follow__Seguindo__29572725");
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
                    .HasConstraintName("FK__Post__Publicante__267ABA7A");
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
