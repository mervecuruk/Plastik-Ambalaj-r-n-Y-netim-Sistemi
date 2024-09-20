using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class localinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: true),
                    Views = table.Column<int>(type: "int", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfferCarts",
                columns: table => new
                {
                    OfferCartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AcceptAdmin = table.Column<bool>(type: "bit", nullable: false),
                    AcceptContentManager = table.Column<bool>(type: "bit", nullable: false),
                    AcceptCustomerService = table.Column<bool>(type: "bit", nullable: false),
                    AcceptVisitor = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    IsSample = table.Column<bool>(type: "bit", nullable: false),
                    IsMold = table.Column<bool>(type: "bit", nullable: false),
                    IsFinalization = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferCarts", x => x.OfferCartId);
                    table.ForeignKey(
                        name: "FK_OfferCarts_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfferCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfferCartMessage",
                columns: table => new
                {
                    OfferCartMessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    OfferCartId = table.Column<int>(type: "int", nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferCartMessage", x => x.OfferCartMessageId);
                    table.ForeignKey(
                        name: "FK_OfferCartMessage_OfferCarts_OfferCartId",
                        column: x => x.OfferCartId,
                        principalTable: "OfferCarts",
                        principalColumn: "OfferCartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "1463cd24-36db-43ea-aba0-72dde09e8100", "Admin", "ADMIN" },
                    { 2, "4731e841-221e-4ac1-9b72-46288d24996c", "ContentManager", "CONTENTMANAGER" },
                    { 3, "4740c3a1-272b-4379-b1d5-b1b42f534db3", "CustomerService", "CUSTOMERSERVICE" },
                    { 4, "96c9c5e2-53ad-4f5c-927e-e0163ac6e668", "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedDate", "ConcurrencyStamp", "DeleteDate", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateDate", "UserName" },
                values: new object[] { 1, 0, new DateTime(2024, 9, 20, 11, 59, 52, 412, DateTimeKind.Local).AddTicks(9496), "bf07c26f-e23b-4d32-b247-99f1ce968276", null, "super@admin.com", false, "Super", true, "Admin", false, null, "SUPER@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEPBzWWidM/XCW4c2Uv9bp73DglEOgyDrQ55zRdjD062mnFjSxFUDbXusuyA8PE0+TQ==", null, false, "c5e96735-62d4-4f5f-9408-6f34ebedb19c", false, null, "Admin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "AddedDate", "CategoryName", "DeleteDate", "IsActive", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5929), "Food Packaging", null, true, null },
                    { 2, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5942), "Beverage Packaging", null, true, null },
                    { 3, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5943), "Cosmetic Packaging", null, true, null },
                    { 4, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5944), "Medical Packaging", null, true, null },
                    { 5, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5945), "Pharmaceutical Packaging", null, true, null },
                    { 6, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5946), "Flexible Packaging", null, true, null },
                    { 7, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5947), "Rigid Packaging", null, true, null },
                    { 8, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5948), "Plastic Bags", null, true, null },
                    { 9, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5949), "Shrink Wrap", null, true, null },
                    { 10, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5950), "Blister Packaging", null, true, null },
                    { 11, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5951), "Thermoformed Packaging", null, true, null },
                    { 12, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5952), "Vacuum Packaging", null, true, null },
                    { 13, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5953), "Stretch Film", null, true, null },
                    { 14, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5953), "Plastic Bottles", null, true, null },
                    { 15, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5954), "Plastic Containers", null, true, null },
                    { 16, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5955), "Plastic Caps and Closures", null, true, null },
                    { 17, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5956), "Disposable Utensils", null, true, null },
                    { 18, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5957), "Clamshell Packaging", null, true, null },
                    { 19, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5958), "Film Packaging", null, true, null },
                    { 20, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5959), "Injection Molded Packaging", null, true, null },
                    { 21, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5960), "PET Bottles", null, true, null },
                    { 22, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5961), "HDPE Containers", null, true, null },
                    { 23, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5962), "LDPE Bags", null, true, null },
                    { 24, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5963), "Polypropylene Packaging", null, true, null },
                    { 25, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5964), "Polystyrene Packaging", null, true, null },
                    { 26, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5965), "Polyvinyl Chloride (PVC) Packaging", null, true, null },
                    { 27, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5966), "Biodegradable Packaging", null, true, null },
                    { 28, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5967), "Compostable Packaging", null, true, null },
                    { 29, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5968), "E-commerce Packaging", null, true, null },
                    { 30, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(5969), "Industrial Packaging", null, true, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AddedDate", "CategoryId", "DeleteDate", "Description", "ImageUrl", "IsActive", "Likes", "Material", "Price", "ProductName", "UpdateDate", "Views" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7266), 1, null, "Keep your food fresh.", null, true, null, 1, 0.50m, "Plastic Wrap", null, null },
                    { 2, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7271), 1, null, "Microwave and dishwasher safe.", null, true, null, 2, 1.20m, "Plastic Food Containers", null, null },
                    { 3, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7273), 1, null, "Ideal for preserving food.", null, true, null, 1, 0.15m, "Food Storage Bags", null, null },
                    { 4, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7275), 1, null, "Perfect for takeout.", null, true, null, 14, 0.75m, "Foil Containers", null, null },
                    { 5, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7276), 1, null, "Easy to use for packaging.", null, true, null, 7, 3.50m, "Plastic Wrap Dispenser", null, null },
                    { 6, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7278), 1, null, "For storing leftovers.", null, true, null, 1, 0.25m, "Sealable Bags", null, null },
                    { 7, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7280), 1, null, "For heating food safely.", null, true, null, 2, 1.50m, "Microwavable Containers", null, null },
                    { 8, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7281), 1, null, "For quick meals.", null, true, null, 11, 0.40m, "Takeout Boxes", null, null },
                    { 9, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7283), 1, null, "Eco-friendly option.", null, true, null, 6, 2.00m, "Bamboo Food Containers", null, null },
                    { 10, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7284), 1, null, "Great for organization.", null, true, null, 2, 1.75m, "Plastic Food Storage Bins", null, null },
                    { 11, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7286), 2, null, "Perfect for beverages.", null, true, null, 1, 0.30m, "Plastic Bottles", null, null },
                    { 12, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7288), 2, null, "For soft drinks.", null, true, null, 14, 0.50m, "Aluminum Cans", null, null },
                    { 13, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7289), 2, null, "Disposable and convenient.", null, true, null, 2, 0.10m, "Plastic Cups", null, null },
                    { 14, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7291), 2, null, "Reusable and recyclable.", null, true, null, 15, 1.00m, "Glass Bottles", null, null },
                    { 15, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7292), 2, null, "For juice and smoothies.", null, true, null, 1, 0.25m, "Drink Pouches", null, null },
                    { 16, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7294), 2, null, "For long shelf life.", null, true, null, 8, 0.75m, "Tetra Pak Containers", null, null },
                    { 17, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7296), 2, null, "Eco-friendly choice.", null, true, null, 9, 1.50m, "Reusable Water Bottles", null, null },
                    { 18, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7297), 2, null, "Ideal for hot beverages.", null, true, null, 11, 0.60m, "Coffee Cups", null, null },
                    { 19, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7299), 2, null, "Convenient for drinks.", null, true, null, 2, 0.05m, "Plastic Straws", null, null },
                    { 20, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7300), 2, null, "For storing wine.", null, true, null, 15, 1.25m, "Wine Bottles", null, null },
                    { 21, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7302), 3, null, "Ideal for creams.", null, true, null, 2, 1.50m, "Plastic Cosmetic Jars", null, null },
                    { 22, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7304), 3, null, "Stylish and durable.", null, true, null, 10, 2.00m, "Acrylic Cosmetic Containers", null, null },
                    { 23, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7305), 3, null, "Perfect for oils and perfumes.", null, true, null, 1, 0.80m, "Roll-On Bottles", null, null },
                    { 24, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7307), 3, null, "For lip care products.", null, true, null, 2, 0.20m, "Lip Balm Tubes", null, null },
                    { 25, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7308), 3, null, "For perfumes and sprays.", null, true, null, 1, 1.00m, "Plastic Spray Bottles", null, null },
                    { 26, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7310), 3, null, "Ideal for skincare products.", null, true, null, 15, 1.75m, "Glass Jars", null, null },
                    { 27, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7311), 3, null, "For organization.", null, true, null, 16, 0.90m, "Cosmetic Bags", null, null },
                    { 28, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7314), 3, null, "For makeup products.", null, true, null, 2, 1.20m, "Plastic Compacts", null, null },
                    { 29, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7317), 3, null, "Ideal for facial masks.", null, true, null, 6, 0.50m, "Face Mask Packaging", null, null },
                    { 30, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7320), 3, null, "Sustainable choices.", null, true, null, 6, 2.50m, "Eco-friendly Cosmetic Packaging", null, null },
                    { 31, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7322), 4, null, "For safe medicine storage.", null, true, null, 5, 0.80m, "Medical Blister Packs", null, null },
                    { 32, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7323), 4, null, "Sterile and secure.", null, true, null, 1, 3.00m, "Surgical Packs", null, null },
                    { 33, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7325), 4, null, "For pharmaceutical storage.", null, true, null, 2, 2.00m, "Medical Containers", null, null },
                    { 34, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7326), 4, null, "For temperature-sensitive products.", null, true, null, 1, 1.50m, "Thermal Medical Bags", null, null },
                    { 35, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7328), 4, null, "For intravenous therapy.", null, true, null, 5, 0.40m, "IV Bags", null, null },
                    { 36, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7330), 4, null, "For lab samples.", null, true, null, 2, 0.30m, "Sample Collection Tubes", null, null },
                    { 37, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7331), 4, null, "For medication storage.", null, true, null, 1, 0.60m, "Pill Bottles", null, null },
                    { 38, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7333), 4, null, "Safe storage for syringes.", null, true, null, 2, 0.50m, "Syringe Packaging", null, null },
                    { 39, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7334), 4, null, "For identifying products.", null, true, null, 11, 0.10m, "Medical Labels", null, null },
                    { 40, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7336), 4, null, "For hazardous waste.", null, true, null, 1, 0.20m, "Biohazard Bags", null, null },
                    { 41, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7337), 5, null, "For tablets and liquids.", null, true, null, 1, 1.00m, "Pharmaceutical Bottles", null, null },
                    { 42, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7339), 5, null, "For safety.", null, true, null, 2, 0.15m, "Child-resistant Caps", null, null },
                    { 43, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7340), 5, null, "For medication management.", null, true, null, 2, 2.00m, "Pill Organizers", null, null },
                    { 44, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7347), 5, null, "For labeling products.", null, true, null, 12, 500.00m, "Labeling Machines", null, null },
                    { 45, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7349), 5, null, "For syringes.", null, true, null, 2, 0.50m, "Syringe Packaging", null, null },
                    { 46, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7351), 5, null, "For pharmaceuticals.", null, true, null, 5, 0.60m, "Blister Card Packaging", null, null },
                    { 47, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7352), 5, null, "For single-dose medications.", null, true, null, 1, 0.25m, "Pharmaceutical Sachets", null, null },
                    { 48, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7354), 5, null, "For intravenous medications.", null, true, null, 5, 0.40m, "IV Bags", null, null },
                    { 49, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7356), 5, null, "For informing patients.", null, true, null, 11, 0.10m, "Medication Guides", null, null },
                    { 50, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7357), 5, null, "For dispensing medications.", null, true, null, 11, 0.15m, "Prescription Bags", null, null },
                    { 51, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7359), 6, null, "For various products.", null, true, null, 1, 0.50m, "Flexible Pouches", null, null },
                    { 52, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7360), 6, null, "Convenient for storage.", null, true, null, 2, 0.75m, "Stand-up Pouches", null, null },
                    { 53, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7362), 6, null, "For easy carrying.", null, true, null, 1, 0.20m, "Flexible Plastic Bags", null, null },
                    { 54, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7363), 6, null, "For tight packaging.", null, true, null, 1, 0.30m, "Shrink Bags", null, null },
                    { 55, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7365), 6, null, "For preserving food.", null, true, null, 1, 1.00m, "Vacuum Bags", null, null },
                    { 56, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7366), 6, null, "For custom packaging.", null, true, null, 2, 0.50m, "Rollstock Film", null, null },
                    { 57, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7368), 6, null, "For snacks and meals.", null, true, null, 1, 0.40m, "Food Pouches", null, null },
                    { 58, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7369), 6, null, "For bulk items.", null, true, null, 2, 0.60m, "Gusseted Bags", null, null },
                    { 59, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7371), 6, null, "For secure closure.", null, true, null, 1, 0.25m, "Zipper Bags", null, null },
                    { 60, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7372), 6, null, "For security.", null, true, null, 1, 0.30m, "Tamper-evident Bags", null, null },
                    { 61, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7374), 7, null, "Durable and versatile.", null, true, null, 2, 1.50m, "Rigid Plastic Containers", null, null },
                    { 62, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7376), 7, null, "For various products.", null, true, null, 15, 2.00m, "Glass Jars", null, null },
                    { 63, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7377), 7, null, "For food and beverages.", null, true, null, 12, 0.80m, "Metal Cans", null, null },
                    { 64, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7379), 7, null, "For bulk storage.", null, true, null, 1, 1.00m, "Plastic Buckets", null, null },
                    { 65, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7380), 7, null, "For displaying products.", null, true, null, 2, 0.60m, "Rigid Trays", null, null },
                    { 66, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7382), 7, null, "For transportation.", null, true, null, 1, 2.50m, "Plastic Crates", null, null },
                    { 67, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7383), 7, null, "For industrial use.", null, true, null, 12, 4.00m, "Metal Storage Containers", null, null },
                    { 68, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7385), 7, null, "For organization.", null, true, null, 2, 1.75m, "Plastic Storage Bins", null, null },
                    { 69, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7386), 7, null, "For temperature control.", null, true, null, 2, 3.50m, "Thermal Insulated Containers", null, null },
                    { 70, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7388), 7, null, "For industrial applications.", null, true, null, 1, 5.00m, "Heavy-Duty Tubs", null, null },
                    { 71, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7390), 8, null, "Lightweight and versatile.", null, true, null, 1, 0.10m, "LDPE Plastic Bags", null, null },
                    { 72, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7391), 8, null, "For shopping needs.", null, true, null, 1, 0.05m, "HDPE Grocery Bags", null, null },
                    { 73, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7393), 8, null, "Eco-friendly choice.", null, true, null, 6, 0.15m, "Biodegradable Bags", null, null },
                    { 74, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7394), 8, null, "Durable and strong.", null, true, null, 1, 0.20m, "Plastic Trash Bags", null, null },
                    { 75, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7396), 8, null, "For sustainability.", null, true, null, 16, 1.00m, "Reusable Shopping Bags", null, null },
                    { 76, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7397), 8, null, "For shipping purposes.", null, true, null, 1, 0.30m, "Plastic Mailers", null, null },
                    { 77, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7399), 8, null, "For lunch packing.", null, true, null, 1, 0.10m, "Plastic Sandwich Bags", null, null },
                    { 78, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7400), 8, null, "For secure storage.", null, true, null, 1, 0.15m, "Plastic Ziplock Bags", null, null },
                    { 79, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7402), 8, null, "For retail purposes.", null, true, null, 1, 0.05m, "Plastic Retail Bags", null, null },
                    { 80, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7404), 8, null, "For fruits and vegetables.", null, true, null, 1, 0.07m, "Plastic Produce Bags", null, null },
                    { 81, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7405), 9, null, "For secure packaging.", null, true, null, 1, 0.50m, "Shrink Wrap Film", null, null },
                    { 82, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7407), 9, null, "For tamper evidence.", null, true, null, 1, 0.20m, "Shrink Bands", null, null },
                    { 83, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7408), 9, null, "For efficient packing.", null, true, null, 12, 300.00m, "Shrink Wrap Machine", null, null },
                    { 84, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7410), 9, null, "For custom sizes.", null, true, null, 1, 0.30m, "Shrink Wrap Sheets", null, null },
                    { 85, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7411), 9, null, "For high clarity packaging.", null, true, null, 5, 0.40m, "PVC Shrink Wrap", null, null },
                    { 86, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7413), 9, null, "For large items.", null, true, null, 1, 0.70m, "Centerfold Shrink Film", null, null },
                    { 87, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7414), 9, null, "For industrial use.", null, true, null, 1, 1.00m, "Shrink Wrap Rolls", null, null },
                    { 88, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7416), 9, null, "For smaller items.", null, true, null, 1, 0.25m, "Shrink Wrap Bags", null, null },
                    { 89, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7418), 9, null, "For easy identification.", null, true, null, 11, 0.15m, "Shrink Wrap Labeling", null, null },
                    { 90, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7419), 9, null, "For personalized packaging.", null, true, null, 1, 1.50m, "Custom Shrink Wrap", null, null },
                    { 91, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7421), 10, null, "For product display.", null, true, null, 5, 0.50m, "Blister Packaging Sheets", null, null },
                    { 92, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7422), 10, null, "For retail items.", null, true, null, 5, 1.00m, "Carded Blister Packs", null, null },
                    { 93, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7424), 10, null, "For efficient production.", null, true, null, 12, 500.00m, "Blister Packaging Machines", null, null },
                    { 94, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7425), 10, null, "For personalized branding.", null, true, null, 5, 0.80m, "Custom Blister Packs", null, null },
                    { 95, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7427), 10, null, "For secure sealing.", null, true, null, 11, 0.60m, "Blister Carding", null, null },
                    { 96, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7428), 10, null, "For easy opening.", null, true, null, 5, 1.20m, "Clamshell Blister Packs", null, null },
                    { 97, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7430), 10, null, "For multiple items.", null, true, null, 5, 0.70m, "Blister Packaging Trays", null, null },
                    { 98, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7432), 10, null, "Sustainable packaging.", null, true, null, 6, 1.50m, "Eco-friendly Blister Packs", null, null },
                    { 99, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7433), 10, null, "For added protection.", null, true, null, 11, 0.40m, "Blister Packaging Inserts", null, null },
                    { 100, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7435), 10, null, "For safe medication storage.", null, true, null, 5, 0.90m, "Pharmaceutical Blister Packs", null, null },
                    { 101, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7440), 11, null, "For food and retail.", null, true, null, 2, 0.70m, "Thermoformed Containers", null, null },
                    { 102, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7442), 11, null, "For product display.", null, true, null, 2, 0.80m, "Thermoformed Trays", null, null },
                    { 103, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7443), 11, null, "For packaging small items.", null, true, null, 5, 0.60m, "Thermoformed Blisters", null, null },
                    { 104, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7445), 11, null, "For personalized products.", null, true, null, 2, 1.50m, "Custom Thermoforming", null, null },
                    { 105, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7446), 11, null, "For production needs.", null, true, null, 12, 400.00m, "Thermoformed Packaging Machines", null, null },
                    { 106, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7448), 11, null, "Sustainable options.", null, true, null, 6, 1.25m, "Eco-friendly Thermoformed Packaging", null, null },
                    { 107, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7450), 11, null, "For food service.", null, true, null, 2, 0.50m, "Thermoformed Cups", null, null },
                    { 108, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7451), 11, null, "For secure sealing.", null, true, null, 2, 0.20m, "Thermoformed Lids", null, null },
                    { 109, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7453), 11, null, "For easy opening.", null, true, null, 5, 0.90m, "Thermoformed Clamshells", null, null },
                    { 110, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7454), 11, null, "For meal prep.", null, true, null, 2, 1.50m, "Food Containers", null, null },
                    { 111, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7456), 12, null, "For food preservation.", null, true, null, 1, 1.00m, "Vacuum Seal Bags", null, null },
                    { 112, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7457), 12, null, "For easy sealing.", null, true, null, 12, 250.00m, "Vacuum Packing Machines", null, null },
                    { 113, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7459), 12, null, "Custom sizes available.", null, true, null, 1, 0.80m, "Vacuum Seal Rolls", null, null },
                    { 114, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7460), 12, null, "Eco-friendly option.", null, true, null, 6, 1.50m, "Reusable Vacuum Bags", null, null },
                    { 115, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7462), 12, null, "For long-term storage.", null, true, null, 1, 1.20m, "Heavy-Duty Vacuum Bags", null, null },
                    { 116, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7464), 12, null, "For airtight storage.", null, true, null, 7, 2.50m, "Vacuum Food Canisters", null, null },
                    { 117, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7465), 12, null, "For maintenance.", null, true, null, 12, 15.00m, "Vacuum Sealer Accessories", null, null },
                    { 118, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7467), 12, null, "For business use.", null, true, null, 1, 2.00m, "Commercial Vacuum Bags", null, null },
                    { 119, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7468), 12, null, "For liquids.", null, true, null, 7, 3.00m, "Vacuum Seal Containers", null, null },
                    { 120, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7470), 12, null, "For convenient use.", null, true, null, 12, 10.00m, "Vacuum Bag Roll Dispenser", null, null },
                    { 121, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7471), 13, null, "For securing pallets.", null, true, null, 1, 0.50m, "Standard Stretch Film", null, null },
                    { 122, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7473), 13, null, "For manual use.", null, true, null, 1, 0.40m, "Hand Stretch Wrap", null, null },
                    { 123, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7474), 13, null, "For automated packing.", null, true, null, 1, 0.60m, "Machine Stretch Film", null, null },
                    { 124, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7476), 13, null, "For branding.", null, true, null, 1, 0.70m, "Colored Stretch Film", null, null },
                    { 125, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7477), 13, null, "For heavy loads.", null, true, null, 1, 0.90m, "Heavy-Duty Stretch Film", null, null },
                    { 126, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7479), 13, null, "For ease of use.", null, true, null, 1, 0.80m, "Pre-Stretched Film", null, null },
                    { 127, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7481), 13, null, "Sustainable option.", null, true, null, 6, 1.00m, "Eco-Friendly Stretch Film", null, null },
                    { 128, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7482), 13, null, "For easy handling.", null, true, null, 12, 15.00m, "Stretch Film Dispenser", null, null },
                    { 129, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7484), 13, null, "For securing multiple items.", null, true, null, 1, 0.65m, "Bundling Stretch Film", null, null },
                    { 130, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7485), 13, null, "For palletizing products.", null, true, null, 1, 0.75m, "Pallet Wrap Film", null, null },
                    { 131, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7487), 14, null, "Lightweight and recyclable.", null, true, null, 3, 0.20m, "PET Plastic Bottles", null, null },
                    { 132, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7488), 14, null, "Durable and safe.", null, true, null, 1, 0.25m, "HDPE Bottles", null, null },
                    { 133, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7490), 14, null, "For sauces and condiments.", null, true, null, 2, 0.30m, "Plastic Squeeze Bottles", null, null },
                    { 134, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7491), 14, null, "For lotions and liquids.", null, true, null, 1, 0.50m, "Plastic Pump Bottles", null, null },
                    { 135, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7493), 14, null, "Eco-friendly choice.", null, true, null, 6, 0.35m, "Recyclable Plastic Bottles", null, null },
                    { 136, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7494), 14, null, "For drinks and beverages.", null, true, null, 3, 0.15m, "Plastic Beverage Bottles", null, null },
                    { 137, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7496), 14, null, "For cooking oils.", null, true, null, 1, 0.40m, "Plastic Oil Bottles", null, null },
                    { 138, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7497), 14, null, "For fitness enthusiasts.", null, true, null, 2, 0.60m, "Plastic Sports Bottles", null, null },
                    { 139, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7499), 14, null, "For food storage.", null, true, null, 2, 1.00m, "Plastic Jars with Lids", null, null },
                    { 140, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7501), 14, null, "Personalized branding.", null, true, null, 1, 0.80m, "Custom Labeled Plastic Bottles", null, null },
                    { 141, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7502), 15, null, "For meal storage.", null, true, null, 2, 0.70m, "Plastic Food Containers", null, null },
                    { 142, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7504), 15, null, "For organization.", null, true, null, 1, 1.00m, "Plastic Storage Bins", null, null },
                    { 143, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7506), 15, null, "For leftovers.", null, true, null, 2, 0.90m, "Plastic Tupperware", null, null },
                    { 144, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7507), 15, null, "For food service.", null, true, null, 2, 0.50m, "Plastic Takeout Containers", null, null },
                    { 145, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7509), 15, null, "For craft supplies.", null, true, null, 1, 0.60m, "Plastic Organizer Containers", null, null },
                    { 146, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7510), 15, null, "For transporting food and drinks.", null, true, null, 1, 2.50m, "Plastic Coolers", null, null },
                    { 147, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7512), 15, null, "For bulk items.", null, true, null, 2, 1.20m, "Plastic Food Storage Jars", null, null },
                    { 148, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7513), 15, null, "For snacks on the go.", null, true, null, 1, 0.80m, "Plastic Snack Containers", null, null },
                    { 149, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7515), 15, null, "For outdoor meals.", null, true, null, 1, 1.50m, "Plastic Picnic Containers", null, null },
                    { 150, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7516), 15, null, "For efficient storage.", null, true, null, 2, 1.00m, "Stackable Plastic Containers", null, null },
                    { 151, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7518), 16, null, "For secure closure.", null, true, null, 1, 0.05m, "Plastic Bottle Caps", null, null },
                    { 152, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7519), 16, null, "For bottles and jars.", null, true, null, 2, 0.10m, "Screw Caps", null, null },
                    { 153, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7521), 16, null, "For safety.", null, true, null, 2, 0.12m, "Tamper-Evident Caps", null, null },
                    { 154, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7523), 16, null, "For easy access.", null, true, null, 1, 0.15m, "Flip Top Caps", null, null },
                    { 155, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7524), 16, null, "For convenience.", null, true, null, 2, 0.08m, "Snap-On Caps", null, null },
                    { 156, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7526), 16, null, "For easy dispensing.", null, true, null, 1, 0.20m, "Pour Spouts", null, null },
                    { 157, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7527), 16, null, "For various containers.", null, true, null, 2, 0.18m, "Plastic Lids", null, null },
                    { 158, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7534), 16, null, "For liquid products.", null, true, null, 2, 0.25m, "Dispensing Caps", null, null },
                    { 159, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7535), 16, null, "For branding.", null, true, null, 6, 0.30m, "Custom Printed Caps", null, null },
                    { 160, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7537), 16, null, "For safety.", null, true, null, 1, 0.35m, "Child-Resistant Caps", null, null },
                    { 161, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7538), 17, null, "For parties and events.", null, true, null, 2, 0.02m, "Plastic Forks", null, null },
                    { 162, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7540), 17, null, "For easy serving.", null, true, null, 2, 0.02m, "Plastic Spoons", null, null },
                    { 163, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7541), 17, null, "For quick meals.", null, true, null, 2, 0.02m, "Plastic Knives", null, null },
                    { 164, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7543), 17, null, "For outdoor dining.", null, true, null, 2, 0.05m, "Disposable Plates", null, null },
                    { 165, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7545), 17, null, "For drinks and beverages.", null, true, null, 2, 0.05m, "Disposable Cups", null, null },
                    { 166, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7547), 17, null, "Eco-friendly choice.", null, true, null, 6, 0.10m, "Biodegradable Utensils", null, null },
                    { 167, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7548), 17, null, "For convenience.", null, true, null, 2, 0.15m, "Disposable Cutlery Sets", null, null },
                    { 168, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7550), 17, null, "For serving food.", null, true, null, 2, 0.10m, "Plastic Serving Utensils", null, null },
                    { 169, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7552), 17, null, "For sustainable dining.", null, true, null, 6, 0.12m, "Compostable Utensils", null, null },
                    { 170, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7553), 17, null, "For drinks.", null, true, null, 2, 0.03m, "Disposable Straws", null, null },
                    { 171, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7555), 18, null, "For takeout and delivery.", null, true, null, 2, 0.80m, "Clamshell Food Containers", null, null },
                    { 172, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7556), 18, null, "For product display.", null, true, null, 5, 0.60m, "Clamshell Packaging Trays", null, null },
                    { 173, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7558), 18, null, "Sustainable option.", null, true, null, 6, 1.00m, "Eco-Friendly Clamshells", null, null },
                    { 174, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7559), 18, null, "For retail products.", null, true, null, 2, 0.90m, "Clamshell Packaging Boxes", null, null },
                    { 175, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7561), 18, null, "For visibility.", null, true, null, 5, 0.70m, "Clear Clamshells", null, null },
                    { 176, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7562), 18, null, "For snacks and meals.", null, true, null, 2, 0.75m, "Plastic Clamshell Containers", null, null },
                    { 177, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7564), 18, null, "For added protection.", null, true, null, 5, 1.10m, "Clamshells with Inserts", null, null },
                    { 178, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7565), 18, null, "For branding.", null, true, null, 6, 1.50m, "Custom Clamshell Packaging", null, null },
                    { 179, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7567), 18, null, "For gadgets.", null, true, null, 5, 2.00m, "Clamshell Packaging for Electronics", null, null },
                    { 180, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7569), 18, null, "For eco-friendly use.", null, true, null, 6, 1.25m, "Reusable Clamshells", null, null },
                    { 181, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7570), 19, null, "For wrapping products.", null, true, null, 1, 0.50m, "Plastic Film Rolls", null, null },
                    { 182, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7572), 19, null, "For pallet wrapping.", null, true, null, 1, 0.60m, "Stretch Film Rolls", null, null },
                    { 183, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7573), 19, null, "For tight packaging.", null, true, null, 1, 0.70m, "Shrink Film Rolls", null, null },
                    { 184, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7575), 19, null, "For moisture protection.", null, true, null, 1, 0.80m, "Barrier Film", null, null },
                    { 185, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7576), 19, null, "For industrial use.", null, true, null, 1, 1.00m, "Heavy-Duty Film", null, null },
                    { 186, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7578), 19, null, "For clear packaging.", null, true, null, 2, 0.90m, "Polypropylene Film", null, null },
                    { 187, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7579), 19, null, "For sustainable packaging.", null, true, null, 6, 1.20m, "Biodegradable Film", null, null },
                    { 188, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7581), 19, null, "For food safety.", null, true, null, 1, 0.75m, "Film for Food Packaging", null, null },
                    { 189, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7582), 19, null, "For branding purposes.", null, true, null, 1, 0.85m, "Colored Film", null, null },
                    { 190, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7587), 19, null, "For marketing.", null, true, null, 6, 1.50m, "Custom Printed Film", null, null },
                    { 191, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7588), 20, null, "For food and retail.", null, true, null, 2, 1.00m, "Injection Molded Containers", null, null },
                    { 192, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7590), 20, null, "For product display.", null, true, null, 2, 0.80m, "Injection Molded Trays", null, null },
                    { 193, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7591), 20, null, "For various applications.", null, true, null, 2, 1.50m, "Plastic Injection Molded Parts", null, null },
                    { 194, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7593), 20, null, "For tailored solutions.", null, true, null, 2, 2.00m, "Custom Injection Molding", null, null },
                    { 195, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7594), 20, null, "For production needs.", null, true, null, 12, 600.00m, "Injection Molded Packaging Machines", null, null },
                    { 196, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7596), 20, null, "For secure sealing.", null, true, null, 2, 0.30m, "Injection Molded Caps", null, null },
                    { 197, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7598), 20, null, "For various containers.", null, true, null, 2, 0.25m, "Injection Molded Lids", null, null },
                    { 198, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7599), 20, null, "For secure packaging.", null, true, null, 2, 1.00m, "Injection Molded Clamshells", null, null },
                    { 199, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7601), 20, null, "For bulk storage.", null, true, null, 2, 1.20m, "Injection Molded Jars", null, null },
                    { 200, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7602), 20, null, "For unique solutions.", null, true, null, 2, 2.50m, "Custom Injection Molded Products", null, null },
                    { 201, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7604), 21, null, "Ideal for beverages.", null, true, null, 3, 0.25m, "Clear PET Bottles", null, null },
                    { 202, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7605), 21, null, "For juices and sauces.", null, true, null, 3, 0.30m, "Colored PET Bottles", null, null },
                    { 203, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7607), 21, null, "Includes secure cap.", null, true, null, 3, 0.28m, "PET Bottle with Cap", null, null },
                    { 204, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7609), 21, null, "Environmentally friendly.", null, true, null, 3, 0.26m, "Recyclable PET Bottles", null, null },
                    { 205, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7610), 21, null, "For lotions and creams.", null, true, null, 3, 0.35m, "PET Bottles for Cosmetics", null, null },
                    { 206, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7612), 21, null, "Perfect for branding.", null, true, null, 3, 0.40m, "Custom Labeled PET Bottles", null, null },
                    { 207, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7613), 21, null, "For easy carrying.", null, true, null, 3, 0.50m, "PET Bottles with Handles", null, null },
                    { 208, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7615), 21, null, "For wholesale orders.", null, true, null, 3, 0.20m, "Bulk PET Bottles", null, null },
                    { 209, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7616), 21, null, "For athletes and fitness.", null, true, null, 3, 0.45m, "PET Sports Bottles", null, null },
                    { 210, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7618), 21, null, "For fresh juices.", null, true, null, 3, 0.32m, "PET Juice Bottles", null, null },
                    { 211, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7620), 22, null, "For various storage needs.", null, true, null, 1, 1.00m, "HDPE Storage Containers", null, null },
                    { 212, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7621), 22, null, "For safe storage of chemicals.", null, true, null, 1, 1.50m, "HDPE Chemical Containers", null, null },
                    { 213, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7623), 22, null, "For paint and coatings.", null, true, null, 1, 1.20m, "HDPE Paint Containers", null, null },
                    { 214, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7624), 22, null, "For large quantities.", null, true, null, 1, 2.00m, "HDPE Bulk Containers", null, null },
                    { 215, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7633), 22, null, "For liquids and powders.", null, true, null, 1, 0.90m, "HDPE Jugs", null, null },
                    { 216, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7635), 22, null, "For food storage.", null, true, null, 1, 1.00m, "HDPE Food Containers", null, null },
                    { 217, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7636), 22, null, "For various uses.", null, true, null, 1, 1.50m, "HDPE Buckets", null, null },
                    { 218, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7682), 22, null, "For safe transport.", null, true, null, 1, 2.50m, "HDPE Shipping Containers", null, null },
                    { 219, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7683), 22, null, "Eco-friendly option.", null, true, null, 1, 1.10m, "Recyclable HDPE Containers", null, null },
                    { 220, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7685), 22, null, "Tailored to your needs.", null, true, null, 1, 2.00m, "Custom HDPE Containers", null, null },
                    { 221, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7686), 23, null, "For shopping needs.", null, true, null, 13, 0.05m, "LDPE Grocery Bags", null, null },
                    { 222, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7688), 23, null, "For waste disposal.", null, true, null, 13, 0.10m, "LDPE Trash Bags", null, null },
                    { 223, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7689), 23, null, "For food storage.", null, true, null, 13, 0.15m, "LDPE Freezer Bags", null, null },
                    { 224, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7691), 23, null, "For lunch packing.", null, true, null, 13, 0.08m, "LDPE Sandwich Bags", null, null },
                    { 225, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7693), 23, null, "For large items.", null, true, null, 13, 0.25m, "LDPE Bulk Bags", null, null },
                    { 226, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7694), 23, null, "Eco-friendly option.", null, true, null, 13, 0.20m, "LDPE Reusable Bags", null, null },
                    { 227, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7696), 23, null, "For moisture protection.", null, true, null, 13, 0.30m, "LDPE Barrier Bags", null, null },
                    { 228, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7697), 23, null, "For shipping products.", null, true, null, 13, 0.12m, "LDPE Mailing Bags", null, null },
                    { 229, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7699), 23, null, "For branding.", null, true, null, 13, 0.18m, "Custom LDPE Bags", null, null },
                    { 230, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7700), 23, null, "For various uses.", null, true, null, 13, 0.22m, "LDPE Packaging Bags", null, null },
                    { 231, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7702), 24, null, "Durable and lightweight.", null, true, null, 2, 0.20m, "Polypropylene Bags", null, null },
                    { 232, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7703), 24, null, "For food and retail.", null, true, null, 2, 1.00m, "Polypropylene Containers", null, null },
                    { 233, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7705), 24, null, "For packaging needs.", null, true, null, 2, 0.50m, "Polypropylene Film", null, null },
                    { 234, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7706), 24, null, "For product display.", null, true, null, 2, 0.80m, "Polypropylene Trays", null, null },
                    { 235, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7708), 24, null, "For securing packages.", null, true, null, 2, 0.30m, "Polypropylene Straps", null, null },
                    { 236, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7710), 24, null, "For drinks.", null, true, null, 2, 0.12m, "Polypropylene Cups", null, null },
                    { 237, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7711), 24, null, "For easy sealing.", null, true, null, 2, 0.25m, "Polypropylene Bags with Zipper", null, null },
                    { 238, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7713), 24, null, "Tailored to your needs.", null, true, null, 2, 0.40m, "Custom Polypropylene Packaging", null, null },
                    { 239, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7714), 24, null, "For food storage.", null, true, null, 2, 0.18m, "Polypropylene Pouches", null, null },
                    { 240, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7716), 24, null, "For product information.", null, true, null, 2, 0.10m, "Polypropylene Labels", null, null },
                    { 241, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7717), 25, null, "For hot food.", null, true, null, 4, 0.30m, "Polystyrene Foam Containers", null, null },
                    { 242, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7719), 25, null, "For beverages.", null, true, null, 4, 0.15m, "Polystyrene Cups", null, null },
                    { 243, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7721), 25, null, "For display and packaging.", null, true, null, 4, 0.20m, "Polystyrene Trays", null, null },
                    { 244, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7722), 25, null, "For food and products.", null, true, null, 4, 0.25m, "Polystyrene Clamshells", null, null },
                    { 245, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7724), 25, null, "Eco-friendly choice.", null, true, null, 4, 0.35m, "Recyclable Polystyrene Packaging", null, null },
                    { 246, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7725), 25, null, "For takeout meals.", null, true, null, 4, 0.40m, "Polystyrene Food Containers", null, null },
                    { 247, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7727), 25, null, "For deli foods.", null, true, null, 4, 0.50m, "Polystyrene Deli Containers", null, null },
                    { 248, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7728), 25, null, "For sandwiches.", null, true, null, 4, 0.30m, "Polystyrene Sandwich Containers", null, null },
                    { 249, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7730), 25, null, "For branding.", null, true, null, 4, 0.45m, "Custom Polystyrene Packaging", null, null },
                    { 250, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7731), 25, null, "For various containers.", null, true, null, 4, 0.20m, "Polystyrene Lids", null, null },
                    { 251, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7733), 26, null, "For tight sealing.", null, true, null, 5, 0.30m, "PVC Shrink Wrap", null, null },
                    { 252, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7734), 26, null, "For product visibility.", null, true, null, 5, 0.50m, "PVC Blister Packs", null, null },
                    { 253, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7736), 26, null, "For plumbing needs.", null, true, null, 5, 2.00m, "PVC Pipe and Fittings", null, null },
                    { 254, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7737), 26, null, "For various applications.", null, true, null, 5, 1.50m, "PVC Containers", null, null },
                    { 255, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7739), 26, null, "Tailored for your needs.", null, true, null, 5, 1.00m, "Custom PVC Packaging", null, null },
                    { 256, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7741), 26, null, "For labeling.", null, true, null, 5, 0.25m, "PVC Shrink Sleeves", null, null },
                    { 257, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7742), 26, null, "For sealing packages.", null, true, null, 5, 0.15m, "PVC Packaging Tape", null, null },
                    { 258, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7744), 26, null, "For safeguarding items.", null, true, null, 5, 0.40m, "PVC Protective Covers", null, null },
                    { 259, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7745), 26, null, "For outdoor use.", null, true, null, 5, 1.80m, "PVC Tarpaulins", null, null },
                    { 260, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7747), 26, null, "For product information.", null, true, null, 5, 0.10m, "PVC Labels", null, null },
                    { 261, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7748), 27, null, "For eco-friendly use.", null, true, null, 6, 0.10m, "Biodegradable Bags", null, null },
                    { 262, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7750), 27, null, "For food storage.", null, true, null, 6, 0.50m, "Biodegradable Containers", null, null },
                    { 263, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7751), 27, null, "For sustainable dining.", null, true, null, 6, 0.12m, "Biodegradable Utensils", null, null },
                    { 264, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7753), 27, null, "For wrapping products.", null, true, null, 6, 0.75m, "Biodegradable Packaging Film", null, null },
                    { 265, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7754), 27, null, "For waste disposal.", null, true, null, 6, 0.15m, "Compostable Bags", null, null },
                    { 266, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7756), 27, null, "For food and more.", null, true, null, 6, 0.50m, "Compostable Containers", null, null },
                    { 267, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7758), 27, null, "For drinks.", null, true, null, 6, 0.08m, "Biodegradable Straws", null, null },
                    { 268, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7759), 27, null, "For dining needs.", null, true, null, 6, 0.10m, "Compostable Utensils", null, null },
                    { 269, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7761), 27, null, "For fresh food storage.", null, true, null, 6, 0.20m, "Biodegradable Food Wrap", null, null },
                    { 270, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7762), 27, null, "For branding.", null, true, null, 6, 0.30m, "Custom Biodegradable Packaging", null, null },
                    { 271, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7764), 28, null, "Eco-friendly for waste.", null, true, null, 6, 0.15m, "Compostable Bags", null, null },
                    { 272, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7772), 28, null, "For dining needs.", null, true, null, 6, 0.25m, "Compostable Plates", null, null },
                    { 273, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7773), 28, null, "For food storage.", null, true, null, 6, 0.50m, "Compostable Containers", null, null },
                    { 274, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7775), 28, null, "For dining use.", null, true, null, 6, 0.12m, "Compostable Cutlery", null, null },
                    { 275, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7777), 28, null, "For drinks.", null, true, null, 6, 0.10m, "Compostable Straws", null, null },
                    { 276, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7778), 28, null, "For wrapping products.", null, true, null, 6, 0.20m, "Compostable Packaging Film", null, null },
                    { 277, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7780), 28, null, "For branding needs.", null, true, null, 6, 0.30m, "Custom Compostable Packaging", null, null },
                    { 278, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7781), 28, null, "For snacks.", null, true, null, 6, 0.15m, "Compostable Snack Bags", null, null },
                    { 279, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7783), 28, null, "For food storage.", null, true, null, 6, 0.20m, "Compostable Food Wrap", null, null },
                    { 280, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7784), 28, null, "For catering.", null, true, null, 6, 0.25m, "Compostable Serving Trays", null, null },
                    { 281, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7786), 29, null, "For safe delivery.", null, true, null, 11, 1.00m, "E-commerce Shipping Boxes", null, null },
                    { 282, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7787), 29, null, "For fragile items.", null, true, null, 11, 0.80m, "E-commerce Bubble Mailers", null, null },
                    { 283, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7789), 29, null, "For sealing boxes.", null, true, null, 11, 0.10m, "E-commerce Packaging Tape", null, null },
                    { 284, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7790), 29, null, "For cushioning items.", null, true, null, 11, 0.20m, "E-commerce Void Fill", null, null },
                    { 285, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7792), 29, null, "For shipping information.", null, true, null, 11, 0.05m, "E-commerce Labels", null, null },
                    { 286, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7793), 29, null, "For branding needs.", null, true, null, 11, 1.20m, "E-commerce Custom Boxes", null, null },
                    { 287, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7795), 29, null, "For order details.", null, true, null, 11, 0.03m, "E-commerce Packing Slips", null, null },
                    { 288, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7797), 29, null, "For posters and art.", null, true, null, 11, 0.15m, "E-commerce Mailing Tubes", null, null },
                    { 289, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7798), 29, null, "For fragile items.", null, true, null, 11, 0.25m, "E-commerce Bubble Wrap", null, null },
                    { 290, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7800), 29, null, "For special occasions.", null, true, null, 11, 0.30m, "E-commerce Gift Wrapping", null, null },
                    { 291, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7801), 30, null, "For securing large items.", null, true, null, 1, 0.50m, "Industrial Shrink Wrap", null, null },
                    { 292, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7803), 30, null, "For bundling products.", null, true, null, 1, 1.00m, "Industrial Pallet Wrap", null, null },
                    { 293, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7804), 30, null, "For securing loads.", null, true, null, 2, 0.30m, "Industrial Strapping", null, null },
                    { 294, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7806), 30, null, "For bulk storage.", null, true, null, 1, 1.50m, "Industrial Containers", null, null },
                    { 295, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7807), 30, null, "For heavy-duty shipping.", null, true, null, 11, 1.20m, "Industrial Shipping Boxes", null, null },
                    { 296, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7809), 30, null, "For sealing boxes.", null, true, null, 11, 0.15m, "Industrial Packaging Tape", null, null },
                    { 297, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7811), 30, null, "For protecting products.", null, true, null, 1, 0.40m, "Industrial Plastic Wrap", null, null },
                    { 298, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7812), 30, null, "For bulk materials.", null, true, null, 1, 0.25m, "Industrial Bags", null, null },
                    { 299, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7814), 30, null, "For cushioning fragile items.", null, true, null, 1, 0.75m, "Industrial Foam Inserts", null, null },
                    { 300, new DateTime(2024, 9, 20, 11, 59, 52, 482, DateTimeKind.Local).AddTicks(7815), 30, null, "Tailored for specific needs.", null, true, null, 1, 1.80m, "Custom Industrial Packaging", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OfferCartMessage_OfferCartId",
                table: "OfferCartMessage",
                column: "OfferCartId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferCarts_AppUserId",
                table: "OfferCarts",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferCarts_ProductId",
                table: "OfferCarts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OfferCartMessage");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "OfferCarts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
