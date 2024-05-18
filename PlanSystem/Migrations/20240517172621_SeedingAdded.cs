using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlanSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedingAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsReadonly", "Password", "UserName" },
                values: new object[] { 1, false, "123", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
