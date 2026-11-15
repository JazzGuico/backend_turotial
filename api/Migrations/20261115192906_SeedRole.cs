using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d9e7b21-6a4f-4f8c-b5d2-7c8e9f0a1b2c", "3d9e7b21-6a4f-4f8c-b5d2-7c8e9f0a1b2c", "User", "USER" },
                    { "8f2c1a4e-5b7d-4c3a-9e10-1a2b3c4d5e6f", "8f2c1a4e-5b7d-4c3a-9e10-1a2b3c4d5e6f", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d9e7b21-6a4f-4f8c-b5d2-7c8e9f0a1b2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f2c1a4e-5b7d-4c3a-9e10-1a2b3c4d5e6f");
        }
    }
}
