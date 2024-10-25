using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "Guid", "Mail", "Password" },
                values: new object[,]
                {
                    { 1L, new Guid("31cfc9fe-6dea-4831-8841-3bfcd73a3389"), "user1@example.com", "password1" },
                    { 2L, new Guid("d6f78320-8f4a-47fa-a6fa-7d5093b1da68"), "user2@example.com", "password2" },
                    { 3L, new Guid("caa24e64-60d6-4456-be89-1760851bb1a7"), "user3@example.com", "password3" },
                    { 4L, new Guid("0c1206dd-b2a8-422b-a785-3649fcf29de8"), "user4@example.com", "password4" },
                    { 5L, new Guid("b1d251e6-fc77-454c-b30e-ab408a642951"), "user5@example.com", "password5" }
                });

            migrationBuilder.InsertData(
                table: "Administrators",
                columns: new[] { "IdAdministrator", "Guid", "IdUser" },
                values: new object[] { 1L, new Guid("00000000-0000-0000-0000-000000000000"), 3L });

            migrationBuilder.InsertData(
                table: "Educators",
                columns: new[] { "IdEducator", "Approved", "Guid", "IdUser" },
                values: new object[] { 1L, false, new Guid("00000000-0000-0000-0000-000000000000"), 2L });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "IdStudent", "Guid", "IdUser" },
                values: new object[] { 1L, new Guid("94e3b456-0cba-4ba7-af64-f0c247a14e2e"), 1L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Administrators",
                keyColumn: "IdAdministrator",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Educators",
                keyColumn: "IdEducator",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "IdStudent",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 3L);
        }
    }
}
