using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8614b6dc-412c-4e04-86a6-bd8af63a874e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Dob", "PasswordHash" },
                values: new object[] { "ea5e50f6-90e5-4b55-bdd7-6fb62c0800f4", new DateTime(2020, 10, 2, 13, 40, 11, 852, DateTimeKind.Local).AddTicks(2291), "AQAAAAEAACcQAAAAEMbJXg8hlJp28tim3BOD0vtKyUA9pZh6pHfThGOzw7xeyd1lxBXf2wmymuX4zkrwBQ==" });

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
                value: new DateTime(2020, 10, 2, 13, 40, 11, 817, DateTimeKind.Local).AddTicks(1753));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

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
        }
    }
}
