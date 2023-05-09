using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fbs_webApi_v1.Migrations
{
    /// <inheritdoc />
    public partial class InitailCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_Id", "Email", "Name", "PhoneNumber", "password" },
                values: new object[,]
                {
                    { 1, "dummy1@gmail.com", "dummy1", "789654134", "asdf@1223" },
                    { 2, "dummy4@gmail.com", "dummy4", "789654134", "asdf@4443" },
                    { 3, "dummy3@gmail.com", "dummy3", "789648534", "asdf@3333" },
                    { 4, "dummy2@gmail.com", "dummy2", "789654789", "asdf@1123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
