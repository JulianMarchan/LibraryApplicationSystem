using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApplicationSystem.Migrations
{
    /// <inheritdoc />
    public partial class studentcontactnumberdatatype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "StudentContactNumber",
                table: "Students",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StudentContactNumber",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
