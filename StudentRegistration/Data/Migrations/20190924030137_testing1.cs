using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentRegistration.Data.Migrations
{
    public partial class testing1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "CellPh",
                table: "Student",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CellPh",
                table: "Student",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
