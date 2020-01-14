using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterManagement.Migrations
{
    public partial class AddedAmountReturnedToPurchasedItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmountReturned",
                table: "PurchaseItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 14, 9, 4, 7, 784, DateTimeKind.Local).AddTicks(6920), new DateTime(2020, 1, 14, 9, 4, 7, 788, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 14, 9, 4, 7, 788, DateTimeKind.Local).AddTicks(5270), new DateTime(2020, 1, 14, 9, 4, 7, 788, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 14, 9, 4, 7, 788, DateTimeKind.Local).AddTicks(5300), new DateTime(2020, 1, 14, 9, 4, 7, 788, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 14, 9, 4, 7, 788, DateTimeKind.Local).AddTicks(5300), new DateTime(2020, 1, 14, 9, 4, 7, 788, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 14, 9, 4, 7, 788, DateTimeKind.Local).AddTicks(5310), new DateTime(2020, 1, 14, 9, 4, 7, 788, DateTimeKind.Local).AddTicks(5310) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountReturned",
                table: "PurchaseItems");

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
    }
}
