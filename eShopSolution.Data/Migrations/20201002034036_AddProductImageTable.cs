using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 1, 14, 23, 31, 971, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUsers",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 1, 14, 23, 31, 993, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "32c1a494-930a-4306-aa71-c3822bbb2b79");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Dob", "PasswordHash" },
                values: new object[] { "b10fdfa9-658a-4828-948a-ac104c782cbe", new DateTime(2020, 10, 2, 10, 40, 35, 362, DateTimeKind.Local).AddTicks(453), "AQAAAAEAACcQAAAAENpUq7LOqinsEZyc4JsdU5WJKIIticT82bSClmyhmCm2M39fh52cOepIMW1qxRxBlA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 2, 10, 40, 35, 320, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 1, 14, 23, 31, 971, DateTimeKind.Local).AddTicks(8512),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 1, 14, 23, 31, 993, DateTimeKind.Local).AddTicks(3588),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f9a9c45a-6d2f-4258-88d8-2593b7e156aa");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Dob", "PasswordHash" },
                values: new object[] { "6e969e00-ed0a-42b3-a71b-d5302fd3c36a", new DateTime(2020, 10, 1, 14, 23, 32, 30, DateTimeKind.Local).AddTicks(210), "AQAAAAEAACcQAAAAENDtbcHnsQIQoH14DZ66yrch1mQL0oLzaDd+m6eLPU7QLkVgqZOiW2VTa1hWofUglw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 1, 14, 23, 32, 0, DateTimeKind.Local).AddTicks(8876));
        }
    }
}
