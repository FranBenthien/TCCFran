using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace back.Model
{
    public partial class WebSiteViagemContext : DbContext
    {
        public WebSiteViagemContext()
        {
        }

        public WebSiteViagemContext(DbContextOptions<WebSiteViagemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Formulario> Formularios { get; set; } = null!;
        public virtual DbSet<Token> Tokens { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-ENK8D0BG;Initial Catalog=WebSiteViagem;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Formulario>(entity =>
            {
                entity.ToTable("Formulario");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accommodation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate).HasColumnType("date");

                entity.Property(e => e.AttractionAmount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureDate).HasColumnType("date");

                entity.Property(e => e.Food)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FoodAmount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HostingAmount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeAttraction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeFood)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeHosting)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypeTransport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Formularios)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Formulari__UserI__29572725");
            });

            modelBuilder.Entity<Token>(entity =>
            {
                entity.ToTable("token");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Value).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__token__UserID__267ABA7A");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Userpass).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
