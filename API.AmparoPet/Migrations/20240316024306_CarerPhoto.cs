using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.AmparoPet.Migrations
{
    public partial class CarerPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarerPhoto",
                columns: table => new
                {
                    CaregiversID = table.Column<int>(type: "int", nullable: false),
                    PhotosPhotoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarerPhoto", x => new { x.CaregiversID, x.PhotosPhotoID });
                    table.ForeignKey(
                        name: "FK_CarerPhoto_Carer_CaregiversID",
                        column: x => x.CaregiversID,
                        principalTable: "Carer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarerPhoto_Photo_PhotosPhotoID",
                        column: x => x.PhotosPhotoID,
                        principalTable: "Photo",
                        principalColumn: "PhotoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarerPhoto_PhotosPhotoID",
                table: "CarerPhoto",
                column: "PhotosPhotoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarerPhoto");
        }
    }
}
