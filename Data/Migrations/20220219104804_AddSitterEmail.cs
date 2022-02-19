using Microsoft.EntityFrameworkCore.Migrations;

namespace test2.Data.Migrations
{
    public partial class AddSitterEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "SitterRequests");

            migrationBuilder.AddColumn<string>(
                name: "RequesterEmail",
                table: "SitterRequests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SitterEmail",
                table: "SitterRequests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "SitterRequests",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequesterEmail",
                table: "SitterRequests");

            migrationBuilder.DropColumn(
                name: "SitterEmail",
                table: "SitterRequests");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "SitterRequests");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SitterRequests",
                type: "TEXT",
                nullable: true);
        }
    }
}
