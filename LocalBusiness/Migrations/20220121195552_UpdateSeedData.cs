using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusiness.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Name", "Rating", "Review" },
                values: new object[] { "Classic American", "Belltown", "El Gacho", 9, "Excellent" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3,
                columns: new[] { "Description", "Location", "Name", "Rating", "Review" },
                values: new object[] { "Modern Japanese", "Downtown", "Japonessa", 7, "Great" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4,
                columns: new[] { "Description", "Location", "Name", "Rating", "Review", "Type" },
                values: new object[] { "Mexican", "Fremont", "Red Star Tacos", 5, "Mediocre", "Restaurant" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5,
                columns: new[] { "Description", "Location", "Name", "Type" },
                values: new object[] { "Fresh produces", "White center", "Juan Garden", "Local Produce" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Description", "Location", "Name", "Rating", "Review", "Type" },
                values: new object[] { 6, "Plant Shop ", "White Center", "The Plant Store", 8, "Excellent", "Local Shop" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Name", "Rating", "Review" },
                values: new object[] { "Modern Japanese", "Downtown", "Japonessa", 7, "Great" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3,
                columns: new[] { "Description", "Location", "Name", "Rating", "Review" },
                values: new object[] { "Mexican", "Fremont", "Red Star Tacos", 5, "Mediocre" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4,
                columns: new[] { "Description", "Location", "Name", "Rating", "Review", "Type" },
                values: new object[] { "Fresh produces", "White center", "Juan Garden", 8, "Excellent", "Local Produce" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5,
                columns: new[] { "Description", "Location", "Name", "Type" },
                values: new object[] { "Plant Shop ", "White Center", "The Plant Store", "Local Shop" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Description", "Location", "Name", "Rating", "Review", "Type" },
                values: new object[] { 1, "Classic American", "Belltown", "El Gacho", 9, "Excellent", "Restaurant" });
        }
    }
}
