using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace empManagment.Migrations
{
    /// <inheritdoc />
    public partial class AddPositionDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepID", "DepName", "Description" },
                values: new object[,]
                {
                    { 12, "Human Resources", "Human Resources Department" },
                    { 13, "Information Technology", "Information Technology Department" },
                    { 14, "Finance", "Finance Department" },
                    { 15, "Sales", "Sales Department" },
                    { 16, "Marketing", "Marketing Department" },
                    { 17, "Operations", "Operations Department" },
                    { 18, "Customer Service", "Customer Service Department" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PosID", "DepartmentID", "MaxSalary", "MinSalary", "PosTitle" },
                values: new object[,]
                {
                    { 7, 12, 3000m, 1500m, "HR Manager" },
                    { 8, 12, 1500m, 700m, "HR Specialist" },
                    { 9, 12, 1300m, 600m, "Recruitment Officer" },
                    { 10, 12, 1000m, 500m, "HR Assistant" },
                    { 11, 13, 3500m, 1800m, "IT Manager" },
                    { 12, 13, 2500m, 1000m, "Software Developer" },
                    { 13, 13, 2200m, 900m, "System Administrator" },
                    { 14, 13, 1200m, 500m, "IT Support Specialist" },
                    { 15, 14, 3500m, 1800m, "Finance Manager" },
                    { 16, 14, 1500m, 700m, "Accountant" },
                    { 17, 14, 2000m, 900m, "Financial Analyst" },
                    { 18, 14, 1200m, 600m, "Finance Assistant" },
                    { 19, 15, 3000m, 1500m, "Sales Manager" },
                    { 20, 15, 1500m, 600m, "Sales Representative" },
                    { 21, 15, 1800m, 800m, "Account Executive" },
                    { 22, 15, 1000m, 500m, "Sales Assistant" },
                    { 23, 16, 3000m, 1600m, "Marketing Manager" },
                    { 24, 16, 1600m, 800m, "Marketing Specialist" },
                    { 25, 16, 1500m, 700m, "Digital Marketing Specialist" },
                    { 26, 16, 1000m, 500m, "Marketing Assistant" },
                    { 27, 17, 3500m, 1800m, "Operations Manager" },
                    { 28, 17, 2000m, 900m, "Operations Supervisor" },
                    { 29, 17, 1500m, 700m, "Operations Officer" },
                    { 30, 17, 1000m, 500m, "Operations Assistant" },
                    { 31, 18, 2800m, 1400m, "Customer Service Manager" },
                    { 32, 18, 1500m, 700m, "Customer Service Representative" },
                    { 33, 18, 1300m, 600m, "Customer Support Specialist" },
                    { 34, 18, 1000m, 500m, "Customer Service Assistant" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmpID", "DepartmentID", "Email", "FirstName", "HireDate", "LastName", "Phone", "PositionID", "Salary" },
                values: new object[,]
                {
                    { 100, 12, "ahmad.khaldi@company.com", "Ahmad", new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Al-Khaldi", "0791234567", 7, 1800m },
                    { 101, 12, "sara.ahmad@company.com", "Sara", new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmad", "0782345678", 8, 950m },
                    { 102, 12, "omar.haddad@company.com", "Omar", new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haddad", "0773456789", 9, 800m },
                    { 103, 12, "lina.saleh@company.com", "Lina", new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saleh", "0794567890", 10, 600m },
                    { 104, 13, "mohammad.nasser@company.com", "Mohammad", new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nasser", "0795678901", 11, 2200m },
                    { 105, 13, "yousef.abdullah@company.com", "Yousef", new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdullah", "0786789012", 12, 1400m },
                    { 106, 13, "khaled.ali@company.com", "Khaled", new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ali", "0777890123", 13, 1200m },
                    { 107, 13, "rami.mahmoud@company.com", "Rami", new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mahmoud", "0798901234", 14, 750m },
                    { 108, 14, "hani.qasem@company.com", "Hani", new DateTime(2018, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qasem", "0799012345", 15, 2000m },
                    { 109, 14, "dana.khalil@company.com", "Dana", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khalil", "0780123456", 16, 1000m },
                    { 110, 14, "tareq.salameh@company.com", "Tareq", new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salameh", "0771234560", 17, 1300m },
                    { 111, 14, "noor.hamdan@company.com", "Noor", new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hamdan", "0792345670", 18, 850m },
                    { 112, 15, "sami.odeh@company.com", "Sami", new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odeh", "0793456780", 19, 1800m },
                    { 113, 15, "fadi.yasin@company.com", "Fadi", new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yasin", "0784567890", 20, 800m },
                    { 114, 15, "maya.saadi@company.com", "Maya", new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saadi", "0775678900", 21, 1100m },
                    { 115, 15, "rana.zaid@company.com", "Rana", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaid", "0796789010", 22, 700m },
                    { 116, 16, "basel.kanaan@company.com", "Basel", new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kanaan", "0797890120", 23, 1900m },
                    { 117, 16, "aya.mustafa@company.com", "Aya", new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mustafa", "0788901230", 24, 1200m },
                    { 118, 16, "laith.ibrahim@company.com", "Laith", new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ibrahim", "0779012340", 25, 850m },
                    { 119, 16, "hala.jaber@company.com", "Hala", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jaber", "0790123451", 26, 750m },
                    { 120, 17, "nabil.shami@company.com", "Nabil", new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shami", "0791234501", 27, 2000m },
                    { 121, 17, "walid.fares@company.com", "Walid", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fares", "0782345601", 28, 1200m },
                    { 122, 17, "rashid.mansour@company.com", "Rashid", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mansour", "0773456701", 29, 850m },
                    { 123, 17, "samer.barakat@company.com", "Samer", new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barakat", "0794567801", 30, 650m },
                    { 124, 18, "imad.naji@company.com", "Imad", new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Naji", "0795678902", 31, 1600m },
                    { 125, 18, "jamal.hussein@company.com", "Jamal", new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hussein", "0786789013", 32, 1000m },
                    { 126, 18, "nour.suleiman@company.com", "Nour", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suleiman", "0777890124", 33, 650m },
                    { 127, 18, "salma.rashed@company.com", "Salma", new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rashed", "0798901235", 34, 550m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DepartmentID",
                table: "Positions",
                column: "DepartmentID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Departments_DepartmentID",
                table: "Positions",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Departments_DepartmentID",
                table: "Positions");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Positions_DepartmentID",
                table: "Positions");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PosID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepID",
                keyValue: 18);

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Positions");

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
    }
}
