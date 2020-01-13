using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterManagement.Migrations
{
    public partial class AddedDeletedToInventoryAndItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Items",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Inventory",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
