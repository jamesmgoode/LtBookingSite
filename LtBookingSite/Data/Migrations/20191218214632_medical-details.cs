using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LtBookingSite.Data.Migrations
{
    public partial class medicaldetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalDetails",
                columns: table => new
                {
                    MedicalDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmergencyContactName = table.Column<string>(nullable: false),
                    EmergencyContactPhoneNumber = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalDetails", x => x.MedicalDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    EmailAddress = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    PlayerId = table.Column<int>(nullable: true),
                    MedicalDetailsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.EmailAddress);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalDetails");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
