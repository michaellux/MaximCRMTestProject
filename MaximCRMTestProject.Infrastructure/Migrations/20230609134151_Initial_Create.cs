using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaximCRMTestProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FullName", "Position" },
                values: new object[,]
                {
                    { new Guid("255d08eb-4283-41fd-bdae-b69324afed57"), "Назаров Александр Львович", "рыбак" },
                    { new Guid("35144ed8-6595-4b5a-9d2d-0d8595a40ea8"), "Калмыков Макар Владимирович", "кризис-менеджер" },
                    { new Guid("40427991-0373-445b-9a81-4f4a0a13b6b7"), "Швецова Яна Григорьевна", "эколог" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FullName",
                table: "Employees",
                column: "FullName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
