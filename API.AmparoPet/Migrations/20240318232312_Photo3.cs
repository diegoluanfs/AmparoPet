using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.AmparoPet.Migrations
{
    public partial class Photo3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Address_AddressID",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_AddressID",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "Post");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "Post",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Post_AddressID",
                table: "Post",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Address_AddressID",
                table: "Post",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "AddressID");
        }
    }
}
