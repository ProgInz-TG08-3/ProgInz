using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetupAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Password = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Mail = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    IdAdministrator = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdUser = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.IdAdministrator);
                    table.ForeignKey(
                        name: "FK_Administrators_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educators",
                columns: table => new
                {
                    IdEducator = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    Approved = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educators", x => x.IdEducator);
                    table.ForeignKey(
                        name: "FK_Educators_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviewers",
                columns: table => new
                {
                    IdReviewer = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdUser = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviewers", x => x.IdReviewer);
                    table.ForeignKey(
                        name: "FK_Reviewers_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    IdStudent = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdUser = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.IdStudent);
                    table.ForeignKey(
                        name: "FK_Students_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "Guid", "Mail", "Password" },
                values: new object[,]
                {
                    { 1L, new Guid("3cc8fcff-c2fe-4a9c-8412-bd187b4bc3b3"), "user1@example.com", "password1" },
                    { 2L, new Guid("6f61da29-a73a-4d25-a57f-d6eb8be8fc64"), "user2@example.com", "password2" },
                    { 3L, new Guid("ae3a7d57-b3d8-4972-a71d-97444bb7d119"), "user3@example.com", "password3" },
                    { 4L, new Guid("d0c4629d-3c33-4077-b279-310495f32dd6"), "user4@example.com", "password4" },
                    { 5L, new Guid("79ecc27e-8fe9-4a01-989e-3b2e5ba47203"), "user5@example.com", "password5" }
                });

            migrationBuilder.InsertData(
                table: "Administrators",
                columns: new[] { "IdAdministrator", "IdUser" },
                values: new object[] { 1L, 3L });

            migrationBuilder.InsertData(
                table: "Educators",
                columns: new[] { "IdEducator", "Approved", "IdUser" },
                values: new object[] { 1L, false, 2L });

            migrationBuilder.InsertData(
                table: "Reviewers",
                columns: new[] { "IdReviewer", "IdUser" },
                values: new object[] { 1L, 4L });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "IdStudent", "IdUser" },
                values: new object[] { 1L, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_Administrators_IdUser",
                table: "Administrators",
                column: "IdUser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Educators_IdUser",
                table: "Educators",
                column: "IdUser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviewers_IdUser",
                table: "Reviewers",
                column: "IdUser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_IdUser",
                table: "Students",
                column: "IdUser",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrators");

            migrationBuilder.DropTable(
                name: "Educators");

            migrationBuilder.DropTable(
                name: "Reviewers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
