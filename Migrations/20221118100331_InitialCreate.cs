using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GestImmo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prestataires",
                columns: table => new
                {
                    PrestataireId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RaisonSociale = table.Column<string>(type: "text", nullable: false),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Prenom = table.Column<string>(type: "text", nullable: false),
                    Telephone = table.Column<string>(type: "text", nullable: false),
                    Adresse = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestataires", x => x.PrestataireId);
                });

            migrationBuilder.CreateTable(
                name: "Pret",
                columns: table => new
                {
                    PretId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    apport = table.Column<int>(type: "integer", nullable: false),
                    mensualite = table.Column<int>(type: "integer", nullable: false),
                    duree = table.Column<int>(type: "integer", nullable: false),
                    dateDebut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pret", x => x.PretId);
                });

            migrationBuilder.CreateTable(
                name: "Biens",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Valeur = table.Column<int>(type: "integer", nullable: false),
                    Adresse = table.Column<string>(type: "text", nullable: false),
                    Surface = table.Column<int>(type: "integer", nullable: false),
                    PretId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biens", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Biens_Pret_PretId",
                        column: x => x.PretId,
                        principalTable: "Pret",
                        principalColumn: "PretId");
                });

            migrationBuilder.CreateTable(
                name: "Bails",
                columns: table => new
                {
                    BailId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Loyer = table.Column<int>(type: "integer", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateFin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BienId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bails", x => x.BailId);
                    table.ForeignKey(
                        name: "FK_Bails_Biens_BienId",
                        column: x => x.BienId,
                        principalTable: "Biens",
                        principalColumn: "BienId");
                });

            migrationBuilder.CreateTable(
                name: "Box",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    BoxId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Box", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Box_Biens_BienId",
                        column: x => x.BienId,
                        principalTable: "Biens",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Habitable",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    HabitableId = table.Column<int>(type: "integer", nullable: false),
                    nbPieces = table.Column<int>(type: "integer", nullable: false),
                    nbChambres = table.Column<int>(type: "integer", nullable: false),
                    nbCaves = table.Column<int>(type: "integer", nullable: false),
                    nbParking = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitable", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Habitable_Biens_BienId",
                        column: x => x.BienId,
                        principalTable: "Biens",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interventions",
                columns: table => new
                {
                    InterventionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MontantHT = table.Column<double>(type: "double precision", nullable: false),
                    Informations = table.Column<string>(type: "text", nullable: false),
                    BienId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interventions", x => x.InterventionId);
                    table.ForeignKey(
                        name: "FK_Interventions_Biens_BienId",
                        column: x => x.BienId,
                        principalTable: "Biens",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locataires",
                columns: table => new
                {
                    LocataireId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Prenom = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Profession = table.Column<string>(type: "text", nullable: false),
                    BailId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locataires", x => x.LocataireId);
                    table.ForeignKey(
                        name: "FK_Locataires_Bails_BailId",
                        column: x => x.BailId,
                        principalTable: "Bails",
                        principalColumn: "BailId");
                });

            migrationBuilder.CreateTable(
                name: "Appartement",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    AppartementId = table.Column<int>(type: "integer", nullable: false),
                    Etage = table.Column<int>(type: "integer", nullable: false),
                    Assenceur = table.Column<bool>(type: "boolean", nullable: false),
                    ChauffCommun = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appartement", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Appartement_Habitable_BienId",
                        column: x => x.BienId,
                        principalTable: "Habitable",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maison",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    MaisonId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maison", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Maison_Habitable_BienId",
                        column: x => x.BienId,
                        principalTable: "Habitable",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterventionPrestataire",
                columns: table => new
                {
                    InterventionsInterventionId = table.Column<int>(type: "integer", nullable: false),
                    PrestatairesPrestataireId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionPrestataire", x => new { x.InterventionsInterventionId, x.PrestatairesPrestataireId });
                    table.ForeignKey(
                        name: "FK_InterventionPrestataire_Interventions_InterventionsInterven~",
                        column: x => x.InterventionsInterventionId,
                        principalTable: "Interventions",
                        principalColumn: "InterventionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterventionPrestataire_Prestataires_PrestatairesPrestatair~",
                        column: x => x.PrestatairesPrestataireId,
                        principalTable: "Prestataires",
                        principalColumn: "PrestataireId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bails_BienId",
                table: "Bails",
                column: "BienId");

            migrationBuilder.CreateIndex(
                name: "IX_Biens_PretId",
                table: "Biens",
                column: "PretId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionPrestataire_PrestatairesPrestataireId",
                table: "InterventionPrestataire",
                column: "PrestatairesPrestataireId");

            migrationBuilder.CreateIndex(
                name: "IX_Interventions_BienId",
                table: "Interventions",
                column: "BienId");

            migrationBuilder.CreateIndex(
                name: "IX_Locataires_BailId",
                table: "Locataires",
                column: "BailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appartement");

            migrationBuilder.DropTable(
                name: "Box");

            migrationBuilder.DropTable(
                name: "InterventionPrestataire");

            migrationBuilder.DropTable(
                name: "Locataires");

            migrationBuilder.DropTable(
                name: "Maison");

            migrationBuilder.DropTable(
                name: "Interventions");

            migrationBuilder.DropTable(
                name: "Prestataires");

            migrationBuilder.DropTable(
                name: "Bails");

            migrationBuilder.DropTable(
                name: "Habitable");

            migrationBuilder.DropTable(
                name: "Biens");

            migrationBuilder.DropTable(
                name: "Pret");
        }
    }
}
