using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterManagement.Migrations
{
    public partial class ChangedItemToVirtualInInventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 10, 50, 42, 550, DateTimeKind.Local).AddTicks(4176), new DateTime(2020, 1, 12, 10, 50, 42, 552, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 10, 50, 42, 552, DateTimeKind.Local).AddTicks(8356), new DateTime(2020, 1, 12, 10, 50, 42, 552, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 10, 50, 42, 552, DateTimeKind.Local).AddTicks(8391), new DateTime(2020, 1, 12, 10, 50, 42, 552, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 10, 50, 42, 552, DateTimeKind.Local).AddTicks(8397), new DateTime(2020, 1, 12, 10, 50, 42, 552, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 12, 10, 50, 42, 552, DateTimeKind.Local).AddTicks(8403), new DateTime(2020, 1, 12, 10, 50, 42, 552, DateTimeKind.Local).AddTicks(8405) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 11, 20, 30, 39, 536, DateTimeKind.Local).AddTicks(5810), new DateTime(2020, 1, 11, 20, 30, 39, 540, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 11, 20, 30, 39, 540, DateTimeKind.Local).AddTicks(5640), new DateTime(2020, 1, 11, 20, 30, 39, 540, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 11, 20, 30, 39, 540, DateTimeKind.Local).AddTicks(5670), new DateTime(2020, 1, 11, 20, 30, 39, 540, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 11, 20, 30, 39, 540, DateTimeKind.Local).AddTicks(5670), new DateTime(2020, 1, 11, 20, 30, 39, 540, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 11, 20, 30, 39, 540, DateTimeKind.Local).AddTicks(5670), new DateTime(2020, 1, 11, 20, 30, 39, 540, DateTimeKind.Local).AddTicks(5670) });
        }
    }
}
