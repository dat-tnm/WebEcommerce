using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class setPrimaryKey4JTProductAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_JTProductAttributes_ProductVariationId",
                table: "JTProductAttributes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JTProductAttributes",
                table: "JTProductAttributes",
                columns: new[] { "ProductVariationId", "AttributeId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JTProductAttributes",
                table: "JTProductAttributes");

            migrationBuilder.CreateIndex(
                name: "IX_JTProductAttributes_ProductVariationId",
                table: "JTProductAttributes",
                column: "ProductVariationId");
        }
    }
}
