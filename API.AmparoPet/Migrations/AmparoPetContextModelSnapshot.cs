﻿// <auto-generated />
using System;
using API.AmparoPet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.AmparoPet.Migrations
{
    [DbContext(typeof(AmparoPetContext))]
    partial class AmparoPetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.AmparoPet.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressID"), 1L, 1);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressID");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("API.AmparoPet.Models.CardVaccine", b =>
                {
                    b.Property<int>("CardVaccineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardVaccineID"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CardVaccineID");

                    b.ToTable("CardVaccine", (string)null);
                });

            modelBuilder.Entity("API.AmparoPet.Models.Carer", b =>
                {
                    b.Property<int>("CarerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarerID"), 1L, 1);

                    b.Property<int?>("AddressID")
                        .HasColumnType("int");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CarerID");

                    b.HasIndex("AddressID");

                    b.ToTable("Carer", (string)null);
                });

            modelBuilder.Entity("API.AmparoPet.Models.Pet", b =>
                {
                    b.Property<int>("PetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PetID"), 1L, 1);

                    b.Property<int?>("CardVaccineID")
                        .HasColumnType("int");

                    b.Property<int?>("CarerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PetID");

                    b.HasIndex("CardVaccineID");

                    b.HasIndex("CarerID");

                    b.ToTable("Pet", (string)null);
                });

            modelBuilder.Entity("API.AmparoPet.Models.Vaccine", b =>
                {
                    b.Property<int>("VaccineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VaccineId"), 1L, 1);

                    b.Property<DateTime>("AdministeredDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CardVaccineID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("VaccineId");

                    b.HasIndex("CardVaccineID");

                    b.ToTable("Vaccine", (string)null);
                });

            modelBuilder.Entity("API.AmparoPet.Models.Carer", b =>
                {
                    b.HasOne("API.AmparoPet.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("API.AmparoPet.Models.Pet", b =>
                {
                    b.HasOne("API.AmparoPet.Models.CardVaccine", "CardVaccine")
                        .WithMany()
                        .HasForeignKey("CardVaccineID");

                    b.HasOne("API.AmparoPet.Models.Carer", "Carer")
                        .WithMany("Pets")
                        .HasForeignKey("CarerID");

                    b.Navigation("CardVaccine");

                    b.Navigation("Carer");
                });

            modelBuilder.Entity("API.AmparoPet.Models.Vaccine", b =>
                {
                    b.HasOne("API.AmparoPet.Models.CardVaccine", "CardVaccine")
                        .WithMany("Vaccines")
                        .HasForeignKey("CardVaccineID");

                    b.Navigation("CardVaccine");
                });

            modelBuilder.Entity("API.AmparoPet.Models.CardVaccine", b =>
                {
                    b.Navigation("Vaccines");
                });

            modelBuilder.Entity("API.AmparoPet.Models.Carer", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
