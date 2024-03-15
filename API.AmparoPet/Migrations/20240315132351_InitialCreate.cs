using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.AmparoPet.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardVaccines",
                columns: table => new
                {
                    CardVaccineID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardVaccines", x => x.CardVaccineID);
                });

            migrationBuilder.CreateTable(
                name: "Carer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    PetID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.PetID);
                });

            migrationBuilder.CreateTable(
                name: "Vaccine",
                columns: table => new
                {
                    VaccineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AdministeredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CardVaccineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccine", x => x.VaccineId);
                    table.ForeignKey(
                        name: "FK_Vaccine_CardVaccines_CardVaccineId",
                        column: x => x.CardVaccineId,
                        principalTable: "CardVaccines",
                        principalColumn: "CardVaccineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarerPet",
                columns: table => new
                {
                    CaregiversID = table.Column<int>(type: "int", nullable: false),
                    PetsPetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarerPet", x => new { x.CaregiversID, x.PetsPetID });
                    table.ForeignKey(
                        name: "FK_CarerPet_Carer_CaregiversID",
                        column: x => x.CaregiversID,
                        principalTable: "Carer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarerPet_Pet_PetsPetID",
                        column: x => x.PetsPetID,
                        principalTable: "Pet",
                        principalColumn: "PetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarerPet_PetsPetID",
                table: "CarerPet",
                column: "PetsPetID");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccine_CardVaccineId",
                table: "Vaccine",
                column: "CardVaccineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarerPet");

            migrationBuilder.DropTable(
                name: "Vaccine");

            migrationBuilder.DropTable(
                name: "Carer");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "CardVaccines");
        }
    }
}
