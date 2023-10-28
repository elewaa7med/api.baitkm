using Microsoft.EntityFrameworkCore.Migrations;

namespace Baitkm.DAL.Migrations
{
    public partial class removetablewatched : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Watcheds",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "GuestId",
                table: "Watcheds",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Watcheds_GuestId",
                table: "Watcheds",
                column: "GuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Watcheds_Guests_GuestId",
                table: "Watcheds",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Watcheds_Guests_GuestId",
                table: "Watcheds");

            migrationBuilder.DropIndex(
                name: "IX_Watcheds_GuestId",
                table: "Watcheds");

            migrationBuilder.DropColumn(
                name: "GuestId",
                table: "Watcheds");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Watcheds",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
