using Microsoft.EntityFrameworkCore.Migrations;

namespace Baitkm.DAL.Migrations
{
    public partial class UserRatingchangeUserIdandGuestIdtobeNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_Guests_GuestId",
                table: "UserRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_Users_UserId",
                table: "UserRatings");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserRatings",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "GuestId",
                table: "UserRatings",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_Guests_GuestId",
                table: "UserRatings",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_Users_UserId",
                table: "UserRatings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_Guests_GuestId",
                table: "UserRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRatings_Users_UserId",
                table: "UserRatings");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserRatings",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GuestId",
                table: "UserRatings",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_Guests_GuestId",
                table: "UserRatings",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatings_Users_UserId",
                table: "UserRatings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
