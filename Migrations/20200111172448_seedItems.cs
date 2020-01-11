using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterManagement.Migrations
{
    public partial class seedItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Cost",
                table: "Items",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Cost", "IsRefundable", "Name" },
                values: new object[,]
                {
                    { 1, 15.99, true, "T-Shirt" },
                    { 2, 5.9900000000000002, false, "Underwear" },
                    { 3, 60.990000000000002, true, "Denim jeans" },
                    { 4, 99.989999999999995, true, "Coat" },
                    { 5, 19.989999999999998, true, "Sweater" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "Items",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
