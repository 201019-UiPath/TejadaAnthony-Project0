using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreAppDB.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_BaseballBats_BaseballBatsId",
                table: "Inventory");

            migrationBuilder.AlterColumn<int>(
                name: "BaseballBatsId",
                table: "Inventory",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_BaseballBats_BaseballBatsId",
                table: "Inventory",
                column: "BaseballBatsId",
                principalTable: "BaseballBats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_BaseballBats_BaseballBatsId",
                table: "Inventory");

            migrationBuilder.AlterColumn<int>(
                name: "BaseballBatsId",
                table: "Inventory",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_BaseballBats_BaseballBatsId",
                table: "Inventory",
                column: "BaseballBatsId",
                principalTable: "BaseballBats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
