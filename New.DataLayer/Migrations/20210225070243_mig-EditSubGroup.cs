using Microsoft.EntityFrameworkCore.Migrations;

namespace News.DataLayer.Migrations
{
    public partial class migEditSubGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_SubGroup",
                table: "Blogs",
                column: "SubGroup");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogGroups_SubGroup",
                table: "Blogs",
                column: "SubGroup",
                principalTable: "BlogGroups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogGroups_SubGroup",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_SubGroup",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "GroupId1",
                table: "Blogs",
                type: "int",
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
    }
}
