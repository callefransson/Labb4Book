using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb4Book.Migrations
{
    /// <inheritdoc />
    public partial class changednameomdbsetcustomerbook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksBook_Books_FkBookId",
                table: "BooksBook");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksBook_Customers_FkCustomerId",
                table: "BooksBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksBook",
                table: "BooksBook");

            migrationBuilder.RenameTable(
                name: "BooksBook",
                newName: "CustomerBooks");

            migrationBuilder.RenameIndex(
                name: "IX_BooksBook_FkCustomerId",
                table: "CustomerBooks",
                newName: "IX_CustomerBooks_FkCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksBook_FkBookId",
                table: "CustomerBooks",
                newName: "IX_CustomerBooks_FkBookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerBooks",
                table: "CustomerBooks",
                column: "CustomerBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerBooks_Books_FkBookId",
                table: "CustomerBooks",
                column: "FkBookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerBooks_Customers_FkCustomerId",
                table: "CustomerBooks",
                column: "FkCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerBooks_Books_FkBookId",
                table: "CustomerBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerBooks_Customers_FkCustomerId",
                table: "CustomerBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerBooks",
                table: "CustomerBooks");

            migrationBuilder.RenameTable(
                name: "CustomerBooks",
                newName: "BooksBook");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerBooks_FkCustomerId",
                table: "BooksBook",
                newName: "IX_BooksBook_FkCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerBooks_FkBookId",
                table: "BooksBook",
                newName: "IX_BooksBook_FkBookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksBook",
                table: "BooksBook",
                column: "CustomerBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksBook_Books_FkBookId",
                table: "BooksBook",
                column: "FkBookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksBook_Customers_FkCustomerId",
                table: "BooksBook",
                column: "FkCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
