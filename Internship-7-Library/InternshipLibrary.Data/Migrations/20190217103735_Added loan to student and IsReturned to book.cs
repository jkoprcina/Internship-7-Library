using Microsoft.EntityFrameworkCore.Migrations;

namespace InternshipLibrary.Data.Migrations
{
    public partial class AddedloantostudentandIsReturnedtobook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Loan",
                table: "Students",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "IsReturned",
                table: "Borrowings",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Loan",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "Borrowings");
        }
    }
}
