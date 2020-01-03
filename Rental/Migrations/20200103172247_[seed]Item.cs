using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Migrations
{
    public partial class seedItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "ItemID", "Detail", "ExpireTime", "PostTime", "Price", "Title" },
                values: new object[] { 1, "details1", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200, "item1" });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "ItemID", "Detail", "ExpireTime", "PostTime", "Price", "Title" },
                values: new object[] { 2, "details2", new DateTime(2020, 7, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "item2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "ItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "ItemID",
                keyValue: 2);
        }
    }
}
