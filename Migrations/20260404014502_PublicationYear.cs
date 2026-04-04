using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_manager.Migrations
{
    /// <inheritdoc />
    public partial class PublicationYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublicationDate",
                table: "Books",
                newName: "PublicationYear");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublicationYear",
                table: "Books",
                newName: "PublicationDate");
        }
    }
}
