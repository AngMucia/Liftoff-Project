using Microsoft.EntityFrameworkCore.Migrations;

namespace Liftoff_Project.Migrations
{
    public partial class Brackettable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BracketId",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BracketUserId",
                table: "Teams",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Brackets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    BracketTeams = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brackets", x => new { x.Id, x.UserId });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_BracketId_BracketUserId",
                table: "Teams",
                columns: new[] { "BracketId", "BracketUserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Brackets_BracketId_BracketUserId",
                table: "Teams",
                columns: new[] { "BracketId", "BracketUserId" },
                principalTable: "Brackets",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Brackets_BracketId_BracketUserId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "Brackets");

            migrationBuilder.DropIndex(
                name: "IX_Teams_BracketId_BracketUserId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "BracketId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "BracketUserId",
                table: "Teams");
        }
    }
}
