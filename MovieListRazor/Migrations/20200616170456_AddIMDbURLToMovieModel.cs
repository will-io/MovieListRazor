using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieListRazor.Migrations
{
    public partial class AddIMDbURLToMovieModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IMDbURL",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IMDbURL",
                table: "Movie");
        }
    }
}
