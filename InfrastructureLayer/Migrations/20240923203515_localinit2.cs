using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class localinit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfferCartMessage_OfferCarts_OfferCartId",
                table: "OfferCartMessage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfferCartMessage",
                table: "OfferCartMessage");

            migrationBuilder.RenameTable(
                name: "OfferCartMessage",
                newName: "OfferCartMessages");

            migrationBuilder.RenameColumn(
                name: "SendDate",
                table: "OfferCartMessages",
                newName: "AddedDate");

            migrationBuilder.RenameIndex(
                name: "IX_OfferCartMessage_OfferCartId",
                table: "OfferCartMessages",
                newName: "IX_OfferCartMessages_OfferCartId");

            migrationBuilder.AddColumn<bool>(
                name: "IsRefundRequest",
                table: "OfferCarts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "OfferCarts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "OfferCartMessages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "OfferCartMessages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "OfferCartMessages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "OfferCartMessages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfferCartMessages",
                table: "OfferCartMessages",
                column: "OfferCartMessageId");

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_OfferCartMessages_OfferCarts_OfferCartId",
                table: "OfferCartMessages",
                column: "OfferCartId",
                principalTable: "OfferCarts",
                principalColumn: "OfferCartId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfferCartMessages_OfferCarts_OfferCartId",
                table: "OfferCartMessages");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfferCartMessages",
                table: "OfferCartMessages");

            migrationBuilder.DropColumn(
                name: "IsRefundRequest",
                table: "OfferCarts");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "OfferCarts");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "OfferCartMessages");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "OfferCartMessages");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "OfferCartMessages");

            migrationBuilder.RenameTable(
                name: "OfferCartMessages",
                newName: "OfferCartMessage");

            migrationBuilder.RenameColumn(
                name: "AddedDate",
                table: "OfferCartMessage",
                newName: "SendDate");

            migrationBuilder.RenameIndex(
                name: "IX_OfferCartMessages_OfferCartId",
                table: "OfferCartMessage",
                newName: "IX_OfferCartMessage_OfferCartId");

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "OfferCartMessage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfferCartMessage",
                table: "OfferCartMessage",
                column: "OfferCartMessageId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1463cd24-36db-43ea-aba0-72dde09e8100");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4731e841-221e-4ac1-9b72-46288d24996c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "4740c3a1-272b-4379-b1d5-b1b42f534db3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "96c9c5e2-53ad-4f5c-927e-e0163ac6e668");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 9, 20, 11, 59, 52, 412, DateTimeKind.Local).AddTicks(9496), "bf07c26f-e23b-4d32-b247-99f1ce968276", "AQAAAAIAAYagAAAAEPBzWWidM/XCW4c2Uv9bp73DglEOgyDrQ55zRdjD062mnFjSxFUDbXusuyA8PE0+TQ==", "c5e96735-62d4-4f5f-9408-6f34ebedb19c" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 126,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 127,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 128,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 129,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 130,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 131,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 132,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 133,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 134,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 135,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 136,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 137,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 138,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 139,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 140,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 141,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 142,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 143,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 144,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 145,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 146,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 147,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 148,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 149,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 150,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 151,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 152,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 153,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 154,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 155,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 156,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 157,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 158,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 159,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 160,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 161,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 162,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 163,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 164,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 165,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 166,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 167,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 168,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 169,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 170,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 171,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 172,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 173,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 174,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 175,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 176,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 177,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 178,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 179,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 180,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 181,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 182,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 183,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 184,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 185,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 186,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 187,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 188,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 189,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 190,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 191,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 192,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 193,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 194,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 195,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 196,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 197,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 198,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 199,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 200,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 201,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 202,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 203,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 204,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 205,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 206,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 207,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 208,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 209,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 210,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 211,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 212,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 213,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 214,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 215,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 216,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 217,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 218,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 219,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 220,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 221,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 222,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 223,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 224,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 225,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 226,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 227,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 228,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 229,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 230,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 231,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 232,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 233,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 234,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 235,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 236,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 237,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 238,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 239,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 240,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 241,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 242,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 243,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 244,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 245,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 246,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 247,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 248,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 249,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 250,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 251,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 252,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 253,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 254,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 255,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 256,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 257,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 258,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 259,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 260,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 261,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 262,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 263,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 264,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 265,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 266,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 267,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 268,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 269,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 270,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 271,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 272,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 273,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 274,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 275,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 276,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 277,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 278,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 279,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 280,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 281,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 282,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 283,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 284,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 285,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 286,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 287,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 288,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 289,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 290,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 291,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 292,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 293,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 294,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 295,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 296,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 297,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 298,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 299,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 300,
                column: "AddedDate",
                value: new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.AddForeignKey(
                name: "FK_OfferCartMessage_OfferCarts_OfferCartId",
                table: "OfferCartMessage",
                column: "OfferCartId",
                principalTable: "OfferCarts",
                principalColumn: "OfferCartId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
