using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VillainsWebAPI.Models
{
    public partial class DelectableVillainyContext : DbContext
    {
    //warning resets any changes
    //Scaffold-DbContext "Server=LAPTOP-T6VP6L6I\SQLEXPRESS;Database=DelectableVillainy;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
    public DelectableVillainyContext()
        {
        }

        public DelectableVillainyContext(DbContextOptions<DelectableVillainyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abilities> Abilities { get; set; }
        public virtual DbSet<BaseStats> BaseStats { get; set; }
        public virtual DbSet<Villain> Villains { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DelectableVillainy;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abilities>(entity =>
            {
                entity.ToTable("abilities");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbilityName)
                    .IsRequired()
                    .HasColumnName("ability_name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.VillainId).HasColumnName("villain_id");

                entity.Property(e => e.VillainName)
                    .IsRequired()
                    .HasColumnName("villain_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Villain)
                    .WithMany(p => p.Abilities)
                    .HasForeignKey(d => d.VillainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_villain_name");
            });

            modelBuilder.Entity<BaseStats>(entity =>
            {
                entity.ToTable("base_stats");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ego).HasColumnName("ego");

                entity.Property(e => e.FightingSpirit).HasColumnName("fighting_spirit");

                entity.Property(e => e.Mass).HasColumnName("mass");

                entity.Property(e => e.SelfConfidence).HasColumnName("self_confidence");

                entity.Property(e => e.Trickery).HasColumnName("trickery");

                entity.Property(e => e.VillainId).HasColumnName("villain_id");

                entity.Property(e => e.VillainName)
                    .IsRequired()
                    .HasColumnName("villain_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Villain)
                    .WithMany(p => p.BaseStats)
                    .HasForeignKey(d => d.VillainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_villain_id");
            });

            modelBuilder.Entity<Villain>(entity =>
            {
                entity.HasKey(e => e.VillainId)
                    .HasName("PK__villains__8D6B3A5AB7C6665B");

                entity.ToTable("villains");

                entity.Property(e => e.VillainId).HasColumnName("villain_id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Background)
                    .HasColumnName("background")
                    .HasColumnType("text");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hometown)
                    .HasColumnName("hometown")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                  .IsRequired()
                  .HasColumnName("fullName")
                  .HasMaxLength(100)
                  .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
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
