using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class sss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "ImageUrls");

            migrationBuilder.CreateTable(
                name: "Sss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AskTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AdminAccept = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sss", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sss");

            migrationBuilder.RenameColumn(
                name: "ImageUrls",
                table: "Products",
                newName: "ImageUrl");

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
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5223), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5229), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5231), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5232), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5234), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5235), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5237), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5238), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5240), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5242), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5243), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5245), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5246), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5248), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5249), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5251), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5253), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5254), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5256), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5257), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5259), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5261), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5262), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5264), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5265), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5267), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5268), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5270), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5271), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5273), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5275), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5276), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5278), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5279), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5291), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5292), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5294), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5296), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5297), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5299), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5301), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5302), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5304), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5305), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5307), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5309), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5310), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5312), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5313), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5315), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5317), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5318), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5320), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5321), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5323), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5325), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5326), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5328), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5329), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5331), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5333), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5334), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5336), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5337), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5339), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5340), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5342), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5344), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5345), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5347), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5348), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5350), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5351), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5353), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5355), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5356), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5358), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5359), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5361), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5362), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5364), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5366), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5367), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5369), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5370), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5372), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5373), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5375), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5377), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5378), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5380), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5388), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5389), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5391), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5392), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5394), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5396), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5397), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5399), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5400), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5402), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5404), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5405), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5407), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5408), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5410), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5411), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5413), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5415), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5416), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5418), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5419), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5421), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5422), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5424), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5425), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5427), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5429), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5430), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5432), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5433), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5435), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5436), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5438), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5440), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 126,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5441), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 127,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5443), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 128,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5444), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 129,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5446), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 130,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5447), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 131,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5449), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 132,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5451), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 133,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5452), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 134,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5454), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 135,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5455), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 136,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5457), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 137,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5458), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 138,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5460), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 139,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5462), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 140,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5463), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 141,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5465), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 142,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5466), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 143,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5468), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 144,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5470), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 145,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5471), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 146,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5473), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 147,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5474), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 148,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5476), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 149,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5485), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 150,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5487), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 151,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5488), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 152,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5490), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 153,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5491), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 154,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5493), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 155,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5495), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 156,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5496), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 157,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5498), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 158,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5499), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 159,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5501), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 160,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5502), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 161,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5504), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 162,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5506), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 163,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5507), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 164,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5509), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 165,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5510), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 166,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5512), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 167,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5513), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 168,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5515), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 169,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5517), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 170,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5518), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 171,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5520), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 172,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5521), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 173,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5523), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 174,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5525), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 175,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5526), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 176,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5528), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 177,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5529), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 178,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5531), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 179,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5532), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 180,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5534), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 181,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5536), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 182,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5537), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 183,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5539), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 184,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5540), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 185,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5542), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 186,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5543), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 187,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5545), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 188,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5547), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 189,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5548), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 190,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5550), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 191,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5552), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 192,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5553), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 193,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5555), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 194,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5556), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 195,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5558), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 196,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5559), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 197,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5561), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 198,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5563), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 199,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5564), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 200,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5566), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 201,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5567), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 202,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5569), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 203,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5571), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 204,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5572), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 205,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5574), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 206,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5584), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 207,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5586), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 208,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5588), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 209,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5589), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 210,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5591), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 211,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5592), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 212,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5594), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 213,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5595), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 214,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5597), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 215,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5599), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 216,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5600), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 217,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5602), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 218,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5603), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 219,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5605), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 220,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5606), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 221,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5608), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 222,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5609), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 223,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5611), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 224,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5612), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 225,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5614), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 226,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5616), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 227,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5617), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 228,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5619), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 229,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5621), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 230,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5622), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 231,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5624), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 232,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5625), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 233,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5627), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 234,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5628), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 235,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5630), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 236,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5631), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 237,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5633), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 238,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5635), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 239,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5636), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 240,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5638), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 241,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5639), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 242,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5641), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 243,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5643), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 244,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5644), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 245,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5646), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 246,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5648), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 247,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5649), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 248,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5651), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 249,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5652), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 250,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5654), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 251,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5655), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 252,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5657), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 253,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5659), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 254,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5660), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 255,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5662), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 256,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5664), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 257,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5665), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 258,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5667), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 259,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5668), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 260,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5670), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 261,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5671), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 262,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5673), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 263,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5680), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 264,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5682), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 265,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5683), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 266,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5685), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 267,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5686), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 268,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5688), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 269,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5689), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 270,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5691), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 271,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5693), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 272,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5694), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 273,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5696), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 274,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5697), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 275,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5699), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 276,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5701), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 277,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5702), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 278,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5704), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 279,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5705), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 280,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5707), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 281,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5708), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 282,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5710), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 283,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5712), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 284,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5713), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 285,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5715), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 286,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5716), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 287,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5718), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 288,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5719), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 289,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5721), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 290,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5722), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 291,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5724), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 292,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5726), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 293,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5727), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 294,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5729), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 295,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5730), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 296,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5732), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 297,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5733), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 298,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5735), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 299,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5737), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 300,
                columns: new[] { "AddedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 3, 18, 2, 51, 801, DateTimeKind.Local).AddTicks(5738), null });
        }
    }
}
