using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class firstDeneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_AspNetUsers_AppUserId",
                table: "Blog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog",
                table: "Blog");

            migrationBuilder.RenameTable(
                name: "Blog",
                newName: "Blogs");

            migrationBuilder.RenameIndex(
                name: "IX_Blog_AppUserId",
                table: "Blogs",
                newName: "IX_Blogs_AppUserId");

            migrationBuilder.AddColumn<bool>(
                name: "RefundCustomerService",
                table: "OfferCarts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "BlogId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "64c5ef28-8902-430e-9a6c-d3a85c3f3a7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f53f445c-773a-4d17-add4-f079d74bb866");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1b4025fe-f7b4-4357-b9eb-f47e8d887670");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "26924cf7-9597-4473-a9fd-8ace6ff96f42");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 730, DateTimeKind.Local).AddTicks(2047), "5347b8a4-69a8-4213-8b6b-e37e6d25f34b", "AQAAAAIAAYagAAAAEHOivcbV/34+DBBwjBVfA5oSi4ECtJDf3my8R0bxh8aZFZw7bF/VfgNuDrq/eBlHfQ==", "0e1b9d66-e68e-4d6b-8912-894e4d956a72" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 126,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 127,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 128,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 129,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 130,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 131,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 132,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 133,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 134,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 135,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 136,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 137,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 138,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 139,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 140,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 141,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 142,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 143,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 144,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 145,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 146,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 147,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 148,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 149,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 150,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 151,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 152,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 153,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 154,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 155,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 156,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 157,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 158,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 159,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 160,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 161,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 162,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 163,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 164,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 165,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 166,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 167,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 168,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 169,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 170,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 171,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 172,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 173,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 174,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 175,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 176,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 177,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 178,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 179,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 180,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 181,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 182,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 183,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 184,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 185,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 186,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 187,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 188,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 189,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 190,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 191,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 192,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 193,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 194,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 195,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 196,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 197,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 198,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 199,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 200,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 201,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 202,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 203,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 204,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 205,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 206,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 207,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 208,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 209,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 210,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 211,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 212,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 213,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 214,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 215,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 216,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 217,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 218,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 219,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 220,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 221,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 222,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 223,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 224,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 225,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 226,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 227,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 228,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 229,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 230,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 231,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 232,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 233,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 234,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 235,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 236,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 237,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 238,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 239,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 240,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 241,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 242,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 243,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 244,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 245,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 246,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 247,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 248,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 249,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 250,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 251,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 252,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 253,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 254,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 255,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 256,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 257,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 258,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 259,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 260,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 261,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 262,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 263,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 264,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 265,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 266,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 267,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 268,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 269,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 270,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 271,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 272,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 273,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 274,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 275,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 276,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 277,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 278,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 279,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 280,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 281,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 282,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 283,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 284,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 285,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 286,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 287,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 288,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 289,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 290,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 291,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 292,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 293,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 294,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 295,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 296,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 297,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 298,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 299,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 300,
                column: "AddedDate",
                value: new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_AppUserId",
                table: "Blogs",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_AppUserId",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "RefundCustomerService",
                table: "OfferCarts");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Blog");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_AppUserId",
                table: "Blog",
                newName: "IX_Blog_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog",
                table: "Blog",
                column: "BlogId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "27d400f9-be8c-4a97-8289-1409d364a786");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fb2acdbc-ddd8-4aee-96fc-c91448789720");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "0b322c31-d340-4d74-8ecf-478bf3adeadc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "c8e467dd-4ad0-4350-86b5-20e056e289dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 9, 26, 13, 46, 4, 703, DateTimeKind.Local).AddTicks(9538), "ae705d31-e9dc-4554-9373-b9b566d4feb9", "AQAAAAIAAYagAAAAENGe0aXGZq1EO6BnUiMfQ5FHnS0LWOvbvvJUQ0AMbhPywJaD44sq2gMLs6Q+VxzJng==", "c9f3381c-7e5b-4652-8015-1c50362abedb" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 126,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 127,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 128,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 129,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 130,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 131,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 132,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 133,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 134,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 135,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 136,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 137,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 138,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 139,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 140,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 141,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 142,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 143,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 144,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 145,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 146,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 147,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 148,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 149,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 150,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 151,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 152,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 153,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 154,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 155,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 156,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 157,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 158,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 159,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 160,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 161,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 162,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 163,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 164,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 165,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 166,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 167,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 168,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 169,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 170,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 171,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 172,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 173,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 174,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 175,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 176,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 177,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 178,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 179,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 180,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 181,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 182,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 183,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 184,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 185,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 186,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 187,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 188,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 189,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 190,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 191,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 192,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 193,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 194,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 195,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 196,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 197,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 198,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 199,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 200,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 201,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 202,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 203,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 204,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 205,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 206,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 207,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 208,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 209,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 210,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 211,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 212,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 213,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 214,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 215,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 216,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 217,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 218,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 219,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 220,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 221,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 222,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 223,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 224,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 225,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 226,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 227,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 228,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 229,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 230,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 231,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 232,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 233,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 234,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 235,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 236,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 237,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 238,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 239,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 240,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 241,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 242,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 243,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 244,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 245,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 246,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 247,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 248,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 249,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 250,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 251,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 252,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 253,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 254,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 255,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 256,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 257,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 258,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 259,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 260,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 261,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 262,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 263,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 264,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 265,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 266,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 267,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 268,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 269,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 270,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 271,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 272,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 273,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 274,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 275,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 276,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 277,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 278,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 279,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 280,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 281,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 282,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 283,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 284,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 285,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 286,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 287,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 288,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 289,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 290,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 291,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 292,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 293,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 294,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 295,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 296,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 297,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 298,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 299,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 300,
                column: "AddedDate",
                value: new DateTime(2024, 9, 26, 13, 46, 4, 773, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_AspNetUsers_AppUserId",
                table: "Blog",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
