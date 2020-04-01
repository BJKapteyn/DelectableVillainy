using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VillainsWebAPI.Models
{
    public partial class DelectableVillainyContext : DbContext
    {
        public DelectableVillainyContext()
        {
        }

        public DelectableVillainyContext(DbContextOptions<DelectableVillainyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Villains> Villains { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-T6VP6L6I\\SQLEXPRESS;Database=DelectableVillainy;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villains>(entity =>
            {
                entity.HasKey(e => e.VillainId)
                    .HasName("PK__villains__8D6B3A5AB7C6665B");

                entity.ToTable("villains");

                entity.Property(e => e.VillainId).HasColumnName("villain_id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Background)
                    .HasColumnName("background")
                    .HasColumnType("text");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hometown)
                    .HasColumnName("hometown")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nemesis)
                    .HasColumnName("nemesis")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WeaponOfChoice)
                    .HasColumnName("weapon_of_choice")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
