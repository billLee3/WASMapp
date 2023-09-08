using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDBlazorApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 9, 7, 18, 23, 57, 155, DateTimeKind.Utc).AddTicks(3506), new DateTime(2023, 9, 7, 18, 23, 57, 155, DateTimeKind.Utc).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 9, 7, 18, 23, 57, 155, DateTimeKind.Utc).AddTicks(3511), new DateTime(2023, 9, 7, 18, 23, 57, 155, DateTimeKind.Utc).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 9, 7, 18, 23, 57, 155, DateTimeKind.Utc).AddTicks(3512), new DateTime(2023, 9, 7, 18, 23, 57, 155, DateTimeKind.Utc).AddTicks(3513) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 8, 29, 1, 14, 56, 23, DateTimeKind.Utc).AddTicks(3898), new DateTime(2023, 8, 29, 1, 14, 56, 23, DateTimeKind.Utc).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 8, 29, 1, 14, 56, 23, DateTimeKind.Utc).AddTicks(3904), new DateTime(2023, 8, 29, 1, 14, 56, 23, DateTimeKind.Utc).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 8, 29, 1, 14, 56, 23, DateTimeKind.Utc).AddTicks(3905), new DateTime(2023, 8, 29, 1, 14, 56, 23, DateTimeKind.Utc).AddTicks(3906) });
        }
    }
}
