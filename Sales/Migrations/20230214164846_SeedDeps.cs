using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sales.Migrations
{
    /// <inheritdoc />
    public partial class SeedDeps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"), "Бухгалтерия" },
                    { new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"), "Канцелярия" },
                    { new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), "Отдел продаж" },
                    { new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), "Юридическая служба" },
                    { new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"), "Служба безопасности" },
                    { new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), "Отдел кадров" },
                    { new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"), "IT отдел" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"));
        }
    }
}
