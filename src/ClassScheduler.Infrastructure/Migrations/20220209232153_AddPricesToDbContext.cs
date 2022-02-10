using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassScheduler.Infrastructure.Migrations
{
    public partial class AddPricesToDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Price_Classes_ClassId",
                table: "Price");

            migrationBuilder.DropForeignKey(
                name: "FK_Price_Currencies_CurrencyId",
                table: "Price");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Price",
                table: "Price");

            migrationBuilder.RenameTable(
                name: "Price",
                newName: "Prices");

            migrationBuilder.RenameIndex(
                name: "IX_Price_CurrencyId",
                table: "Prices",
                newName: "IX_Prices_CurrencyId");

            migrationBuilder.RenameIndex(
                name: "IX_Price_ClassId",
                table: "Prices",
                newName: "IX_Prices_ClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prices",
                table: "Prices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_Classes_ClassId",
                table: "Prices",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_Currencies_CurrencyId",
                table: "Prices",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prices_Classes_ClassId",
                table: "Prices");

            migrationBuilder.DropForeignKey(
                name: "FK_Prices_Currencies_CurrencyId",
                table: "Prices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prices",
                table: "Prices");

            migrationBuilder.RenameTable(
                name: "Prices",
                newName: "Price");

            migrationBuilder.RenameIndex(
                name: "IX_Prices_CurrencyId",
                table: "Price",
                newName: "IX_Price_CurrencyId");

            migrationBuilder.RenameIndex(
                name: "IX_Prices_ClassId",
                table: "Price",
                newName: "IX_Price_ClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Price",
                table: "Price",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Price_Classes_ClassId",
                table: "Price",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Price_Currencies_CurrencyId",
                table: "Price",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
