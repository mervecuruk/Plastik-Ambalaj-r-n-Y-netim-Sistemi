using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class AppMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d350d7bd-9ee9-4666-82ed-c9e07721e82b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2f9a83cd-699e-4332-86cf-4ed1f9f4c1bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "7560d895-b21b-47f8-a466-8c8c34aad633");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "6ce16950-67f8-4388-8302-0ba3f23a8026");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 12, 14, 15, 27, 52, 526, DateTimeKind.Local).AddTicks(8697), "38dbe9d5-fb00-4e38-a5de-0dbc0bc04bc9", "AQAAAAIAAYagAAAAEPf7IG/glCc6sTmSp2pc5iY+i8i3KP3NPRRTcz2pUiZMndEB3W7e1al8tTOLyijUnA==", "04f7202f-f2ec-43c7-94ec-44ae7c78265b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 126,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 127,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 128,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 129,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 130,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 131,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 132,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 133,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 134,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 135,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 136,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 137,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 138,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 139,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 140,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 141,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 142,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 143,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 144,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 145,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 146,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 147,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 148,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 149,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 150,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 151,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 152,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 153,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 154,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 155,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 156,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 157,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 158,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 159,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 160,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 161,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 162,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 163,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 164,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 165,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 166,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 167,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 168,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 169,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 170,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 171,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 172,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 173,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 174,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 175,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 176,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 177,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 178,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 179,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 180,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 181,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 182,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 183,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 184,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 185,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 186,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 187,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 188,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 189,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 190,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 191,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 192,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 193,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 194,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 195,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 196,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 197,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 198,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 199,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 200,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 201,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 202,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 203,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 204,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 205,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 206,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 207,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 208,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 209,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 210,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 211,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 212,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 213,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 214,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 215,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 216,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 217,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 218,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 219,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 220,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 221,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 222,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 223,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 224,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 225,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 226,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 227,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 228,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 229,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 230,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 231,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 232,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 233,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 234,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 235,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 236,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 237,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 238,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 239,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 240,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 241,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 242,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 243,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 244,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 245,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 246,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 247,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 248,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 249,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 250,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 251,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 252,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 253,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 254,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 255,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 256,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 257,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 258,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 259,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 260,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 261,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 262,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 263,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 264,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 265,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 266,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 267,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 268,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 269,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 270,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 271,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 272,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 273,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 274,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 275,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 276,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 277,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 278,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 279,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 280,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 281,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 282,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 283,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 284,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 285,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 286,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 287,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 288,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 289,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 290,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 291,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 292,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 293,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 294,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 295,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 296,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 297,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 298,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 299,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 300,
                column: "AddedDate",
                value: new DateTime(2024, 12, 14, 15, 27, 52, 591, DateTimeKind.Local).AddTicks(3070));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9d730eab-ebac-483c-902c-f09dd3165f18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c23c2937-9c99-4520-9d6d-3e146f226305");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "3c6ee69c-b1b8-4517-b0fd-514e4a677a0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "3c27820c-f7b0-4dc4-a7c7-a05574e75ece");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 823, DateTimeKind.Local).AddTicks(4448), "4d600d3a-5731-4f85-a4f9-9079177f0c41", "AQAAAAIAAYagAAAAEA2B4N2TU8a5R9I6mQ4LsMvcfrOz8HA/y3Y/yvVEdTuICXDC6QOwUrKdm9LLEIdJFQ==", "50654a19-a7f0-4c55-8a7e-34a45ff1c21d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 126,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 127,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 128,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 129,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 130,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 131,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 132,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 133,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 134,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 135,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 136,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 137,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 138,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 139,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 140,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 141,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 142,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 143,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 144,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 145,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 146,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 147,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 148,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 149,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 150,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 151,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 152,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 153,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 154,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 155,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 156,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 157,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 158,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 159,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 160,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 161,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 162,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 163,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 164,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 165,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 166,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 167,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 168,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 169,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 170,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 171,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 172,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 173,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 174,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 175,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 176,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 177,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 178,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 179,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 180,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 181,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 182,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 183,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 184,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 185,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 186,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 187,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 188,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 189,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 190,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 191,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 192,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 193,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 194,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 195,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 196,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 197,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 198,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 199,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 200,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 201,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 202,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 203,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 204,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 205,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 206,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 207,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 208,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 209,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 210,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 211,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 212,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 213,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 214,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 215,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 216,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 217,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 218,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 219,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 220,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 221,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 222,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 223,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 224,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 225,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 226,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 227,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 228,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 229,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 230,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 231,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 232,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 233,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 234,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 235,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 236,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 237,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 238,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 239,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 240,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 241,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 242,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 243,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 244,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 245,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 246,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 247,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 248,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 249,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 250,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 251,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 252,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 253,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 254,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 255,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 256,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 257,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 258,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 259,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 260,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 261,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 262,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 263,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 264,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 265,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 266,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 267,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 268,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 269,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 270,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 271,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 272,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 273,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 274,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 275,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 276,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 277,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 278,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 279,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 280,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 281,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 282,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 283,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 284,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 285,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 286,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 287,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 288,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 289,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 290,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 291,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 292,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 293,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 294,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 295,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 296,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 297,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 298,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 299,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 300,
                column: "AddedDate",
                value: new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(208));
        }
    }
}
