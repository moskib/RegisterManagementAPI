using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterManagement.Migrations
{
    public partial class AddedMoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 15, 13, 15, 45, 649, DateTimeKind.Local).AddTicks(3681), new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6579), new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6618), new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6623), new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6629), new DateTime(2020, 1, 15, 13, 15, 45, 651, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 54, 1 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 32, 2 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 55, 3 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 66, 4 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 16, 5 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 50, 1 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 43, 2 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 9, 3 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 22, 4 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 21, 5 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 15, 2 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 23, 3 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 14, 4 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 30, 1 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 20, 2 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 14, 3 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 2,
                columns: new[] { "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "371349659706917" });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 3,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "341471579286296" });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 4,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 5,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "371172473010823" });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 6,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "340921234554117" });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 7,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 8,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "378666663860619" });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 9,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "372675903118544" });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 10,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "346369552078109" });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "PurchaseNo", "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { 11, new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "379811816360062" });

            migrationBuilder.InsertData(
                table: "PurchaseItems",
                columns: new[] { "Id", "Amount", "AmountReturned", "ItemId", "PurchaseId", "Returned" },
                values: new object[,]
                {
                    { 21, 7, 0, 4, 11, false },
                    { 22, 12, 0, 5, 11, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 11);

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

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 55, 3 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 66, 4 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 16, 5 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 50, 1 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 43, 2 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 9, 3 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 22, 4 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 21, 5 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 15, 2 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 23, 3 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 14, 4 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 30, 1 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 20, 2 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 14, 3 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 7, 4 });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amount", "ItemId" },
                values: new object[] { 12, 5 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 2,
                columns: new[] { "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "341471579286296" });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 3,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 4,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "371172473010823" });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 5,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "340921234554117" });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 6,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 7,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "378666663860619" });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 8,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "372675903118544" });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 9,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "346369552078109" });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseNo",
                keyValue: 10,
                columns: new[] { "DateModified", "DateOfPurchase", "VisaNo" },
                values: new object[] { new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "379811816360062" });
        }
    }
}
