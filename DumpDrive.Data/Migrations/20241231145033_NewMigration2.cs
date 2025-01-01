using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DumpDrive.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Files",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "My resume. Lorem ipsum.");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "Image of a holiday memory!");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "Never Gonna Give You Up");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: "Movie: Interstellar");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: "Plan for a project.");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: "A presentation about my project.");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 7,
                column: "Content",
                value: "Report number 6.");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 8,
                column: "Content",
                value: "Here are saved some important documents.");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 9,
                column: "Content",
                value: "Seed data for my database.");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 10,
                column: "Content",
                value: "Week 1: Number of working hours - 40\nWeek 2: Number of working hours - 38");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 11,
                column: "Content",
                value: "The game was fun to play but too many bad huys to fight");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 12,
                column: "Content",
                value: "Cookies: 2 eggs, flour, water, vanilla extract");

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 13,
                column: "Content",
                value: "Lorem ipsum.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "pass1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "pass2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "pass3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "pass4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Password", "Username" },
                values: new object[] { "leo@ffst.hr", "pass5", "leo" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "Password", "Username" },
                values: new object[] { "hana@pmfst.chr", "pass6", "hana" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Files");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "password123");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "password456");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "pass9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "pass7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Password", "Username" },
                values: new object[] { "marko@gmail.com", "marko123", "marko" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "Password", "Username" },
                values: new object[] { "petra@gmail.com", "petra456", "petra" });
        }
    }
}
