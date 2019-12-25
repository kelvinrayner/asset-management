using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddEmployeeAccountModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_M_Account_Role",
                columns: table => new
                {
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: true),
                    Delete_Date = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Account_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Employee",
                columns: table => new
                {
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: true),
                    Delete_Date = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Handphone_Number = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Start_Working = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Employee_Department",
                columns: table => new
                {
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: true),
                    Delete_Date = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Employee_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Employee_Position",
                columns: table => new
                {
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: true),
                    Delete_Date = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Employee_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Account",
                columns: table => new
                {
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: true),
                    Delete_Date = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true),
                    RoleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_M_Account_TB_M_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "TB_M_Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_M_Account_TB_M_Account_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "TB_M_Account_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_T_Employee_Details",
                columns: table => new
                {
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: true),
                    Delete_Date = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: true),
                    PositionId = table.Column<int>(nullable: true),
                    ManagerId = table.Column<int>(nullable: true),
                    Division_HeadId = table.Column<int>(nullable: true),
                    BodId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_T_Employee_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_T_Employee_Details_TB_M_Employee_BodId",
                        column: x => x.BodId,
                        principalTable: "TB_M_Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Employee_Details_TB_M_Employee_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "TB_M_Employee_Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Employee_Details_TB_M_Employee_Division_HeadId",
                        column: x => x.Division_HeadId,
                        principalTable: "TB_M_Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Employee_Details_TB_M_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "TB_M_Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Employee_Details_TB_M_Employee_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "TB_M_Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Employee_Details_TB_M_Employee_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "TB_M_Employee_Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_Account_EmployeeId",
                table: "TB_M_Account",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_Account_RoleId",
                table: "TB_M_Account",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Employee_Details_BodId",
                table: "TB_T_Employee_Details",
                column: "BodId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Employee_Details_DepartmentId",
                table: "TB_T_Employee_Details",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Employee_Details_Division_HeadId",
                table: "TB_T_Employee_Details",
                column: "Division_HeadId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Employee_Details_EmployeeId",
                table: "TB_T_Employee_Details",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Employee_Details_ManagerId",
                table: "TB_T_Employee_Details",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Employee_Details_PositionId",
                table: "TB_T_Employee_Details",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_M_Account");

            migrationBuilder.DropTable(
                name: "TB_T_Employee_Details");

            migrationBuilder.DropTable(
                name: "TB_M_Account_Role");

            migrationBuilder.DropTable(
                name: "TB_M_Employee");

            migrationBuilder.DropTable(
                name: "TB_M_Employee_Department");

            migrationBuilder.DropTable(
                name: "TB_M_Employee_Position");
        }
    }
}
