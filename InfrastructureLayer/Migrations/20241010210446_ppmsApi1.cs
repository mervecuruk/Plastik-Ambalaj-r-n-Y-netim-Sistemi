using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class ppmsApi1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9364), "[\"1.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9376), "[\"2.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9379), "[\"3.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9382), "[\"4.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9385), "[\"5.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9388), "[\"6.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9391), "[\"7.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9393), "[\"8.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9404), "[\"9.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9407), "[\"10.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9410), "[\"11.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9412), "[\"12.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9415), "[\"13.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9417), "[\"14.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9420), "[\"15.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9423), "[\"16.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9425), "[\"17.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9428), "[\"18.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9431), "[\"19.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9434), "[\"20.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9436), "[\"21.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9439), "[\"22.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9445), "[\"23.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9447), "[\"24.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9450), "[\"25.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9453), "[\"26.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9456), "[\"27.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9458), "[\"28.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9461), "[\"29.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9464), "[\"30.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9466), "[\"31.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9469), "[\"32.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9472), "[\"33.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9474), "[\"34.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9477), "[\"35.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9480), "[\"36.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9482), "[\"37.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9485), "[\"38.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9488), "[\"39.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9496), "[\"40.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9499), "[\"41.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9501), "[\"42.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9504), "[\"43.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9507), "[\"44.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9509), "[\"45.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9512), "[\"46.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9515), "[\"47.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9518), "[\"48.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9523), "[\"49.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9526), "[\"50.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9529), "[\"51.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9531), "[\"52.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9534), "[\"53.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9536), "[\"54.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9539), "[\"55.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9541), "[\"56.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9544), "[\"57.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9547), "[\"58.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9549), "[\"59.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9552), "[\"60.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9554), "[\"61.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9557), "[\"62.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9559), "[\"63.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9562), "[\"64.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9564), "[\"65.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9567), "[\"66.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9569), "[\"67.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9572), "[\"68.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9575), "[\"69.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9577), "[\"70.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9584), "[\"71.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9587), "[\"72.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9590), "[\"73.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9593), "[\"74.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9595), "[\"137.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9598), "[\"75.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9601), "[\"76.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9604), "[\"77.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9606), "[\"78.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9609), "[\"79.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9611), "[\"80.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9614), "[\"81.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9616), "[\"82.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9619), "[\"83.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9621), "[\"84.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9624), "[\"85.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9626), "[\"86.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9629), "[\"87.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9632), "[\"88.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9634), "[\"89.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9637), "[\"90.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9639), "[\"91.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9642), "[\"92.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9644), "[\"93.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9647), "[\"94.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9649), "[\"95.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9652), "[\"96.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9654), "[\"97.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9657), "[\"98.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9659), "[\"99.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9662), "[\"100.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9670), "[\"101.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9673), "[\"102.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9675), "[\"103.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9678), "[\"104.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9680), "[\"105.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9683), "[\"106.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9685), "[\"107.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9688), "[\"108.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9690), "[\"109.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9693), "[\"110.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9695), "[\"111.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9698), "[\"112.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9700), "[\"113.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9703), "[\"114.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9706), "[\"115.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9708), "[\"116.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9711), "[\"117.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9713), "[\"118.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9716), "[\"119.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9718), "[\"120.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9721), "[\"121.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9723), "[\"122.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9726), "[\"123.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9728), "[\"124.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 126,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9731), "[\"125.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 127,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9734), "[\"126.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 128,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9736), "[\"127.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 129,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9739), "[\"128.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 130,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9742), "[\"129.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 131,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9744), "[\"130.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 132,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9747), "[\"131.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 133,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9754), "[\"132.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 134,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9757), "[\"133.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 135,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9760), "[\"134.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 136,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9762), "[\"135.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 137,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9765), "[\"136.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 138,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9767), "[\"138.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 139,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9770), "[\"139.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 140,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9773), "[\"140.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 141,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9775), "[\"141.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 142,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9778), "[\"142.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 143,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9780), "[\"143.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 144,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9783), "[\"144.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 145,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9785), "[\"145.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 146,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9788), "[\"146.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 147,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9790), "[\"147.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 148,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9793), "[\"148.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 149,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9795), "[\"149.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 150,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9798), "[\"150.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 151,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9800), "[\"151.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 152,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9803), "[\"152.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 153,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9805), "[\"153.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 154,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9808), "[\"154.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 155,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9810), "[\"155.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 156,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9813), "[\"156.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 157,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9815), "[\"157.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 158,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9818), "[\"158.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 159,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9821), "[\"159.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 160,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9823), "[\"160.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 161,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9826), "[\"161.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 162,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9828), "[\"162.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 163,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9831), "[\"163.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 164,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9840), "[\"164.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 165,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9843), "[\"165.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 166,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9845), "[\"166.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 167,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9848), "[\"167.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 168,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9850), "[\"168.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 169,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9853), "[\"169.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 170,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9855), "[\"170.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 171,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9858), "[\"171.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 172,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9860), "[\"172.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 173,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9863), "[\"173.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 174,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9866), "[\"174.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 175,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9868), "[\"175.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 176,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9871), "[\"176.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 177,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9873), "[\"177.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 178,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9876), "[\"178.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 179,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9878), "[\"179.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 180,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9881), "[\"180.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 181,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9883), "[\"181.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 182,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9886), "[\"182.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 183,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9889), "[\"183.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 184,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9891), "[\"184.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 185,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9894), "[\"185.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 186,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9896), "[\"186.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 187,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9899), "[\"187.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 188,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9901), "[\"188.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 189,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9904), "[\"189.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 190,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9906), "[\"190.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 191,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9909), "[\"191.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 192,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9912), "[\"192.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 193,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9914), "[\"193.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 194,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9917), "[\"194.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 195,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9924), "[\"195.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 196,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9927), "[\"196.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 197,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9930), "[\"197.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 198,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9932), "[\"198.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 199,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9935), "[\"199.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 200,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9937), "[\"200.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 201,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9940), "[\"201.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 202,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9943), "[\"202.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 203,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9945), "[\"203.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 204,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9948), "[\"204.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 205,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9950), "[\"205.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 206,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9953), "[\"206.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 207,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9955), "[\"207.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 208,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9958), "[\"208.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 209,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9960), "[\"209.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 210,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9963), "[\"210.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 211,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9965), "[\"211.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 212,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9968), "[\"212.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 213,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9971), "[\"213.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 214,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9973), "[\"214.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 215,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9976), "[\"215.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 216,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9978), "[\"216.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 217,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9981), "[\"217.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 218,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9984), "[\"218.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 219,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9986), "[\"219.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 220,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9989), "[\"220.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 221,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9992), "[\"221.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 222,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9994), "[\"222.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 223,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 892, DateTimeKind.Local).AddTicks(9997), "[\"223.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 224,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local), "[\"224.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 225,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(2), "[\"225.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 226,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(9), "[\"226.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 227,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(12), "[\"227.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 228,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(14), "[\"228.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 229,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(17), "[\"229.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 230,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(19), "[\"230.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 231,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(22), "[\"231.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 232,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(25), "[\"232.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 233,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(27), "[\"233.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 234,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(30), "[\"234.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 235,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(32), "[\"235.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 236,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(35), "[\"236.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 237,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(38), "[\"237.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 238,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(40), "[\"238.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 239,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(43), "[\"239.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 240,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(45), "[\"240.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 241,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(48), "[\"241.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 242,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(50), "[\"242.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 243,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(53), "[\"243.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 244,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(55), "[\"244.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 245,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(58), "[\"245.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 246,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(60), "[\"246.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 247,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(63), "[\"247.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 248,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(66), "[\"248.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 249,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(68), "[\"249.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 250,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(71), "[\"250.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 251,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(73), "[\"251.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 252,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(76), "[\"252.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 253,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(78), "[\"253.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 254,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(81), "[\"254.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 255,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(83), "[\"255.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 256,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(86), "[\"256.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 257,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(94), "[\"257.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 258,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(97), "[\"258.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 259,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(100), "[\"259.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 260,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(102), "[\"260.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 261,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(105), "[\"261.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 262,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(107), "[\"262.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 263,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(110), "[\"263.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 264,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(112), "[\"264.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 265,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(115), "[\"265.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 266,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(117), "[\"266.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 267,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(120), "[\"267.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 268,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(122), "[\"268.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 269,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(125), "[\"269.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 270,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(127), "[\"270.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 271,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(130), "[\"271.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 272,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(133), "[\"272.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 273,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(135), "[\"273.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 274,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(138), "[\"274.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 275,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(140), "[\"275.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 276,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(143), "[\"276.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 277,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(145), "[\"277.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 278,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(148), "[\"278.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 279,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(150), "[\"279.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 280,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(153), "[\"280.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 281,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(155), "[\"281.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 282,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(158), "[\"282.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 283,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(160), "[\"283.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 284,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(163), "[\"284.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 285,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(165), "[\"285.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 286,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(168), "[\"286.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 287,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(170), "[\"287.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 288,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(178), "[\"288.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 289,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(180), "[\"289.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 290,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(183), "[\"290.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 291,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(185), "[\"291.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 292,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(188), "[\"292.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 293,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(191), "[\"293.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 294,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(193), "[\"294.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 295,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(196), "[\"295.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 296,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(198), "[\"296.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 297,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(201), "[\"297.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 298,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(203), "[\"298.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 299,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(206), "[\"299.jfif\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 300,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 4, 45, 893, DateTimeKind.Local).AddTicks(208), "[\"300.jfif\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "27a5b5bf-9763-46b5-98bc-a2655e000b88");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "38b25183-ade9-4838-b198-3fe0dea82009");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "53bbea35-143d-4a66-bddc-dc90fb827d21");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a9329534-1737-4420-860c-5718b1ab6ce5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 50, DateTimeKind.Local).AddTicks(4122), "fdf45289-1a65-4432-a212-29a4f7f2fb81", "AQAAAAIAAYagAAAAELE5cXEmADDxLHm7ouEk85Vj/52cTubT+IUt+IJf3l+8wOUG8KmgLaGfAf1IxvFzTw==", "329153f9-542e-4fb5-8cff-0ec9be1b8265" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4312), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4319), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4321), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4322), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4324), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4326), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4328), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4329), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4331), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4333), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4335), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4337), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4338), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4340), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4342), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4343), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4345), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4347), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4348), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4350), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4352), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4353), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4363), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4365), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4366), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4368), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4370), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4372), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4373), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4375), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4377), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4379), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4380), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4382), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4384), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4385), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4387), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4388), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4390), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4392), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4394), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4395), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4397), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4399), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4400), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4402), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4404), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4405), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4407), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4409), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4410), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4412), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4414), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4415), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4417), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4419), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4420), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4422), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4424), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4425), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4427), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4429), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4430), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4432), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4434), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4436), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4437), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4439), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4441), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4446), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4448), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4450), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4451), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4453), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4455), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4456), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4458), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4460), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4461), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4463), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4465), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4466), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4468), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4470), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4472), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4473), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4475), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4477), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4478), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4480), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4482), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4483), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4485), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4487), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4488), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4490), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4492), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4493), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4495), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4497), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4498), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4500), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4502), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4503), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4505), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4507), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4508), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4510), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4512), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4513), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4515), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4517), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4518), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4520), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4522), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4528), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4530), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4532), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4533), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4535), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4537), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4538), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4540), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4542), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4543), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 126,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4545), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 127,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4547), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 128,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4548), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 129,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4550), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 130,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4552), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 131,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4553), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 132,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4555), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 133,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4557), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 134,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4558), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 135,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4560), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 136,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4562), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 137,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4563), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 138,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4565), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 139,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4566), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 140,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4568), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 141,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4570), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 142,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4572), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 143,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4573), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 144,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4575), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 145,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4577), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 146,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4578), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 147,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4580), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 148,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4582), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 149,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4583), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 150,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4585), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 151,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4587), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 152,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4588), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 153,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4590), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 154,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4592), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 155,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4593), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 156,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4595), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 157,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4597), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 158,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4599), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 159,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4600), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 160,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4602), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 161,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4604), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 162,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4605), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 163,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4612), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 164,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4615), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 165,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4616), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 166,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4618), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 167,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4620), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 168,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4622), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 169,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4623), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 170,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4625), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 171,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4627), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 172,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4628), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 173,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4630), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 174,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4632), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 175,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4633), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 176,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4635), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 177,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4637), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 178,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4638), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 179,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4640), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 180,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4642), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 181,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4643), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 182,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4645), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 183,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4647), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 184,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4648), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 185,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4650), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 186,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4652), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 187,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4654), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 188,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4655), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 189,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4657), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 190,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4658), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 191,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4660), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 192,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4662), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 193,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4664), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 194,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4665), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 195,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4667), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 196,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4669), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 197,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4670), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 198,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4672), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 199,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4674), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 200,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4675), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 201,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4677), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 202,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4679), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 203,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4680), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 204,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4682), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 205,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4684), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 206,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4685), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 207,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4687), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 208,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4689), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 209,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4696), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 210,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4697), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 211,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4699), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 212,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4701), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 213,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4703), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 214,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4704), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 215,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4706), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 216,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4708), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 217,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4709), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 218,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4711), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 219,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4713), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 220,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4714), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 221,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4716), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 222,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4718), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 223,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4719), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 224,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4721), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 225,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4723), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 226,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4724), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 227,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4728), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 228,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4730), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 229,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4732), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 230,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4733), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 231,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4737), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 232,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4739), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 233,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4742), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 234,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4745), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 235,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4748), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 236,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4750), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 237,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4751), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 238,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4753), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 239,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4755), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 240,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4756), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 241,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4758), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 242,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4760), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 243,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4761), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 244,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4763), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 245,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4765), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 246,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4766), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 247,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4768), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 248,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4770), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 249,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4771), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 250,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4773), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 251,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4775), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 252,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4776), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 253,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4778), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 254,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4780), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 255,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4781), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 256,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4789), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 257,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4791), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 258,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4793), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 259,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4794), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 260,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4796), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 261,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4798), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 262,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4799), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 263,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4801), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 264,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4803), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 265,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4804), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 266,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4806), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 267,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4808), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 268,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4809), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 269,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4811), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 270,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4813), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 271,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4815), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 272,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4816), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 273,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4818), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 274,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4819), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 275,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4821), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 276,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4823), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 277,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4824), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 278,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4826), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 279,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4828), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 280,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4829), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 281,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4831), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 282,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4833), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 283,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4834), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 284,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4836), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 285,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4838), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 286,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4840), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 287,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4841), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 288,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4843), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 289,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4844), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 290,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4846), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 291,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4848), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 292,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4849), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 293,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4851), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 294,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4853), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 295,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4854), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 296,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4856), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 297,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4858), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 298,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4859), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 299,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4861), "[]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 300,
                columns: new[] { "AddedDate", "ImageUrls" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 36, 46, 120, DateTimeKind.Local).AddTicks(4863), "[]" });
        }
    }
}
