using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace empManagment.Migrations
{
    /// <inheritdoc />
    public partial class SeedDepartmentsAndPositions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepID", "DepName", "Description" },
                values: new object[,]
                {
                    { 1, "IT", "Information Technology" },
                    { 2, "HR", "Human Resources" },
                    { 3, "Finance", "Finance Department" },
                    { 4, "Marketing", "Marketing Department" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PosID", "MaxSalary", "MinSalary", "PosTitle" },
                values: new object[,]
                {
                    { 1, 1500m, 500m, "Software Developer" },
                    { 2, 1200m, 500m, "HR Specialist" },
                    { 3, 1000m, 400m, "Accountant" },
                    { 4, 1100m, 300m, "Marketing Specialist" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 4);
        }
    }
}
