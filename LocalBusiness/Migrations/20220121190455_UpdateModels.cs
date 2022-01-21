using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusiness.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Businesss",
                table: "Businesss");

            migrationBuilder.RenameTable(
                name: "Businesss",
                newName: "Businesses");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Businesses",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "Businesses",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Businesses",
                table: "Businesses",
                column: "BusinessId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Businesses",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "Review",
                table: "Businesses");

            migrationBuilder.RenameTable(
                name: "Businesses",
                newName: "Businesss");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Businesss",
                newName: "description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Businesss",
                table: "Businesss",
                column: "BusinessId");
        }
    }
}
