using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Upd8.Infra.Data.Migrations
{
    public partial class StartMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CPF = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CPF",
                table: "Cliente",
                column: "CPF",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
