﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daw_lab4.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stire",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titlu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lead = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Continut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categorie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stire", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Stire");
        }
    }
}
