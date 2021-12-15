using Microsoft.EntityFrameworkCore.Migrations;

namespace Mountain_Trips_and_Landmarks.Migrations
{
    public partial class UpdatedAdventureItem_AddedTripDaysMakedToStringForExpiredDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TripDays",
                table: "SelectorAdventureItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TripDays",
                table: "SelectorAdventureItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
