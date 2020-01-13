using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterManagement.Migrations
{
    public partial class AddedReturnedBoolToPurchaseItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Returned",
                table: "PurchaseItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 12, 0, 31, 550, DateTimeKind.Local).AddTicks(4910), new DateTime(2020, 1, 13, 12, 0, 31, 552, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 12, 0, 31, 552, DateTimeKind.Local).AddTicks(8882), new DateTime(2020, 1, 13, 12, 0, 31, 552, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 12, 0, 31, 552, DateTimeKind.Local).AddTicks(8917), new DateTime(2020, 1, 13, 12, 0, 31, 552, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 12, 0, 31, 552, DateTimeKind.Local).AddTicks(8925), new DateTime(2020, 1, 13, 12, 0, 31, 552, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 13, 12, 0, 31, 552, DateTimeKind.Local).AddTicks(8931), new DateTime(2020, 1, 13, 12, 0, 31, 552, DateTimeKind.Local).AddTicks(8934) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Returned",
                table: "PurchaseItems");

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
    }
}
