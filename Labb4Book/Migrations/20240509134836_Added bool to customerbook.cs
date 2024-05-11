using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb4Book.Migrations
{
    /// <inheritdoc />
    public partial class Addedbooltocustomerbook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReturned",
                table: "CustomerBooks",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "CustomerBooks");
        }
    }
}
