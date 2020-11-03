using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreAppDB.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Locations_LocationId",
                table: "Inventory");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Inventory",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Locations_LocationId",
                table: "Inventory",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Locations_LocationId",
                table: "Inventory");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Inventory",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Locations_LocationId",
                table: "Inventory",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
