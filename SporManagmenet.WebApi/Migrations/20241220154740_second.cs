using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SporManagmenet.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Coaches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_TeamId",
                table: "Coaches",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coaches_Teams_TeamId",
                table: "Coaches",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coaches_Teams_TeamId",
                table: "Coaches");

            migrationBuilder.DropIndex(
                name: "IX_Coaches_TeamId",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Coaches");
        }
    }
}
