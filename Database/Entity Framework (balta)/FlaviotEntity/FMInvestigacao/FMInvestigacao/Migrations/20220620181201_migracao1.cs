using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FMInvestigacao.Migrations
{
    public partial class migracao1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vilao",
                columns: table => new
                {
                    IdVilao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false),
                    NumCrime = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vilao", x => x.IdVilao);
                });

            migrationBuilder.CreateTable(
                name: "Crime",
                columns: table => new
                {
                    IdCrime = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false),
                    Local = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: true),
                    Duracao = table.Column<int>(type: "INT", nullable: false),
                    VilaoIdVilao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crime", x => x.IdCrime);
                    table.ForeignKey(
                        name: "FK_Vilao_Crime",
                        column: x => x.VilaoIdVilao,
                        principalTable: "Vilao",
                        principalColumn: "IdVilao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crime_VilaoIdVilao",
                table: "Crime",
                column: "VilaoIdVilao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crime");

            migrationBuilder.DropTable(
                name: "Vilao");
        }
    }
}
