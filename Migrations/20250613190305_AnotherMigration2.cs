using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspApi.Migrations
{
    /// <inheritdoc />
    public partial class AnotherMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "StockId" },
                values: new object[] { new DateTime(2023, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 6, 13, 21, 0, 37, 887, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "StockId" },
                values: new object[] { new DateTime(2025, 6, 13, 21, 0, 37, 902, DateTimeKind.Local).AddTicks(3959), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 6, 13, 21, 0, 37, 902, DateTimeKind.Local).AddTicks(3984));
        }
    }
}
