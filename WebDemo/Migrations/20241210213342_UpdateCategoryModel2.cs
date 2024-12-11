using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDemo.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoryModel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NewProductId",
                table: "Product_Name_List",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "NewCategoryId",
                table: "Category_Name",
                newName: "CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "InputProductId",
                table: "Product_Name_List",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InputCategoryId",
                table: "Category_Name",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InputProductId",
                table: "Product_Name_List");

            migrationBuilder.DropColumn(
                name: "InputCategoryId",
                table: "Category_Name");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Product_Name_List",
                newName: "NewProductId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Category_Name",
                newName: "NewCategoryId");
        }
    }
}
