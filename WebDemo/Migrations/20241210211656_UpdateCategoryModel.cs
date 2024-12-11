using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDemo.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoryModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Product_Name_List",
                newName: "NewProductId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Category_Name",
                newName: "NewCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NewProductId",
                table: "Product_Name_List",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "NewCategoryId",
                table: "Category_Name",
                newName: "CategoryId");
        }
    }
}
