using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.AmparoPet.Migrations
{
    public partial class AddCardVaccine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_CardVaccines_Pet_CardVaccineID",
                table: "CardVaccines",
                column: "CardVaccineID",
                principalTable: "Pet",
                principalColumn: "PetID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardVaccines_Pet_CardVaccineID",
                table: "CardVaccines");
        }
    }
}
