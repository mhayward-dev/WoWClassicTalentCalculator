﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using VanillaReborn.DataAccess;

namespace VanillaReborn.Migrations
{
    [DbContext(typeof(TalentCalculatorContext))]
    partial class TalentCalculatorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VanillaReborn.Models.Talent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ColumnIndex");

                    b.Property<int>("RowIndex");

                    b.Property<int?>("TalentIconId");

                    b.Property<string>("TalentName");

                    b.Property<int>("WarcraftClassSpecificationId");

                    b.HasKey("Id");

                    b.HasIndex("TalentIconId");

                    b.HasIndex("WarcraftClassSpecificationId");

                    b.ToTable("Talents");
                });

            modelBuilder.Entity("VanillaReborn.Models.TalentIcon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName");

                    b.HasKey("Id");

                    b.ToTable("TalentIcons");
                });

            modelBuilder.Entity("VanillaReborn.Models.TalentRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RankDescription");

                    b.Property<int>("RankNo");

                    b.Property<int>("TalentId");

                    b.HasKey("Id");

                    b.HasIndex("TalentId");

                    b.ToTable("TalentRanks");
                });

            modelBuilder.Entity("VanillaReborn.Models.TalentRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RequiredTalentId");

                    b.Property<int>("TalentId");

                    b.HasKey("Id");

                    b.HasIndex("TalentId")
                        .IsUnique();

                    b.ToTable("TalentRequirements");
                });

            modelBuilder.Entity("VanillaReborn.Models.WarcraftClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassName");

                    b.Property<int>("Order");

                    b.HasKey("Id");

                    b.ToTable("WarcraftClasses");
                });

            modelBuilder.Entity("VanillaReborn.Models.WarcraftClassSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SpecificationIndex");

                    b.Property<string>("SpecificationName");

                    b.Property<int>("WarcraftClassId");

                    b.HasKey("Id");

                    b.HasIndex("WarcraftClassId");

                    b.ToTable("WarcraftClassSpecifications");
                });

            modelBuilder.Entity("VanillaReborn.Models.Talent", b =>
                {
                    b.HasOne("VanillaReborn.Models.TalentIcon", "TalentIcon")
                        .WithMany()
                        .HasForeignKey("TalentIconId");

                    b.HasOne("VanillaReborn.Models.WarcraftClassSpecification")
                        .WithMany("Talents")
                        .HasForeignKey("WarcraftClassSpecificationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VanillaReborn.Models.TalentRank", b =>
                {
                    b.HasOne("VanillaReborn.Models.Talent")
                        .WithMany("TalentRanks")
                        .HasForeignKey("TalentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VanillaReborn.Models.TalentRequirement", b =>
                {
                    b.HasOne("VanillaReborn.Models.Talent")
                        .WithOne("TalentRequirement")
                        .HasForeignKey("VanillaReborn.Models.TalentRequirement", "TalentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VanillaReborn.Models.WarcraftClassSpecification", b =>
                {
                    b.HasOne("VanillaReborn.Models.WarcraftClass")
                        .WithMany("WarcraftClassSpecifications")
                        .HasForeignKey("WarcraftClassId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}