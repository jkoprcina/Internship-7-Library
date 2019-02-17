using Microsoft.EntityFrameworkCore.Migrations;

namespace InternshipLibrary.Data.Migrations
{
    public partial class Borrowingidnamechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BorrowingId",
                table: "Borrowings",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Borrowings",
                newName: "BorrowingId");
        }
    }
}
