using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace News.DataLayer.Migrations
{
    public partial class initailContactUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgentAnswer",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "AnswerDate",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "IsPosted",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "ContactUs");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "ContactUs",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "ContactUs",
                maxLength: 400,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ResponseTime",
                table: "ContactUs",
                maxLength: 400,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ContactUs",
                maxLength: 800,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ContactUsForms",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 200, nullable: false),
                    Subject = table.Column<string>(maxLength: 40, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 800, nullable: false),
                    AgentAnswer = table.Column<string>(nullable: true),
                    IsPosted = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    AnswerDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsForms", x => x.ContactId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUsForms");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "ResponseTime",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "ContactUs");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "ContactUs",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AddColumn<string>(
                name: "AgentAnswer",
                table: "ContactUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AnswerDate",
                table: "ContactUs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "ContactUs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ContactUs",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "ContactUs",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPosted",
                table: "ContactUs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "ContactUs",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");
        }
    }
}
