using Microsoft.EntityFrameworkCore.Migrations;

namespace Baitkm.DAL.Migrations
{
    public partial class removetablewatched2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Watcheds_Announcements_AnnouncementId",
                table: "Watcheds");

            migrationBuilder.DropForeignKey(
                name: "FK_Watcheds_Guests_GuestId",
                table: "Watcheds");

            migrationBuilder.DropForeignKey(
                name: "FK_Watcheds_Users_UserId",
                table: "Watcheds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Watcheds",
                table: "Watcheds");

            migrationBuilder.RenameTable(
                name: "Watcheds",
                newName: "Watched");

            migrationBuilder.RenameIndex(
                name: "IX_Watcheds_UserId",
                table: "Watched",
                newName: "IX_Watched_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Watcheds_GuestId",
                table: "Watched",
                newName: "IX_Watched_GuestId");

            migrationBuilder.RenameIndex(
                name: "IX_Watcheds_AnnouncementId",
                table: "Watched",
                newName: "IX_Watched_AnnouncementId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Watched",
                table: "Watched",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Watched_Announcements_AnnouncementId",
                table: "Watched",
                column: "AnnouncementId",
                principalTable: "Announcements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Watched_Guests_GuestId",
                table: "Watched",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Watched_Users_UserId",
                table: "Watched",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Watched_Announcements_AnnouncementId",
                table: "Watched");

            migrationBuilder.DropForeignKey(
                name: "FK_Watched_Guests_GuestId",
                table: "Watched");

            migrationBuilder.DropForeignKey(
                name: "FK_Watched_Users_UserId",
                table: "Watched");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Watched",
                table: "Watched");

            migrationBuilder.RenameTable(
                name: "Watched",
                newName: "Watcheds");

            migrationBuilder.RenameIndex(
                name: "IX_Watched_UserId",
                table: "Watcheds",
                newName: "IX_Watcheds_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Watched_GuestId",
                table: "Watcheds",
                newName: "IX_Watcheds_GuestId");

            migrationBuilder.RenameIndex(
                name: "IX_Watched_AnnouncementId",
                table: "Watcheds",
                newName: "IX_Watcheds_AnnouncementId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Watcheds",
                table: "Watcheds",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Watcheds_Announcements_AnnouncementId",
                table: "Watcheds",
                column: "AnnouncementId",
                principalTable: "Announcements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Watcheds_Guests_GuestId",
                table: "Watcheds",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Watcheds_Users_UserId",
                table: "Watcheds",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
