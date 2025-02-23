using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccessDataLayer.Migrations
{
    /// <inheritdoc />
    public partial class removeSup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Products_SupId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SupId",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SupId",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupId",
                table: "Products",
                column: "SupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupId",
                table: "Products",
                column: "SupId",
                principalTable: "Suppliers",
                principalColumn: "SupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
