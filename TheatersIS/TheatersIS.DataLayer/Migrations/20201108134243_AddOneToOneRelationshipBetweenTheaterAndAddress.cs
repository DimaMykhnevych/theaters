using Microsoft.EntityFrameworkCore.Migrations;

namespace TheatersIS.DataLayer.Migrations
{
    public partial class AddOneToOneRelationshipBetweenTheaterAndAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Theaters_AddressId",
                table: "Theaters");

            migrationBuilder.CreateIndex(
                name: "IX_Theaters_AddressId",
                table: "Theaters",
                column: "AddressId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Theaters_AddressId",
                table: "Theaters");

            migrationBuilder.CreateIndex(
                name: "IX_Theaters_AddressId",
                table: "Theaters",
                column: "AddressId");
        }
    }
}
