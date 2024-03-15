using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.AmparoPet.Migrations
{
    public partial class AddPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    PhotoID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.PhotoID);
                });

            migrationBuilder.CreateTable(
                name: "PetPhoto",
                columns: table => new
                {
                    PetsPetID = table.Column<int>(type: "int", nullable: false),
                    PhotosPhotoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetPhoto", x => new { x.PetsPetID, x.PhotosPhotoID });
                    table.ForeignKey(
                        name: "FK_PetPhoto_Pet_PetsPetID",
                        column: x => x.PetsPetID,
                        principalTable: "Pet",
                        principalColumn: "PetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PetPhoto_Photo_PhotosPhotoID",
                        column: x => x.PhotosPhotoID,
                        principalTable: "Photo",
                        principalColumn: "PhotoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PetPhoto_PhotosPhotoID",
                table: "PetPhoto",
                column: "PhotosPhotoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetPhoto");

            migrationBuilder.DropTable(
                name: "Photo");
        }
    }
}
