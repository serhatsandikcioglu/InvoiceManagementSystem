using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedresident1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Residents_ApartmentId",
                table: "Residents",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Residents_UserId",
                table: "Residents",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Apartments_ApartmentId",
                table: "Residents",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Users_UserId",
                table: "Residents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Apartments_ApartmentId",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Users_UserId",
                table: "Residents");

            migrationBuilder.DropIndex(
                name: "IX_Residents_ApartmentId",
                table: "Residents");

            migrationBuilder.DropIndex(
                name: "IX_Residents_UserId",
                table: "Residents");
        }
    }
}
