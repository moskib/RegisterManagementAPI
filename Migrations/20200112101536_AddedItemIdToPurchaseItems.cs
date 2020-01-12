using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterManagement.Migrations
{
    public partial class AddedItemIdToPurchaseItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 12, 15, 35, 689, DateTimeKind.Local).AddTicks(1393), new DateTime(2020, 1, 12, 12, 15, 35, 691, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 12, 15, 35, 691, DateTimeKind.Local).AddTicks(5695), new DateTime(2020, 1, 12, 12, 15, 35, 691, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 12, 15, 35, 691, DateTimeKind.Local).AddTicks(5728), new DateTime(2020, 1, 12, 12, 15, 35, 691, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 12, 15, 35, 691, DateTimeKind.Local).AddTicks(5733), new DateTime(2020, 1, 12, 12, 15, 35, 691, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 12, 15, 35, 691, DateTimeKind.Local).AddTicks(5739), new DateTime(2020, 1, 12, 12, 15, 35, 691, DateTimeKind.Local).AddTicks(5741) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 12, 2, 47, 406, DateTimeKind.Local).AddTicks(5272), new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9617), new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9649), new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9655), new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9660), new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9663) });
        }
    }
}
