using Microsoft.EntityFrameworkCore.Migrations;

namespace News.DataLayer.Migrations
{
    public partial class migComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_Users_UserId",
                table: "BlogComments");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "BlogComments",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "BlogComments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BlogComments",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_Users_UserId",
                table: "BlogComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_Users_UserId",
                table: "BlogComments");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "BlogComments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BlogComments");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "BlogComments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_Users_UserId",
                table: "BlogComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
