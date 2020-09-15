using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleWebMvcApp.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Department",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Department",
                newName: "id");

            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    birthDate = table.Column<DateTime>(nullable: false),
                    baseSalary = table.Column<double>(nullable: false),
                    Departmentid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.id);
                    table.ForeignKey(
                        name: "FK_Seller_Department_Departmentid",
                        column: x => x.Departmentid,
                        principalTable: "Department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleRecord",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(nullable: false),
                    amount = table.Column<double>(nullable: false),
                    saleStatus = table.Column<int>(nullable: false),
                    sellerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleRecord", x => x.id);
                    table.ForeignKey(
                        name: "FK_SaleRecord_Seller_sellerid",
                        column: x => x.sellerid,
                        principalTable: "Seller",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleRecord_sellerid",
                table: "SaleRecord",
                column: "sellerid");

            migrationBuilder.CreateIndex(
                name: "IX_Seller_Departmentid",
                table: "Seller",
                column: "Departmentid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleRecord");

            migrationBuilder.DropTable(
                name: "Seller");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Department",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Department",
                newName: "ID");
        }
    }
}
