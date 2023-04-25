using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class add2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6f6b81d-29c6-4704-b10d-83f6e7b991bb", "AQAAAAEAACcQAAAAEA9U8OPWroXdL+Av9wIIhpgLdQfGtGrFFWnGDCnIIvBeTK56KwwRtyNtBTszj8zq4w==", "1f6baded-8c76-4b22-9196-a1288016068f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "561427ca-300d-445c-8305-bba70e43e400", "AQAAAAEAACcQAAAAEIJ6uqeuGoQFnA5cXDttZL3iZZDH+QzeCVo0/j/SN3k6DmLoZyBcmc4BMR605JrN9w==", "c2e88174-ff86-49db-b006-d188f9a8e359" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73a79e0d-b3b7-465f-b2cd-496f38f0b6b5", "AQAAAAEAACcQAAAAEIhXWKJmG5+F1xmF+CfbQUhjnE6969dDbDslD6of31NjrMKm94xbzspL1CA6emyKWg==", "98ae4636-ed09-4bf6-864d-0b4ce2d1bbba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd884bd5-0ea9-4dab-b745-1c00e416bb94", "AQAAAAEAACcQAAAAEEu0dJYzMDKq0iVG9Qy+d+gmKaiZuXtbwU4+WlRAmyL9yYIkQgQPjvJV03ZztuN4+Q==", "da7b8626-8bb7-404c-bbb1-d16b0ac82820" });
        }
    }
}
