using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace empManagment.Migrations
{
    /// <inheritdoc />
    public partial class editreemp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_RetiredEmployees_DepartmentID",
                table: "RetiredEmployees",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_RetiredEmployees_PositionID",
                table: "RetiredEmployees",
                column: "PositionID");

            migrationBuilder.AddForeignKey(
                name: "FK_RetiredEmployees_Departments_DepartmentID",
                table: "RetiredEmployees",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RetiredEmployees_Positions_PositionID",
                table: "RetiredEmployees",
                column: "PositionID",
                principalTable: "Positions",
                principalColumn: "PosID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RetiredEmployees_Departments_DepartmentID",
                table: "RetiredEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_RetiredEmployees_Positions_PositionID",
                table: "RetiredEmployees");

            migrationBuilder.DropIndex(
                name: "IX_RetiredEmployees_DepartmentID",
                table: "RetiredEmployees");

            migrationBuilder.DropIndex(
                name: "IX_RetiredEmployees_PositionID",
                table: "RetiredEmployees");
        }
    }
}
