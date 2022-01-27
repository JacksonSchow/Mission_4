using Microsoft.EntityFrameworkCore.Migrations;

namespace Film_Collection.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FormId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent_To = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FormId);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FormId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Horror", "James Wan", false, "Aaron", null, "PG-13", "Insidious", 2010 });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FormId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Sci-fi/Mystery/Thriller", "Christopher Nolan", false, null, "Dreams", "PG-13", "Inception", 2010 });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FormId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Animated", "Stephen Sandoval", false, null, null, "PG", "Tangled", 2010 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
