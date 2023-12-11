using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacMP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeetingPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConductingLeader = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PresidingLeader = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OpeningHymn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningPrayer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SacramentHymn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    speakerOne = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    speakerTwo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MusicalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    speakerThree = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    speakerFour = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClosingHymn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingPrayer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingPlan", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetingPlan");
        }
    }
}
