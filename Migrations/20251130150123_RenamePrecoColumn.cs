using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apifuncional.Migrations
{
    /// <inheritdoc />
    public partial class RenamePrecoColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Preço",
                table: "Produtos",
                newName: "Preco");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produtos",
                newName: "Preço");
        }
    }
}
