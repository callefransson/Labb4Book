using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb4Book.Migrations
{
    /// <inheritdoc />
    public partial class Changedclasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookRentDate",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookReturnDate",
                table: "Books");

            migrationBuilder.AddColumn<DateTime>(
                name: "BookRentDate",
                table: "BooksBook",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "BookReturnDate",
                table: "BooksBook",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookRentDate",
                table: "BooksBook");

            migrationBuilder.DropColumn(
                name: "BookReturnDate",
                table: "BooksBook");

            migrationBuilder.AddColumn<DateTime>(
                name: "BookRentDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "BookReturnDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
