using Microsoft.EntityFrameworkCore.Migrations;

namespace Mountain_Trips_and_Landmarks.Migrations
{
    public partial class UpdatedAdventureItem_AddedTripDays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TripDays",
                table: "SelectorAdventureItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TripDays",
                table: "SelectorAdventureItems");
        }
    }
}
