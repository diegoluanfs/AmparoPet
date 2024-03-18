using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.AmparoPet.Migrations
{
    public partial class CardVaccine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cep = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "CardVaccine",
                columns: table => new
                {
                    CardVaccineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardVaccine", x => x.CardVaccineID);
                });

            migrationBuilder.CreateTable(
                name: "Carer",
                columns: table => new
                {
                    CarerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carer", x => x.CarerID);
                    table.ForeignKey(
                        name: "FK_Carer_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "AddressID");
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    PetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CarerID = table.Column<int>(type: "int", nullable: true),
                    CardVaccineID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.PetID);
                    table.ForeignKey(
                        name: "FK_Pet_CardVaccine_CardVaccineID",
                        column: x => x.CardVaccineID,
                        principalTable: "CardVaccine",
                        principalColumn: "CardVaccineID");
                    table.ForeignKey(
                        name: "FK_Pet_Carer_CarerID",
                        column: x => x.CarerID,
                        principalTable: "Carer",
                        principalColumn: "CarerID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carer_AddressID",
                table: "Carer",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_CardVaccineID",
                table: "Pet",
                column: "CardVaccineID");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_CarerID",
                table: "Pet",
                column: "CarerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "CardVaccine");

            migrationBuilder.DropTable(
                name: "Carer");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
