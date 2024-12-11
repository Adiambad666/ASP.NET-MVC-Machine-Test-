using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDemo.Migrations
{
    /// <inheritdoc />
    public partial class MigrationName8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Name_List_Category_Name_CategoryId",
                table: "Product_Name_List");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product_Name_List",
                table: "Product_Name_List");

            migrationBuilder.RenameTable(
                name: "Product_Name_List",
                newName: "Product_Name2");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Name_List_CategoryId",
                table: "Product_Name2",
                newName: "IX_Product_Name2_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product_Name2",
                table: "Product_Name2",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Name2_Category_Name_CategoryId",
                table: "Product_Name2",
                column: "CategoryId",
                principalTable: "Category_Name",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Name2_Category_Name_CategoryId",
                table: "Product_Name2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product_Name2",
                table: "Product_Name2");

            migrationBuilder.RenameTable(
                name: "Product_Name2",
                newName: "Product_Name_List");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Name2_CategoryId",
                table: "Product_Name_List",
                newName: "IX_Product_Name_List_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product_Name_List",
                table: "Product_Name_List",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Name_List_Category_Name_CategoryId",
                table: "Product_Name_List",
                column: "CategoryId",
                principalTable: "Category_Name",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
