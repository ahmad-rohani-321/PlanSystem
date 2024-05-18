using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlanSystem.Migrations
{
    /// <inheritdoc />
    public partial class PropertiesChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "East",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "North",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "South",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "West",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "PropertyNoInMap",
                table: "Properties",
                newName: "Unit");

            migrationBuilder.AddColumn<int>(
                name: "PropertyNo",
                table: "Properties",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Registration_PropertyId",
                table: "Registration",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_Properties_PropertyId",
                table: "Registration",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registration_Properties_PropertyId",
                table: "Registration");

            migrationBuilder.DropIndex(
                name: "IX_Registration_PropertyId",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "PropertyNo",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "Properties",
                newName: "PropertyNoInMap");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Properties",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "East",
                table: "Properties",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "North",
                table: "Properties",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Properties",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "South",
                table: "Properties",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "Properties",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "West",
                table: "Properties",
                type: "TEXT",
                nullable: true);
        }
    }
}
