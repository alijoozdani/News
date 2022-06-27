using Microsoft.EntityFrameworkCore.Migrations;

namespace News.DataLayer.Migrations
{
    public partial class migSubGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAvatar",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "GroupId1",
                table: "Blogs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_GroupId1",
                table: "Blogs",
                column: "GroupId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogGroups_GroupId1",
                table: "Blogs",
                column: "GroupId1",
                principalTable: "BlogGroups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogGroups_GroupId1",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_GroupId1",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "GroupId1",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "UserAvatar",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }
    }
}
