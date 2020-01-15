using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterManagement.Migrations
{
    public partial class removedseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 5);

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
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 22);

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

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 11);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "PurchaseNo", "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "371349659706917" },
                    { 3, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "341471579286296" },
                    { 4, new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "371172473010823" },
                    { 6, new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "340921234554117" },
                    { 7, new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, new DateTime(2019, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "378666663860619" },
                    { 9, new DateTime(2019, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "372675903118544" },
                    { 10, new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "346369552078109" },
                    { 11, new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "379811816360062" }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "Id", "Amount", "DateCreated", "DateModified", "ItemId" },
                values: new object[,]
                {
                    { 1, 500, new DateTime(2020, 1, 15, 13, 15, 45, 649, DateTimeKind.Local).AddTicks(3681), new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(5981), 1 },
                    { 2, 200, new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6579), new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6600), 2 },
                    { 3, 700, new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6618), new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6621), 3 },
                    { 4, 1000, new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6623), new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6626), 4 },
                    { 5, 1234, new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6629), new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6632), 5 }
                });

            migrationBuilder.InsertData(
                table: "PurchaseItems",
                columns: new[] { "Id", "Amount", "AmountReturned", "ItemId", "PurchaseId", "Returned" },
                values: new object[,]
                {
                    { 20, 14, 0, 3, 10, false },
                    { 19, 20, 0, 2, 10, false },
                    { 18, 30, 0, 1, 9, false },
                    { 17, 3, 0, 5, 9, false },
                    { 16, 14, 0, 4, 8, false },
                    { 15, 23, 0, 3, 8, false },
                    { 14, 7, 0, 1, 7, false },
                    { 13, 15, 0, 2, 7, false },
                    { 12, 21, 0, 5, 6, false },
                    { 11, 22, 0, 4, 6, false },
                    { 9, 43, 0, 2, 5, false },
                    { 21, 7, 0, 4, 11, false },
                    { 8, 50, 0, 1, 4, false },
                    { 7, 16, 0, 5, 4, false },
                    { 6, 66, 0, 4, 3, false },
                    { 5, 55, 0, 3, 3, false },
                    { 4, 32, 0, 2, 2, false },
                    { 3, 54, 0, 1, 2, false },
                    { 2, 32, 0, 2, 1, false },
                    { 1, 54, 0, 1, 1, false },
                    { 10, 9, 0, 3, 5, false },
                    { 22, 12, 0, 5, 11, false }
                });
        }
    }
}
