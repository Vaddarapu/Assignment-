using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class billandpatienttablecreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientTables",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varchar100 = table.Column<string>(name: "varchar(100)", type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientTables", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "BillsTables",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    AmountPaid = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillsTables", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_BillsTables_PatientTables_PatientId",
                        column: x => x.PatientId,
                        principalTable: "PatientTables",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillsTables_PatientId",
                table: "BillsTables",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillsTables");

            migrationBuilder.DropTable(
                name: "PatientTables");
        }
    }
}
