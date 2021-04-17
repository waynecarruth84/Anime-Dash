using Microsoft.EntityFrameworkCore.Migrations;

namespace Anime_Dash.Migrations
{
    public partial class update_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "AnimeItems",
                newName: "animeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "animeid",
                table: "AnimeItems",
                newName: "id");
        }
    }
}
