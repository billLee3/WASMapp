using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDBlazorApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class RequiredProjectFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 9, 9, 14, 13, 47, 754, DateTimeKind.Utc).AddTicks(5745), new DateTime(2023, 9, 9, 14, 13, 47, 754, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 9, 9, 14, 13, 47, 754, DateTimeKind.Utc).AddTicks(5749), new DateTime(2023, 9, 9, 14, 13, 47, 754, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 9, 9, 14, 13, 47, 754, DateTimeKind.Utc).AddTicks(5751), new DateTime(2023, 9, 9, 14, 13, 47, 754, DateTimeKind.Utc).AddTicks(5751) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
