using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspApi.Migrations
{
    /// <inheritdoc />
    public partial class SeederMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "081a7afd-fd8e-4d36-97d2-6b9a044639da", null, "Admin", "ADMIN" },
                    { "1693662b-273c-4683-818e-3acdd9146a92", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "081a7afd-fd8e-4d36-97d2-6b9a044639da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1693662b-273c-4683-818e-3acdd9146a92");
        }
    }
}
