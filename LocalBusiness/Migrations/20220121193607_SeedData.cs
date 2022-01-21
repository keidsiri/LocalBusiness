using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusiness.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Description", "Location", "Name", "Rating", "Review", "Type" },
                values: new object[,]
                {
                    { 1, "Classic American", "Belltown", "El Gacho", 9, "Excellent", "Restaurant" },
                    { 2, "Modern Japanese", "Downtown", "Japonessa", 7, "Great", "Restaurant" },
                    { 3, "Mexican", "Fremont", "Red Star Tacos", 5, "Mediocre", "Restaurant" },
                    { 4, "Fresh produces", "White center", "Juan Garden", 8, "Excellent", "Local Produce" },
                    { 5, "Plant Shop ", "White Center", "The Plant Store", 8, "Excellent", "Local Shop" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);
        }
    }
}
