using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassScheduler.Infrastructure.Migrations
{
    public partial class AddPriceEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Currencies_CurrencyId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_CurrencyId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Classes");

            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    End = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    CurrencyId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClassId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Price_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Price_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Price_ClassId",
                table: "Price",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_CurrencyId",
                table: "Price",
                column: "CurrencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Price");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "Classes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Classes",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_CurrencyId",
                table: "Classes",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Currencies_CurrencyId",
                table: "Classes",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
