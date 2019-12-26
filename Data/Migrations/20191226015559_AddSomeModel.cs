using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddSomeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_M_Damage_Type",
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
                    table.PrimaryKey("PK_TB_M_Damage_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Status_Approval",
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
                    table.PrimaryKey("PK_TB_M_Status_Approval", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Type_Asset",
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
                    table.PrimaryKey("PK_TB_M_Type_Asset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Damage_Classification",
                columns: table => new
                {
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: true),
                    Delete_Date = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    DamageTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Damage_Classification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_M_Damage_Classification_TB_M_Damage_Type_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "TB_M_Damage_Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_T_Notebook_Request",
                columns: table => new
                {
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: true),
                    Delete_Date = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Serial_Number = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Pay_Cash = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true),
                    ManagerId = table.Column<int>(nullable: true),
                    Division_HeadIdId = table.Column<int>(nullable: true),
                    BodIdId = table.Column<int>(nullable: true),
                    Manager_StatusId = table.Column<int>(nullable: true),
                    Divisio_Head_StatusId = table.Column<int>(nullable: true),
                    Bod_StatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_T_Notebook_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_T_Notebook_Request_TB_M_Employee_BodIdId",
                        column: x => x.BodIdId,
                        principalTable: "TB_M_Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Notebook_Request_TB_M_Status_Approval_Bod_StatusId",
                        column: x => x.Bod_StatusId,
                        principalTable: "TB_M_Status_Approval",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Notebook_Request_TB_M_Status_Approval_Divisio_Head_Stat~",
                        column: x => x.Divisio_Head_StatusId,
                        principalTable: "TB_M_Status_Approval",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Notebook_Request_TB_M_Employee_Division_HeadIdId",
                        column: x => x.Division_HeadIdId,
                        principalTable: "TB_M_Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Notebook_Request_TB_M_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "TB_M_Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Notebook_Request_TB_M_Employee_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "TB_M_Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Notebook_Request_TB_M_Status_Approval_Manager_StatusId",
                        column: x => x.Manager_StatusId,
                        principalTable: "TB_M_Status_Approval",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Asset",
                columns: table => new
                {
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: true),
                    Delete_Date = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: true),
                    Condition = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_M_Asset_TB_M_Type_Asset_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TB_M_Type_Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_T_Asset_Lend",
                columns: table => new
                {
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: true),
                    Delete_Date = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: true),
                    AssetId = table.Column<int>(nullable: true),
                    Lend_Date = table.Column<DateTime>(nullable: false),
                    End_Date = table.Column<DateTime>(nullable: false),
                    Manager_StatusId = table.Column<int>(nullable: true),
                    ManagerId = table.Column<int>(nullable: true),
                    Manager_Additional_Info = table.Column<string>(nullable: true),
                    Procurement_StatusId = table.Column<int>(nullable: true),
                    Procurement_Additional_Info = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_T_Asset_Lend", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_T_Asset_Lend_TB_M_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "TB_M_Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Asset_Lend_TB_M_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "TB_M_Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Asset_Lend_TB_M_Employee_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "TB_M_Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Asset_Lend_TB_M_Status_Approval_Manager_StatusId",
                        column: x => x.Manager_StatusId,
                        principalTable: "TB_M_Status_Approval",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Asset_Lend_TB_M_Status_Approval_Procurement_StatusId",
                        column: x => x.Procurement_StatusId,
                        principalTable: "TB_M_Status_Approval",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_T_Asset_Return",
                columns: table => new
                {
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: true),
                    Delete_Date = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssetLendId = table.Column<int>(nullable: true),
                    Return_Date = table.Column<DateTime>(nullable: false),
                    Condition = table.Column<string>(nullable: true),
                    Charge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_T_Asset_Return", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_T_Asset_Return_TB_T_Asset_Lend_AssetLendId",
                        column: x => x.AssetLendId,
                        principalTable: "TB_T_Asset_Lend",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_T_Damage_Asset",
                columns: table => new
                {
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: true),
                    Delete_Date = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssetLendId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_T_Damage_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_T_Damage_Asset_TB_T_Asset_Lend_AssetLendId",
                        column: x => x.AssetLendId,
                        principalTable: "TB_T_Asset_Lend",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_T_Damage_History",
                columns: table => new
                {
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: true),
                    Delete_Date = table.Column<DateTime>(nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DamageAssetId = table.Column<int>(nullable: true),
                    DamageClassificationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_T_Damage_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_T_Damage_History_TB_T_Damage_Asset_DamageAssetId",
                        column: x => x.DamageAssetId,
                        principalTable: "TB_T_Damage_Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Damage_History_TB_M_Damage_Classification_DamageClassif~",
                        column: x => x.DamageClassificationId,
                        principalTable: "TB_M_Damage_Classification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_Asset_TypeId",
                table: "TB_M_Asset",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_Damage_Classification_DamageTypeId",
                table: "TB_M_Damage_Classification",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Asset_Lend_AssetId",
                table: "TB_T_Asset_Lend",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Asset_Lend_EmployeeId",
                table: "TB_T_Asset_Lend",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Asset_Lend_ManagerId",
                table: "TB_T_Asset_Lend",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Asset_Lend_Manager_StatusId",
                table: "TB_T_Asset_Lend",
                column: "Manager_StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Asset_Lend_Procurement_StatusId",
                table: "TB_T_Asset_Lend",
                column: "Procurement_StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Asset_Return_AssetLendId",
                table: "TB_T_Asset_Return",
                column: "AssetLendId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Damage_Asset_AssetLendId",
                table: "TB_T_Damage_Asset",
                column: "AssetLendId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Damage_History_DamageAssetId",
                table: "TB_T_Damage_History",
                column: "DamageAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Damage_History_DamageClassificationId",
                table: "TB_T_Damage_History",
                column: "DamageClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Notebook_Request_BodIdId",
                table: "TB_T_Notebook_Request",
                column: "BodIdId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Notebook_Request_Bod_StatusId",
                table: "TB_T_Notebook_Request",
                column: "Bod_StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Notebook_Request_Divisio_Head_StatusId",
                table: "TB_T_Notebook_Request",
                column: "Divisio_Head_StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Notebook_Request_Division_HeadIdId",
                table: "TB_T_Notebook_Request",
                column: "Division_HeadIdId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Notebook_Request_EmployeeId",
                table: "TB_T_Notebook_Request",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Notebook_Request_ManagerId",
                table: "TB_T_Notebook_Request",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Notebook_Request_Manager_StatusId",
                table: "TB_T_Notebook_Request",
                column: "Manager_StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_T_Asset_Return");

            migrationBuilder.DropTable(
                name: "TB_T_Damage_History");

            migrationBuilder.DropTable(
                name: "TB_T_Notebook_Request");

            migrationBuilder.DropTable(
                name: "TB_T_Damage_Asset");

            migrationBuilder.DropTable(
                name: "TB_M_Damage_Classification");

            migrationBuilder.DropTable(
                name: "TB_T_Asset_Lend");

            migrationBuilder.DropTable(
                name: "TB_M_Damage_Type");

            migrationBuilder.DropTable(
                name: "TB_M_Asset");

            migrationBuilder.DropTable(
                name: "TB_M_Status_Approval");

            migrationBuilder.DropTable(
                name: "TB_M_Type_Asset");
        }
    }
}
