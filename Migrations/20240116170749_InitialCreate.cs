using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auteur",
                columns: table => new
                {
                    id_a = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_a = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenom_a = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_naissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_p = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auteur", x => x.id_a);
                });

            migrationBuilder.CreateTable(
                name: "Confirmation",
                columns: table => new
                {
                    id_confirmation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_confirmation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status_confirmation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_emprunt = table.Column<int>(type: "int", nullable: true),
                    id_employe = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Confirmation", x => x.id_confirmation);
                });

            migrationBuilder.CreateTable(
                name: "Employe",
                columns: table => new
                {
                    id_employe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_employe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenom_e = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Passworde = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employe", x => x.id_employe);
                });

            migrationBuilder.CreateTable(
                name: "Emprunt",
                columns: table => new
                {
                    id_emp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_emprunt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_delai = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_inscrit = table.Column<int>(type: "int", nullable: true),
                    id_l = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprunt", x => x.id_emp);
                });

            migrationBuilder.CreateTable(
                name: "Inscrit",
                columns: table => new
                {
                    id_I = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_i = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenom_i = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_naissance = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ville = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Passworde = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscrit", x => x.id_I);
                });

            migrationBuilder.CreateTable(
                name: "Livre",
                columns: table => new
                {
                    id_l = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titre_l = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    resume_l = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_auteur = table.Column<int>(type: "int", nullable: true),
                    fichier = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    images = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    annee_l = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livre", x => x.id_l);
                });

            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    id_p = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_p = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.id_p);
                });

            migrationBuilder.CreateTable(
                name: "TypeLivre",
                columns: table => new
                {
                    id_t = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle_T = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeLivre", x => x.id_t);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auteur");

            migrationBuilder.DropTable(
                name: "Confirmation");

            migrationBuilder.DropTable(
                name: "Employe");

            migrationBuilder.DropTable(
                name: "Emprunt");

            migrationBuilder.DropTable(
                name: "Inscrit");

            migrationBuilder.DropTable(
                name: "Livre");

            migrationBuilder.DropTable(
                name: "Pays");

            migrationBuilder.DropTable(
                name: "TypeLivre");
        }
    }
}
