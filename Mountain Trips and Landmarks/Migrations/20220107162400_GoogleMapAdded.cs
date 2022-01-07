using Microsoft.EntityFrameworkCore.Migrations;

namespace Mountain_Trips_and_Landmarks.Migrations
{
    public partial class GoogleMapAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "Tracks",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "Tracks",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Tracks");
        }
    }
}
