using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mountain_Trips_and_Landmarks.Migrations
{
    public partial class MountainGeterAddedToTracks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mountains",
                columns: table => new
                {
                    MountainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MountainPictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrekkingTime = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mountains", x => x.MountainId);
                });

            migrationBuilder.CreateTable(
                name: "Landmarks",
                columns: table => new
                {
                    LandmarksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandmarkPictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MountainId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landmarks", x => x.LandmarksId);
                    table.ForeignKey(
                        name: "FK_Landmarks_Mountains_MountainId",
                        column: x => x.MountainId,
                        principalTable: "Mountains",
                        principalColumn: "MountainId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Peaks",
                columns: table => new
                {
                    PeakId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MountainId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peaks", x => x.PeakId);
                    table.ForeignKey(
                        name: "FK_Peaks_Mountains_MountainId",
                        column: x => x.MountainId,
                        principalTable: "Mountains",
                        principalColumn: "MountainId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Landmarks_Mountains",
                columns: table => new
                {
                    LandmarkId = table.Column<int>(type: "int", nullable: false),
                    MountainId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landmarks_Mountains", x => new { x.LandmarkId, x.MountainId });
                    table.ForeignKey(
                        name: "FK_Landmarks_Mountains_Landmarks_LandmarkId",
                        column: x => x.LandmarkId,
                        principalTable: "Landmarks",
                        principalColumn: "LandmarksId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Landmarks_Mountains_Mountains_MountainId",
                        column: x => x.MountainId,
                        principalTable: "Mountains",
                        principalColumn: "MountainId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Peaks_Mountains",
                columns: table => new
                {
                    PeakId = table.Column<int>(type: "int", nullable: false),
                    MountainId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peaks_Mountains", x => new { x.PeakId, x.MountainId });
                    table.ForeignKey(
                        name: "FK_Peaks_Mountains_Mountains_MountainId",
                        column: x => x.MountainId,
                        principalTable: "Mountains",
                        principalColumn: "MountainId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Peaks_Mountains_Peaks_PeakId",
                        column: x => x.PeakId,
                        principalTable: "Peaks",
                        principalColumn: "PeakId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    TrackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Highlights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrackCategory = table.Column<int>(type: "int", nullable: false),
                    TrackCateogryURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MountainId = table.Column<int>(type: "int", nullable: true),
                    PeakId = table.Column<int>(type: "int", nullable: true),
                    LandmarksId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.TrackId);
                    table.ForeignKey(
                        name: "FK_Tracks_Landmarks_LandmarksId",
                        column: x => x.LandmarksId,
                        principalTable: "Landmarks",
                        principalColumn: "LandmarksId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tracks_Mountains_MountainId",
                        column: x => x.MountainId,
                        principalTable: "Mountains",
                        principalColumn: "MountainId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tracks_Peaks_PeakId",
                        column: x => x.PeakId,
                        principalTable: "Peaks",
                        principalColumn: "PeakId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tracks_Landmarks",
                columns: table => new
                {
                    TrackId = table.Column<int>(type: "int", nullable: false),
                    LandmarkId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks_Landmarks", x => new { x.TrackId, x.LandmarkId });
                    table.ForeignKey(
                        name: "FK_Tracks_Landmarks_Landmarks_LandmarkId",
                        column: x => x.LandmarkId,
                        principalTable: "Landmarks",
                        principalColumn: "LandmarksId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tracks_Landmarks_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "TrackId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tracks_Mountains",
                columns: table => new
                {
                    TrackId = table.Column<int>(type: "int", nullable: false),
                    MountainId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks_Mountains", x => new { x.TrackId, x.MountainId });
                    table.ForeignKey(
                        name: "FK_Tracks_Mountains_Mountains_MountainId",
                        column: x => x.MountainId,
                        principalTable: "Mountains",
                        principalColumn: "MountainId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tracks_Mountains_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "TrackId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tracks_Peaks",
                columns: table => new
                {
                    TrackId = table.Column<int>(type: "int", nullable: false),
                    PeakId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks_Peaks", x => new { x.TrackId, x.PeakId });
                    table.ForeignKey(
                        name: "FK_Tracks_Peaks_Peaks_PeakId",
                        column: x => x.PeakId,
                        principalTable: "Peaks",
                        principalColumn: "PeakId");
                    table.ForeignKey(
                        name: "FK_Tracks_Peaks_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "TrackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Landmarks_MountainId",
                table: "Landmarks",
                column: "MountainId");

            migrationBuilder.CreateIndex(
                name: "IX_Landmarks_Mountains_MountainId",
                table: "Landmarks_Mountains",
                column: "MountainId");

            migrationBuilder.CreateIndex(
                name: "IX_Peaks_MountainId",
                table: "Peaks",
                column: "MountainId");

            migrationBuilder.CreateIndex(
                name: "IX_Peaks_Mountains_MountainId",
                table: "Peaks_Mountains",
                column: "MountainId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_LandmarksId",
                table: "Tracks",
                column: "LandmarksId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_MountainId",
                table: "Tracks",
                column: "MountainId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_PeakId",
                table: "Tracks",
                column: "PeakId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_Landmarks_LandmarkId",
                table: "Tracks_Landmarks",
                column: "LandmarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_Mountains_MountainId",
                table: "Tracks_Mountains",
                column: "MountainId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_Peaks_PeakId",
                table: "Tracks_Peaks",
                column: "PeakId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Landmarks_Mountains");

            migrationBuilder.DropTable(
                name: "Peaks_Mountains");

            migrationBuilder.DropTable(
                name: "Tracks_Landmarks");

            migrationBuilder.DropTable(
                name: "Tracks_Mountains");

            migrationBuilder.DropTable(
                name: "Tracks_Peaks");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Landmarks");

            migrationBuilder.DropTable(
                name: "Peaks");

            migrationBuilder.DropTable(
                name: "Mountains");
        }
    }
}
