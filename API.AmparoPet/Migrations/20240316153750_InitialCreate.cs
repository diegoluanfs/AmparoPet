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
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CarerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Carer_CarerID",
                        column: x => x.CarerID,
                        principalTable: "Carer",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    DocumentID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.DocumentID);
                    table.ForeignKey(
                        name: "FK_Document_Carer_DocumentID",
                        column: x => x.DocumentID,
                        principalTable: "Carer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CarerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_Post_Carer_CarerID",
                        column: x => x.CarerID,
                        principalTable: "Carer",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Address_Carer_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Carer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_Post_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Post",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    PetID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.PetID);
                    table.ForeignKey(
                        name: "FK_Pet_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostID");
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    PhotoID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.PhotoID);
                    table.ForeignKey(
                        name: "FK_Photo_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostID");
                });

            migrationBuilder.CreateTable(
                name: "Reaction",
                columns: table => new
                {
                    ReactionID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reaction", x => x.ReactionID);
                    table.ForeignKey(
                        name: "FK_Reaction_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostID");
                });

            migrationBuilder.CreateTable(
                name: "CardVaccine",
                columns: table => new
                {
                    CardVaccineID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardVaccine", x => x.CardVaccineID);
                    table.ForeignKey(
                        name: "FK_CardVaccine_Pet_CardVaccineID",
                        column: x => x.CardVaccineID,
                        principalTable: "Pet",
                        principalColumn: "PetID",
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
                        name: "FK_Vaccine_CardVaccine_CardVaccineId",
                        column: x => x.CardVaccineId,
                        principalTable: "CardVaccine",
                        principalColumn: "CardVaccineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarerPet_PetsPetID",
                table: "CarerPet",
                column: "PetsPetID");

            migrationBuilder.CreateIndex(
                name: "IX_CarerPhoto_PhotosPhotoID",
                table: "CarerPhoto",
                column: "PhotosPhotoID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CarerID",
                table: "Comments",
                column: "CarerID");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_PostId",
                table: "Pet",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PetPhoto_PhotosPhotoID",
                table: "PetPhoto",
                column: "PhotosPhotoID");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_PostId",
                table: "Photo",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_CarerID",
                table: "Post",
                column: "CarerID");

            migrationBuilder.CreateIndex(
                name: "IX_Reaction_PostId",
                table: "Reaction",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccine_CardVaccineId",
                table: "Vaccine",
                column: "CardVaccineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "CarerPet");

            migrationBuilder.DropTable(
                name: "CarerPhoto");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "PetPhoto");

            migrationBuilder.DropTable(
                name: "Reaction");

            migrationBuilder.DropTable(
                name: "Vaccine");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "CardVaccine");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Carer");
        }
    }
}
