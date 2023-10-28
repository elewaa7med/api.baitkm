using Microsoft.EntityFrameworkCore.Migrations;

namespace Baitkm.DAL.Migrations
{
    public partial class selfRelationAnnouncment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnnouncmentId",
                table: "Announcements",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_AnnouncmentId",
                table: "Announcements",
                column: "AnnouncmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_Announcements_AnnouncmentId",
                table: "Announcements",
                column: "AnnouncmentId",
                principalTable: "Announcements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_Announcements_AnnouncmentId",
                table: "Announcements");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_AnnouncmentId",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "AnnouncmentId",
                table: "Announcements");
        }
    }
}
