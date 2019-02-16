using Microsoft.EntityFrameworkCore.Migrations;

namespace InternshipLibrary.Data.Migrations
{
    public partial class Bookschanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberOfBooks",
                table: "Books",
                newName: "NumberOfBooksBorrowed");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfBooksAvailable",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfBooksAvailable",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "NumberOfBooksBorrowed",
                table: "Books",
                newName: "NumberOfBooks");
        }
    }
}
