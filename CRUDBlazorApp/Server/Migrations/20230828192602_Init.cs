using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRUDBlazorApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimeOfInspection = table.Column<DateTime>(type: "datetime2", nullable: false),
                    POCName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    POCRelationToProp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    POCPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalSetting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weather = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zoning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeSqFt = table.Column<int>(type: "int", nullable: false),
                    NaturalGas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Propane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelOil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Electricity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forms_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AddressName", "AssignedTo", "City", "CreateDate", "CreatedBy", "LastUpdate", "LastUpdatedBy", "Name", "State", "Status", "Type" },
                values: new object[,]
                {
                    { 1, "1", "Test", "1", new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6323), "Test", new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6326), "Test", "Project 1", "1", "Open", "" },
                    { 2, "Columbus Ave", "Test", "Huntsville", new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6327), "Test", new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6327), "Test", "Project 2", "AL", "Open", "" },
                    { 3, "Huntsvill Road", "Test", "Columbus", new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6328), "Test", new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6329), "Test", "Project 3", "OH", "Open", "" }
                });

            migrationBuilder.InsertData(
                table: "Forms",
                columns: new[] { "Id", "DateTimeOfInspection", "Electricity", "FuelOil", "NaturalGas", "POCName", "POCPhone", "POCRelationToProp", "PhysicalSetting", "ProjectID", "Propane", "SizeSqFt", "Weather", "Zoning" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6440), "yes", "yes", "yes", "Test", "123-456-7890", "Test", "urban", 1, "yes", 1000, "sunny", "residential" },
                    { 2, new DateTime(2023, 8, 28, 19, 26, 2, 606, DateTimeKind.Utc).AddTicks(6443), "yes", "yes", "yes", "Test", "123-456-7890", "Test", "urban", 1, "yes", 1000, "sunny", "residential" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Forms_ProjectID",
                table: "Forms",
                column: "ProjectID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
