using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Liftoff_Project.Migrations
{
    public partial class combineteamtoplayerandusertoteam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    Height_meter = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Citizenship = table.Column<string>(nullable: true),
                    Team = table.Column<string>(nullable: true),
                    Jersey = table.Column<int>(nullable: false),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    _Id = table.Column<string>(nullable: true),
                    Name_en = table.Column<string>(nullable: true),
                    Name_fa = table.Column<string>(nullable: true),
                    Flag = table.Column<string>(nullable: true),
                    Fifa_code = table.Column<string>(nullable: true),
                    Iso2 = table.Column<string>(nullable: true),
                    Groups = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team_Player",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    TeamId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team_Player", x => new { x.PlayerId, x.TeamId });
                    table.ForeignKey(
                        name: "FK_Team_Player_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Team_Player_Teams_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Favorite_Teams",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<int>(nullable: true),
                    TeamId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorite_Teams", x => new { x.UserId, x.TeamId });
                    table.ForeignKey(
                        name: "FK_Favorite_Teams_Teams_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Favorite_Teams_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_Teams_TeamId1",
                table: "Favorite_Teams",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_Teams_UserId1",
                table: "Favorite_Teams",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Team_Player_TeamId1",
                table: "Team_Player",
                column: "TeamId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorite_Teams");

            migrationBuilder.DropTable(
                name: "Team_Player");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
