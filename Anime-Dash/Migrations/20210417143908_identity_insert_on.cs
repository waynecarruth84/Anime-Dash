using Microsoft.EntityFrameworkCore.Migrations;

namespace Anime_Dash.Migrations
{
    public partial class identity_insert_on : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
               SET IDENTITY_INSERT [dbo].[AnimeItems] ON;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
