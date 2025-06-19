using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspApi.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purchase = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LastDiv = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarketCap = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => new { x.UserId, x.StockId });
                    table.ForeignKey(
                        name: "FK_Portfolios_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Portfolios_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CompanyName", "Industry", "LastDiv", "MarketCap", "Purchase", "Symbol" },
                values: new object[,]
                {
                    { 1, "Company Name 1", "Finance", 0.11m, 110000000000L, 110.50m, "SYM01" },
                    { 2, "Company Name 2", "Healthcare", 0.12m, 120000000000L, 121.00m, "SYM02" },
                    { 3, "Company Name 3", "Technology", 0.13m, 130000000000L, 131.50m, "SYM03" },
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
                    { 1, "This is the content for comment number 1.", new DateTime(2023, 1, 16, 10, 30, 0, 0, DateTimeKind.Unspecified), 1, "Comment Title 1" },
                    { 2, "This is the content for comment number 2.", new DateTime(2023, 1, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), 2, "Comment Title 2" },
                    { 3, "This is the content for comment number 3.", new DateTime(2023, 1, 18, 10, 30, 0, 0, DateTimeKind.Unspecified), 3, "Comment Title 3" },
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_StockId",
                table: "Comments",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_StockId",
                table: "Portfolios",
                column: "StockId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Stocks");
        }
    }
}
