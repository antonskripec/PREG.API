using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PREG.API.Models;

namespace PREG.API.Migrations
{
    [DbContext(typeof(PregDbContext))]
    partial class PregDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PREG.API.Models.ApprovalProcedure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<DateTime?>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("ApprovalProcedures");
                });

            modelBuilder.Entity("PREG.API.Models.Distributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<DateTime?>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Distributors");
                });

            modelBuilder.Entity("PREG.API.Models.DosageForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<DateTime?>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("DosageForms");
                });

            modelBuilder.Entity("PREG.API.Models.ErrandType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<int>("ErrandTypeGroupId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<DateTime?>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ErrandTypeGroupId");

                    b.ToTable("ErrandTypes");
                });

            modelBuilder.Entity("PREG.API.Models.ErrandTypeGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<DateTime?>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("ErrandTypeGroups");
                });

            modelBuilder.Entity("PREG.API.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<DateTime?>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("PREG.API.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<DateTime?>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("PREG.API.Models.Phase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<int>("PhaseGroupId");

                    b.Property<DateTime?>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("PhaseGroupId");

                    b.ToTable("Phases");
                });

            modelBuilder.Entity("PREG.API.Models.PhaseGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<DateTime?>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("PhaseGroups");
                });

            modelBuilder.Entity("PREG.API.Models.ErrandType", b =>
                {
                    b.HasOne("PREG.API.Models.ErrandTypeGroup", "ErrandTypeGroup")
                        .WithMany()
                        .HasForeignKey("ErrandTypeGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PREG.API.Models.Phase", b =>
                {
                    b.HasOne("PREG.API.Models.PhaseGroup", "PhaseGroup")
                        .WithMany()
                        .HasForeignKey("PhaseGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
