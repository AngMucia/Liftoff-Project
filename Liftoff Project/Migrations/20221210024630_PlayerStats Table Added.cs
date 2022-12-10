using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Liftoff_Project.Migrations
{
    public partial class PlayerStatsTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerStats",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SubIns = table.Column<string>(nullable: true),
                    Total_PlayTime_min = table.Column<string>(nullable: true),
                    AveragePlayTime_min = table.Column<string>(nullable: true),
                    FoulsCommitted = table.Column<string>(nullable: true),
                    FoulsSuffered = table.Column<string>(nullable: true),
                    OwnGoals = table.Column<string>(nullable: true),
                    OffSides = table.Column<string>(nullable: true),
                    RedCards = table.Column<string>(nullable: true),
                    YellowCards = table.Column<string>(nullable: true),
                    GoalAssists = table.Column<string>(nullable: true),
                    ShotsOnTarget = table.Column<string>(nullable: true),
                    TotalShots = table.Column<string>(nullable: true),
                    TotalGoals = table.Column<string>(nullable: true),
                    GoalsConceded = table.Column<string>(nullable: true),
                    Saves = table.Column<string>(nullable: true),
                    ShotsFaced = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerStats", x => x.PlayerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerStats");
        }
    }
}
