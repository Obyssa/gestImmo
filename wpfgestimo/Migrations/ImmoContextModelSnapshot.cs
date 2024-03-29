﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using wpfgestimo.Data;

#nullable disable

namespace wpfgestimo.Migrations
{
    [DbContext(typeof(ImmoContext))]
    partial class ImmoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

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

            modelBuilder.Entity("wpfgestimo.Bail", b =>
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

            modelBuilder.Entity("wpfgestimo.Bien", b =>
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
                });

            modelBuilder.Entity("wpfgestimo.Intervention", b =>
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

            modelBuilder.Entity("wpfgestimo.Locataire", b =>
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

            modelBuilder.Entity("wpfgestimo.Prestataire", b =>
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

            modelBuilder.Entity("wpfgestimo.Pret", b =>
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

                    b.ToTable("Prets");
                });

            modelBuilder.Entity("wpfgestimo.Box", b =>
                {
                    b.HasBaseType("wpfgestimo.Bien");

                    b.Property<int>("BoxId")
                        .HasColumnType("integer");

                    b.ToTable("Box", (string)null);
                });

            modelBuilder.Entity("wpfgestimo.Habitable", b =>
                {
                    b.HasBaseType("wpfgestimo.Bien");

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

            modelBuilder.Entity("wpfgestimo.Appartement", b =>
                {
                    b.HasBaseType("wpfgestimo.Habitable");

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

            modelBuilder.Entity("wpfgestimo.Maison", b =>
                {
                    b.HasBaseType("wpfgestimo.Habitable");

                    b.Property<int>("MaisonId")
                        .HasColumnType("integer");

                    b.ToTable("Maison", (string)null);
                });

            modelBuilder.Entity("InterventionPrestataire", b =>
                {
                    b.HasOne("wpfgestimo.Intervention", null)
                        .WithMany()
                        .HasForeignKey("InterventionsInterventionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wpfgestimo.Prestataire", null)
                        .WithMany()
                        .HasForeignKey("PrestatairesPrestataireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wpfgestimo.Bail", b =>
                {
                    b.HasOne("wpfgestimo.Bien", null)
                        .WithMany("Bails")
                        .HasForeignKey("BienId");
                });

            modelBuilder.Entity("wpfgestimo.Bien", b =>
                {
                    b.HasOne("wpfgestimo.Pret", "Pret")
                        .WithMany()
                        .HasForeignKey("PretId");

                    b.Navigation("Pret");
                });

            modelBuilder.Entity("wpfgestimo.Intervention", b =>
                {
                    b.HasOne("wpfgestimo.Bien", "Bien")
                        .WithMany("Interventions")
                        .HasForeignKey("BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bien");
                });

            modelBuilder.Entity("wpfgestimo.Locataire", b =>
                {
                    b.HasOne("wpfgestimo.Bail", null)
                        .WithMany("Locataires")
                        .HasForeignKey("BailId");
                });

            modelBuilder.Entity("wpfgestimo.Box", b =>
                {
                    b.HasOne("wpfgestimo.Bien", null)
                        .WithOne()
                        .HasForeignKey("wpfgestimo.Box", "BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wpfgestimo.Habitable", b =>
                {
                    b.HasOne("wpfgestimo.Bien", null)
                        .WithOne()
                        .HasForeignKey("wpfgestimo.Habitable", "BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wpfgestimo.Appartement", b =>
                {
                    b.HasOne("wpfgestimo.Habitable", null)
                        .WithOne()
                        .HasForeignKey("wpfgestimo.Appartement", "BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wpfgestimo.Maison", b =>
                {
                    b.HasOne("wpfgestimo.Habitable", null)
                        .WithOne()
                        .HasForeignKey("wpfgestimo.Maison", "BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wpfgestimo.Bail", b =>
                {
                    b.Navigation("Locataires");
                });

            modelBuilder.Entity("wpfgestimo.Bien", b =>
                {
                    b.Navigation("Bails");

                    b.Navigation("Interventions");
                });
#pragma warning restore 612, 618
        }
    }
}
