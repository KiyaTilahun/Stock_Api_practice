using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspApi.Migrations
{
    /// <inheritdoc />
    public partial class SeederMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedOn", "Title" },
                values: new object[] { "This is the content for comment number 1.", new DateTime(2023, 1, 16, 10, 30, 0, 0, DateTimeKind.Unspecified), "Comment Title 1" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedOn", "Title" },
                values: new object[] { "This is the content for comment number 2.", new DateTime(2023, 1, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), "Comment Title 2" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "CreatedOn", "StockId", "Title" },
                values: new object[] { "This is the content for comment number 3.", new DateTime(2023, 1, 18, 10, 30, 0, 0, DateTimeKind.Unspecified), 3, "Comment Title 3" });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyName", "Industry", "LastDiv", "MarketCap", "Purchase", "Symbol" },
                values: new object[] { "Company Name 1", "Finance", 0.11m, 110000000000L, 110.50m, "SYM01" });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyName", "Industry", "LastDiv", "MarketCap", "Purchase", "Symbol" },
                values: new object[] { "Company Name 2", "Healthcare", 0.12m, 120000000000L, 121.00m, "SYM02" });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyName", "Industry", "LastDiv", "MarketCap", "Purchase", "Symbol" },
                values: new object[] { "Company Name 3", "Technology", 0.13m, 130000000000L, 131.50m, "SYM03" });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CompanyName", "Industry", "LastDiv", "MarketCap", "Purchase", "Symbol" },
                values: new object[,]
                {
                    { 4, "Company Name 4", "Finance", 0.14m, 140000000000L, 142.00m, "SYM04" },
                    { 5, "Company Name 5", "Healthcare", 0.15m, 150000000000L, 152.50m, "SYM05" },
                    { 6, "Company Name 6", "Technology", 0.16m, 160000000000L, 163.00m, "SYM06" },
                    { 7, "Company Name 7", "Finance", 0.17m, 170000000000L, 173.50m, "SYM07" },
                    { 8, "Company Name 8", "Healthcare", 0.18m, 180000000000L, 184.00m, "SYM08" },
                    { 9, "Company Name 9", "Technology", 0.19m, 190000000000L, 194.50m, "SYM09" },
                    { 10, "Company Name 10", "Finance", 0.20m, 200000000000L, 205.00m, "SYM10" },
                    { 11, "Company Name 11", "Healthcare", 0.21m, 210000000000L, 215.50m, "SYM11" },
                    { 12, "Company Name 12", "Technology", 0.22m, 220000000000L, 226.00m, "SYM12" },
                    { 13, "Company Name 13", "Finance", 0.23m, 230000000000L, 236.50m, "SYM13" },
                    { 14, "Company Name 14", "Healthcare", 0.24m, 240000000000L, 247.00m, "SYM14" },
                    { 15, "Company Name 15", "Technology", 0.25m, 250000000000L, 257.50m, "SYM15" },
                    { 16, "Company Name 16", "Finance", 0.26m, 260000000000L, 268.00m, "SYM16" },
                    { 17, "Company Name 17", "Healthcare", 0.27m, 270000000000L, 278.50m, "SYM17" },
                    { 18, "Company Name 18", "Technology", 0.28m, 280000000000L, 289.00m, "SYM18" },
                    { 19, "Company Name 19", "Finance", 0.29m, 290000000000L, 299.50m, "SYM19" },
                    { 20, "Company Name 20", "Healthcare", 0.30m, 300000000000L, 310.00m, "SYM20" },
                    { 21, "Company Name 21", "Technology", 0.31m, 310000000000L, 320.50m, "SYM21" },
                    { 22, "Company Name 22", "Finance", 0.32m, 320000000000L, 331.00m, "SYM22" },
                    { 23, "Company Name 23", "Healthcare", 0.33m, 330000000000L, 341.50m, "SYM23" },
                    { 24, "Company Name 24", "Technology", 0.34m, 340000000000L, 352.00m, "SYM24" },
                    { 25, "Company Name 25", "Finance", 0.35m, 350000000000L, 362.50m, "SYM25" },
                    { 26, "Company Name 26", "Healthcare", 0.36m, 360000000000L, 373.00m, "SYM26" },
                    { 27, "Company Name 27", "Technology", 0.37m, 370000000000L, 383.50m, "SYM27" },
                    { 28, "Company Name 28", "Finance", 0.38m, 380000000000L, 394.00m, "SYM28" },
                    { 29, "Company Name 29", "Healthcare", 0.39m, 390000000000L, 404.50m, "SYM29" },
                    { 30, "Company Name 30", "Technology", 0.40m, 400000000000L, 415.00m, "SYM30" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedOn", "StockId", "Title" },
                values: new object[,]
                {
                    { 4, "This is the content for comment number 4.", new DateTime(2023, 1, 19, 10, 30, 0, 0, DateTimeKind.Unspecified), 4, "Comment Title 4" },
                    { 5, "This is the content for comment number 5.", new DateTime(2023, 1, 20, 10, 30, 0, 0, DateTimeKind.Unspecified), 5, "Comment Title 5" },
                    { 6, "This is the content for comment number 6.", new DateTime(2023, 1, 21, 10, 30, 0, 0, DateTimeKind.Unspecified), 6, "Comment Title 6" },
                    { 7, "This is the content for comment number 7.", new DateTime(2023, 1, 22, 10, 30, 0, 0, DateTimeKind.Unspecified), 7, "Comment Title 7" },
                    { 8, "This is the content for comment number 8.", new DateTime(2023, 1, 23, 10, 30, 0, 0, DateTimeKind.Unspecified), 8, "Comment Title 8" },
                    { 9, "This is the content for comment number 9.", new DateTime(2023, 1, 24, 10, 30, 0, 0, DateTimeKind.Unspecified), 9, "Comment Title 9" },
                    { 10, "This is the content for comment number 10.", new DateTime(2023, 1, 25, 10, 30, 0, 0, DateTimeKind.Unspecified), 10, "Comment Title 10" },
                    { 11, "This is the content for comment number 11.", new DateTime(2023, 1, 26, 10, 30, 0, 0, DateTimeKind.Unspecified), 11, "Comment Title 11" },
                    { 12, "This is the content for comment number 12.", new DateTime(2023, 1, 27, 10, 30, 0, 0, DateTimeKind.Unspecified), 12, "Comment Title 12" },
                    { 13, "This is the content for comment number 13.", new DateTime(2023, 1, 28, 10, 30, 0, 0, DateTimeKind.Unspecified), 13, "Comment Title 13" },
                    { 14, "This is the content for comment number 14.", new DateTime(2023, 1, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), 14, "Comment Title 14" },
                    { 15, "This is the content for comment number 15.", new DateTime(2023, 1, 30, 10, 30, 0, 0, DateTimeKind.Unspecified), 15, "Comment Title 15" },
                    { 16, "This is the content for comment number 16.", new DateTime(2023, 1, 31, 10, 30, 0, 0, DateTimeKind.Unspecified), 16, "Comment Title 16" },
                    { 17, "This is the content for comment number 17.", new DateTime(2023, 2, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), 17, "Comment Title 17" },
                    { 18, "This is the content for comment number 18.", new DateTime(2023, 2, 2, 10, 30, 0, 0, DateTimeKind.Unspecified), 18, "Comment Title 18" },
                    { 19, "This is the content for comment number 19.", new DateTime(2023, 2, 3, 10, 30, 0, 0, DateTimeKind.Unspecified), 19, "Comment Title 19" },
                    { 20, "This is the content for comment number 20.", new DateTime(2023, 2, 4, 10, 30, 0, 0, DateTimeKind.Unspecified), 20, "Comment Title 20" },
                    { 21, "This is the content for comment number 21.", new DateTime(2023, 2, 5, 10, 30, 0, 0, DateTimeKind.Unspecified), 21, "Comment Title 21" },
                    { 22, "This is the content for comment number 22.", new DateTime(2023, 2, 6, 10, 30, 0, 0, DateTimeKind.Unspecified), 22, "Comment Title 22" },
                    { 23, "This is the content for comment number 23.", new DateTime(2023, 2, 7, 10, 30, 0, 0, DateTimeKind.Unspecified), 23, "Comment Title 23" },
                    { 24, "This is the content for comment number 24.", new DateTime(2023, 2, 8, 10, 30, 0, 0, DateTimeKind.Unspecified), 24, "Comment Title 24" },
                    { 25, "This is the content for comment number 25.", new DateTime(2023, 2, 9, 10, 30, 0, 0, DateTimeKind.Unspecified), 25, "Comment Title 25" },
                    { 26, "This is the content for comment number 26.", new DateTime(2023, 2, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), 26, "Comment Title 26" },
                    { 27, "This is the content for comment number 27.", new DateTime(2023, 2, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), 27, "Comment Title 27" },
                    { 28, "This is the content for comment number 28.", new DateTime(2023, 2, 12, 10, 30, 0, 0, DateTimeKind.Unspecified), 28, "Comment Title 28" },
                    { 29, "This is the content for comment number 29.", new DateTime(2023, 2, 13, 10, 30, 0, 0, DateTimeKind.Unspecified), 29, "Comment Title 29" },
                    { 30, "This is the content for comment number 30.", new DateTime(2023, 2, 14, 10, 30, 0, 0, DateTimeKind.Unspecified), 30, "Comment Title 30" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedOn", "Title" },
                values: new object[] { "Comment 1", new DateTime(2023, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), "Comment 1" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedOn", "Title" },
                values: new object[] { "Comment 2", new DateTime(2023, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), "Comment 2" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "CreatedOn", "StockId", "Title" },
                values: new object[] { "Comment 2", new DateTime(2023, 1, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), 2, "Comment 2" });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyName", "Industry", "LastDiv", "MarketCap", "Purchase", "Symbol" },
                values: new object[] { "Apple Inc.", "Technology", 0.22m, 2500000000000L, 150.00m, "AAPL" });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyName", "Industry", "LastDiv", "MarketCap", "Purchase", "Symbol" },
                values: new object[] { "Microsoft Corp.", "Technology", 0.56m, 2000000000000L, 250.00m, "MSFT" });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyName", "Industry", "LastDiv", "MarketCap", "Purchase", "Symbol" },
                values: new object[] { "Tesla Inc.", "Automobile", 0.00m, 800000000000L, 700.00m, "TSLA" });
        }
    }
}
