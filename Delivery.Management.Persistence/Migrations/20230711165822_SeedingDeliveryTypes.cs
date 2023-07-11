using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Delivery.Management.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDeliveryTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DeliveryAllocations",
                columns: new[] { "Id", "Section", "Warehouse" },
                values: new object[,]
                {
                    { 1, "1", "Warehouse 1" },
                    { 2, "2", "Warehouse 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeliveryAllocations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeliveryAllocations",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
