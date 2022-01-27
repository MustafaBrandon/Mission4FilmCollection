using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmCollection.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilmTitle = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    FilmYear = table.Column<int>(nullable: false),
                    FilmDirector = table.Column<string>(nullable: false),
                    FilmRating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.FilmId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "FilmId", "Category", "Edited", "FilmDirector", "FilmRating", "FilmTitle", "FilmYear", "LentTo", "Notes" },
                values: new object[] { 1, "Action/Adventure", false, "George Lucas", "PG", "Indiana Jones and the Raiders of the Lost Ark", 1981, "", "" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "FilmId", "Category", "Edited", "FilmDirector", "FilmRating", "FilmTitle", "FilmYear", "LentTo", "Notes" },
                values: new object[] { 2, "Action/Adventure", false, "Gore Verbinski", "PG-13", "Pirates of the Caribbean: The Curse of the Black Pearl", 2003, "", "" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "FilmId", "Category", "Edited", "FilmDirector", "FilmRating", "FilmTitle", "FilmYear", "LentTo", "Notes" },
                values: new object[] { 3, "Adventure/Romance", false, "Kevin Reynolds", "PG-13", "The Count of Monte Cristo", 2002, "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
