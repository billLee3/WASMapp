using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDBlazorApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class Two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_Projects_ProjectID",
                table: "Forms");

            migrationBuilder.DropIndex(
                name: "IX_Forms_ProjectID",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "DateTimeOfInspection",
                table: "Forms");

            migrationBuilder.AlterColumn<string>(
                name: "Zoning",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Weather",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Propane",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhysicalSetting",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "POCRelationToProp",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "POCPhone",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "POCName",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NaturalGas",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FuelOil",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Electricity",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Zoning",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Weather",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Propane",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhysicalSetting",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "POCRelationToProp",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "POCPhone",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "POCName",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NaturalGas",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FuelOil",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Electricity",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeOfInspection",
                table: "Forms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTimeOfInspection",
                value: new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTimeOfInspection",
                value: new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6323), new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6327), new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6328), new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6329) });

            migrationBuilder.CreateIndex(
                name: "IX_Forms_ProjectID",
                table: "Forms",
                column: "ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_Projects_ProjectID",
                table: "Forms",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
