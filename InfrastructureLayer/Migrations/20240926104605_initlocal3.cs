using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class initlocal3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AcceptRefundRequest",
                table: "OfferCarts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "OfferCarts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_Blog_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Blog_AppUserId",
                table: "Blog",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropColumn(
                name: "AcceptRefundRequest",
                table: "OfferCarts");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "OfferCarts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "acf41d5e-0c6d-4458-9938-28687f5729f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "8afa327a-6c38-4719-b8c9-4df45344d55c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ebee5c00-bb20-49f8-90e0-7320a2009757");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "f83c8c90-8eae-4eda-b100-5bcfc37f4e6a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 9, 23, 23, 35, 14, 716, DateTimeKind.Local).AddTicks(9951), "bc47f4f0-9da0-42ef-9f43-c28ac5fa2f18", "AQAAAAIAAYagAAAAECLR3YRIjOMcnoHw84zvo3ZYSng6QhbzYI0qV6zZ5LlgcO5ru44Cd5BisyOGr5X9WA==", "b1158306-ad3f-4893-ad39-c74c4e39ccec" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 126,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 127,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 128,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 129,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 130,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 131,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 132,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 133,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 134,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 135,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 136,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 137,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 138,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 139,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 140,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 141,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 142,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 143,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 144,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 145,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 146,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 147,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 148,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 149,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 150,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 151,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 152,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 153,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 154,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 155,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 156,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 157,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 158,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 159,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 160,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 161,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 162,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 163,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 164,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 165,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 166,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 167,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 168,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 169,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 170,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 171,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 172,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 173,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 174,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 175,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 176,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 177,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 178,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 179,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 180,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 181,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 182,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 183,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 184,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 185,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 186,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 187,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 188,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 189,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 190,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 191,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 192,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 193,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 194,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 195,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 196,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 197,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 198,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 199,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 200,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 201,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 202,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 203,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 204,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 205,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 206,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 207,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 208,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 209,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 210,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 211,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 212,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 213,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 214,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 215,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 216,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 217,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 218,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 219,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 220,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 221,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 222,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 223,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 224,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 225,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 226,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 227,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 228,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 229,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 230,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 231,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 232,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 233,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 234,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 235,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 236,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 237,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 238,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 239,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 240,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 241,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 242,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 243,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 244,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 245,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 246,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 247,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 248,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 249,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 250,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 251,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 252,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 253,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 254,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 255,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 256,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 257,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 258,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 259,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 260,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 261,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 262,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 263,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 264,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 265,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 266,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 267,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 268,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 269,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 270,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 271,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 272,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 273,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 274,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 275,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 276,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 277,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 278,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 279,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 280,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 281,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 282,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 283,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 284,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 285,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 286,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 287,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 288,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 289,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 290,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 291,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 292,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 293,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 294,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 295,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 296,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 297,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 298,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 299,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 300,
                column: "AddedDate",
                value: new DateTime(2024, 9, 23, 23, 35, 14, 789, DateTimeKind.Local).AddTicks(8468));
        }
    }
}
