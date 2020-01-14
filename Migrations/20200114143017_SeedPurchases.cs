using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterManagement.Migrations
{
    public partial class SeedPurchases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 14, 16, 30, 16, 601, DateTimeKind.Local).AddTicks(2140), new DateTime(2020, 1, 14, 16, 30, 16, 605, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 14, 16, 30, 16, 605, DateTimeKind.Local).AddTicks(2090), new DateTime(2020, 1, 14, 16, 30, 16, 605, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 14, 16, 30, 16, 605, DateTimeKind.Local).AddTicks(2120), new DateTime(2020, 1, 14, 16, 30, 16, 605, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 14, 16, 30, 16, 605, DateTimeKind.Local).AddTicks(2120), new DateTime(2020, 1, 14, 16, 30, 16, 605, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 14, 16, 30, 16, 605, DateTimeKind.Local).AddTicks(2130), new DateTime(2020, 1, 14, 16, 30, 16, 605, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "PurchaseNo", "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "341471579286296" },
                    { 3, new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "371172473010823" },
                    { 5, new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "340921234554117" },
                    { 6, new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, new DateTime(2019, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "378666663860619" },
                    { 8, new DateTime(2019, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "372675903118544" },
                    { 9, new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "346369552078109" },
                    { 10, new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "379811816360062" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseItems",
                columns: new[] { "Id", "Amount", "AmountReturned", "ItemId", "PurchaseId", "Returned" },
                values: new object[,]
                {
                    { 1, 54, 0, 1, 1, false },
                    { 18, 14, 0, 3, 9, false },
                    { 17, 20, 0, 2, 9, false },
                    { 16, 30, 0, 1, 8, false },
                    { 15, 3, 0, 5, 8, false },
                    { 14, 14, 0, 4, 7, false },
                    { 13, 23, 0, 3, 7, false },
                    { 12, 7, 0, 1, 6, false },
                    { 11, 15, 0, 2, 6, false },
                    { 10, 21, 0, 5, 5, false },
                    { 9, 22, 0, 4, 5, false },
                    { 8, 9, 0, 3, 4, false },
                    { 7, 43, 0, 2, 4, false },
                    { 6, 50, 0, 1, 3, false },
                    { 5, 16, 0, 5, 3, false },
                    { 4, 66, 0, 4, 2, false },
                    { 3, 55, 0, 3, 2, false },
                    { 2, 32, 0, 2, 1, false },
                    { 19, 7, 0, 4, 10, false },
                    { 20, 12, 0, 5, 10, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 10);

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
    }
}
