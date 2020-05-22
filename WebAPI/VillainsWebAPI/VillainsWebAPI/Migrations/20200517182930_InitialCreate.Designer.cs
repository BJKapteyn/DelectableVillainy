﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VillainsWebAPI.Models;

namespace VillainsWebAPI.Migrations
{
    [DbContext(typeof(DelectableVillainyContext))]
    [Migration("20200517182930_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.3.20181.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VillainsWebAPI.Models.Abilities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AbilityName")
                        .IsRequired()
                        .HasColumnName("ability_name")
                        .HasColumnType("varchar(80)")
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<short?>("Level")
                        .HasColumnName("level")
                        .HasColumnType("smallint");

                    b.Property<int>("VillainId")
                        .HasColumnName("villain_id")
                        .HasColumnType("int");

                    b.Property<string>("VillainName")
                        .IsRequired()
                        .HasColumnName("villain_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("VillainId");

                    b.ToTable("abilities");
                });

            modelBuilder.Entity("VillainsWebAPI.Models.BaseStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ego")
                        .HasColumnName("ego")
                        .HasColumnType("int");

                    b.Property<int>("FightingSpirit")
                        .HasColumnName("fighting_spirit")
                        .HasColumnType("int");

                    b.Property<int>("Mass")
                        .HasColumnName("mass")
                        .HasColumnType("int");

                    b.Property<int>("SelfConfidence")
                        .HasColumnName("self_confidence")
                        .HasColumnType("int");

                    b.Property<int>("Trickery")
                        .HasColumnName("trickery")
                        .HasColumnType("int");

                    b.Property<int>("VillainId")
                        .HasColumnName("villain_id")
                        .HasColumnType("int");

                    b.Property<string>("VillainName")
                        .IsRequired()
                        .HasColumnName("villain_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("VillainId");

                    b.ToTable("base_stats");
                });

            modelBuilder.Entity("VillainsWebAPI.Models.Villain", b =>
                {
                    b.Property<int>("VillainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("villain_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("Age")
                        .HasColumnName("age")
                        .HasColumnType("smallint");

                    b.Property<string>("Background")
                        .HasColumnName("background")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("firstName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnName("fullName")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Gender")
                        .HasColumnName("gender")
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("Hometown")
                        .HasColumnName("hometown")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("lastName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Nemesis")
                        .HasColumnName("nemesis")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("WeaponOfChoice")
                        .HasColumnName("weapon_of_choice")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("VillainId")
                        .HasName("PK__villains__8D6B3A5AB7C6665B");

                    b.ToTable("villains");
                });

            modelBuilder.Entity("VillainsWebAPI.Models.Abilities", b =>
                {
                    b.HasOne("VillainsWebAPI.Models.Villain", "Villain")
                        .WithMany("Abilities")
                        .HasForeignKey("VillainId")
                        .HasConstraintName("FK_villain_name")
                        .IsRequired();
                });

            modelBuilder.Entity("VillainsWebAPI.Models.BaseStats", b =>
                {
                    b.HasOne("VillainsWebAPI.Models.Villain", "Villain")
                        .WithMany("BaseStats")
                        .HasForeignKey("VillainId")
                        .HasConstraintName("FK_villain_id")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
