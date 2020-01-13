using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterManagement.Migrations
{
    public partial class RemovedDeletedColumnForItemsAndInventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Inventory");

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 9, 49, 9, 513, DateTimeKind.Local).AddTicks(9666), new DateTime(2020, 1, 13, 9, 49, 9, 516, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 9, 49, 9, 516, DateTimeKind.Local).AddTicks(3604), new DateTime(2020, 1, 13, 9, 49, 9, 516, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 9, 49, 9, 516, DateTimeKind.Local).AddTicks(3640), new DateTime(2020, 1, 13, 9, 49, 9, 516, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 9, 49, 9, 516, DateTimeKind.Local).AddTicks(3647), new DateTime(2020, 1, 13, 9, 49, 9, 516, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 9, 49, 9, 516, DateTimeKind.Local).AddTicks(3653), new DateTime(2020, 1, 13, 9, 49, 9, 516, DateTimeKind.Local).AddTicks(3656) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Items",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Inventory",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 9, 23, 3, 219, DateTimeKind.Local).AddTicks(7250), new DateTime(2020, 1, 13, 9, 23, 3, 222, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 9, 23, 3, 222, DateTimeKind.Local).AddTicks(1900), new DateTime(2020, 1, 13, 9, 23, 3, 222, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 9, 23, 3, 222, DateTimeKind.Local).AddTicks(1933), new DateTime(2020, 1, 13, 9, 23, 3, 222, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 9, 23, 3, 222, DateTimeKind.Local).AddTicks(1938), new DateTime(2020, 1, 13, 9, 23, 3, 222, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 9, 23, 3, 222, DateTimeKind.Local).AddTicks(1944), new DateTime(2020, 1, 13, 9, 23, 3, 222, DateTimeKind.Local).AddTicks(1946) });
        }
    }
}
