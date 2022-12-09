﻿// <auto-generated />
using System;
using GestImmo.Data.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GestImmo.Migrations
{
    [DbContext(typeof(GestImmoContext))]
    partial class GestImmoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GestImmo.Models.Bail", b =>
                {
                    b.Property<int>("BailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BailId"));

                    b.Property<int?>("BienId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Loyer")
                        .HasColumnType("integer");

                    b.HasKey("BailId");

                    b.HasIndex("BienId");

                    b.ToTable("Bails");
                });

            modelBuilder.Entity("GestImmo.Models.Bien", b =>
                {
                    b.Property<int>("BienId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BienId"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PretId")
                        .HasColumnType("integer");

                    b.Property<int>("Surface")
                        .HasColumnType("integer");

                    b.Property<int>("Valeur")
                        .HasColumnType("integer");

                    b.HasKey("BienId");

                    b.HasIndex("PretId");

                    b.ToTable("Biens");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("GestImmo.Models.Intervention", b =>
                {
                    b.Property<int>("InterventionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("InterventionId"));

                    b.Property<int>("BienId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Informations")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("MontantHT")
                        .HasColumnType("double precision");

                    b.HasKey("InterventionId");

                    b.HasIndex("BienId");

                    b.ToTable("Interventions");
                });

            modelBuilder.Entity("GestImmo.Models.Locataire", b =>
                {
                    b.Property<int>("LocataireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LocataireId"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<int?>("BailId")
                        .HasColumnType("integer");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LocataireId");

                    b.HasIndex("BailId");

                    b.ToTable("Locataires");
                });

            modelBuilder.Entity("GestImmo.Models.Prestataire", b =>
                {
                    b.Property<int>("PrestataireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PrestataireId"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RaisonSociale")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PrestataireId");

                    b.ToTable("Prestataires");
                });

            modelBuilder.Entity("GestImmo.Models.Pret", b =>
                {
                    b.Property<int>("PretId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PretId"));

                    b.Property<int>("apport")
                        .HasColumnType("integer");

                    b.Property<DateTime>("dateDebut")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("duree")
                        .HasColumnType("integer");

                    b.Property<int>("mensualite")
                        .HasColumnType("integer");

                    b.HasKey("PretId");

                    b.ToTable("Pret");
                });

            modelBuilder.Entity("InterventionPrestataire", b =>
                {
                    b.Property<int>("InterventionsInterventionId")
                        .HasColumnType("integer");

                    b.Property<int>("PrestatairesPrestataireId")
                        .HasColumnType("integer");

                    b.HasKey("InterventionsInterventionId", "PrestatairesPrestataireId");

                    b.HasIndex("PrestatairesPrestataireId");

                    b.ToTable("InterventionPrestataire");
                });

            modelBuilder.Entity("GestImmo.Models.Box", b =>
                {
                    b.HasBaseType("GestImmo.Models.Bien");

                    b.Property<int>("BoxId")
                        .HasColumnType("integer");

                    b.ToTable("Box", (string)null);
                });

            modelBuilder.Entity("GestImmo.Models.Habitable", b =>
                {
                    b.HasBaseType("GestImmo.Models.Bien");

                    b.Property<int>("HabitableId")
                        .HasColumnType("integer");

                    b.Property<int>("nbCaves")
                        .HasColumnType("integer");

                    b.Property<int>("nbChambres")
                        .HasColumnType("integer");

                    b.Property<int>("nbParking")
                        .HasColumnType("integer");

                    b.Property<int>("nbPieces")
                        .HasColumnType("integer");

                    b.ToTable("Habitable", (string)null);
                });

            modelBuilder.Entity("GestImmo.Models.Appartement", b =>
                {
                    b.HasBaseType("GestImmo.Models.Habitable");

                    b.Property<int>("AppartementId")
                        .HasColumnType("integer");

                    b.Property<bool>("Assenceur")
                        .HasColumnType("boolean");

                    b.Property<bool>("ChauffCommun")
                        .HasColumnType("boolean");

                    b.Property<int>("Etage")
                        .HasColumnType("integer");

                    b.ToTable("Appartement", (string)null);
                });

            modelBuilder.Entity("GestImmo.Models.Maison", b =>
                {
                    b.HasBaseType("GestImmo.Models.Habitable");

                    b.Property<int>("MaisonId")
                        .HasColumnType("integer");

                    b.ToTable("Maison", (string)null);
                });

            modelBuilder.Entity("GestImmo.Models.Bail", b =>
                {
                    b.HasOne("GestImmo.Models.Bien", null)
                        .WithMany("Bails")
                        .HasForeignKey("BienId");
                });

            modelBuilder.Entity("GestImmo.Models.Bien", b =>
                {
                    b.HasOne("GestImmo.Models.Pret", "Pret")
                        .WithMany()
                        .HasForeignKey("PretId");

                    b.Navigation("Pret");
                });

            modelBuilder.Entity("GestImmo.Models.Intervention", b =>
                {
                    b.HasOne("GestImmo.Models.Bien", "Bien")
                        .WithMany("Interventions")
                        .HasForeignKey("BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bien");
                });

            modelBuilder.Entity("GestImmo.Models.Locataire", b =>
                {
                    b.HasOne("GestImmo.Models.Bail", null)
                        .WithMany("Locataires")
                        .HasForeignKey("BailId");
                });

            modelBuilder.Entity("InterventionPrestataire", b =>
                {
                    b.HasOne("GestImmo.Models.Intervention", null)
                        .WithMany()
                        .HasForeignKey("InterventionsInterventionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestImmo.Models.Prestataire", null)
                        .WithMany()
                        .HasForeignKey("PrestatairesPrestataireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestImmo.Models.Box", b =>
                {
                    b.HasOne("GestImmo.Models.Bien", null)
                        .WithOne()
                        .HasForeignKey("GestImmo.Models.Box", "BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestImmo.Models.Habitable", b =>
                {
                    b.HasOne("GestImmo.Models.Bien", null)
                        .WithOne()
                        .HasForeignKey("GestImmo.Models.Habitable", "BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestImmo.Models.Appartement", b =>
                {
                    b.HasOne("GestImmo.Models.Habitable", null)
                        .WithOne()
                        .HasForeignKey("GestImmo.Models.Appartement", "BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestImmo.Models.Maison", b =>
                {
                    b.HasOne("GestImmo.Models.Habitable", null)
                        .WithOne()
                        .HasForeignKey("GestImmo.Models.Maison", "BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestImmo.Models.Bail", b =>
                {
                    b.Navigation("Locataires");
                });

            modelBuilder.Entity("GestImmo.Models.Bien", b =>
                {
                    b.Navigation("Bails");

                    b.Navigation("Interventions");
                });
#pragma warning restore 612, 618
        }
    }
}