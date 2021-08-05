using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Porject_scool.Domains;

#nullable disable

namespace Porject_scool.Contexts
{
    public partial class ProjInicialContext : DbContext
    {
        public ProjInicialContext()
        {
        }

        public ProjInicialContext(DbContextOptions<ProjInicialContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Entrada> Entradas { get; set; }
        public virtual DbSet<Equipamento> Equipamentos { get; set; }
        public virtual DbSet<Sala> Salas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-RSQ1KON; Initial Catalog= Projeto_Inicial; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Entrada>(entity =>
            {
                entity.HasKey(e => e.IdEntrada)
                    .HasName("PK__Entradas__19943CE0CC704872");

                entity.Property(e => e.IdEntrada).HasColumnName("idEntrada");

                entity.Property(e => e.DataEntrada)
                    .HasColumnType("datetime")
                    .HasColumnName("dataEntrada");

                entity.Property(e => e.DataSaida)
                    .HasColumnType("datetime")
                    .HasColumnName("dataSaida");

                entity.Property(e => e.IdEquipamento).HasColumnName("idEquipamento");

                entity.Property(e => e.IdSala).HasColumnName("idSala");

                entity.HasOne(d => d.IdEquipamentoNavigation)
                    .WithMany(p => p.Entrada)
                    .HasForeignKey(d => d.IdEquipamento)
                    .HasConstraintName("FK__Entradas__idEqui__2E1BDC42");

                entity.HasOne(d => d.IdSalaNavigation)
                    .WithMany(p => p.Entrada)
                    .HasForeignKey(d => d.IdSala)
                    .HasConstraintName("FK__Entradas__idSala__2D27B809");
            });

            modelBuilder.Entity<Equipamento>(entity =>
            {
                entity.HasKey(e => e.IdEquipamento)
                    .HasName("PK__Equipame__75940D345894B037");

                entity.HasIndex(e => e.NumPatrimonio, "UQ__Equipame__3A20CB69A046B06C")
                    .IsUnique();

                entity.Property(e => e.IdEquipamento).HasColumnName("idEquipamento");

                entity.Property(e => e.Ativo).HasColumnName("ativo");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("descricao");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("marca");

                entity.Property(e => e.NumPatrimonio).HasColumnName("numPatrimonio");

                entity.Property(e => e.NumSerie)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("numSerie")
                    .IsFixedLength(true);

                entity.Property(e => e.TipoEquipamento)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tipoEquipamento");
            });

            modelBuilder.Entity<Sala>(entity =>
            {
                entity.HasKey(e => e.IdSala)
                    .HasName("PK__Salas__C4AEB19C149F26D6");

                entity.HasIndex(e => e.Nome, "UQ__Salas__6F71C0DC43E967C7")
                    .IsUnique();

                entity.Property(e => e.IdSala).HasColumnName("idSala");

                entity.Property(e => e.Andar).HasColumnName("andar");

                entity.Property(e => e.Cep).HasColumnName("cep");

                entity.Property(e => e.Instituicao)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("instituicao");

                entity.Property(e => e.MetragemSala).HasColumnName("metragemSala");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Telefone).HasColumnName("telefone");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__645723A6879F7CC6");

                entity.HasIndex(e => e.Email, "UQ__Usuarios__AB6E6164B5D22E93")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("senha");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
