 using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEDC.Lamazon.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Category = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(maxLength: 20, nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(nullable: false),
                    IsPaid = table.Column<bool>(nullable: false),
                    DateOfOrder = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrders",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrders", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_ProductOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 2, "The best samsung phone on the market", "Samsung Galaxy S20", 1000.0 },
                    { 2, 4, "Full bag of ice for your party", "Ice", 2.0 },
                    { 3, 1, "Scotch wiskey", "Johnnie Walker", 30.0 },
                    { 4, 3, "The last book of Harry Potter", "Harry Potter", 15.0 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Supplier" },
                    { 3, "Customer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Age", "FirstName", "LastName", "Password", "RoleId", "Username" },
                values: new object[] { 1, "Slavko Lumbarkovski 16", 26, "Hristijan", "Petrovski", "kiko12345", 2, "ChrisP" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Age", "FirstName", "LastName", "Password", "RoleId", "Username" },
                values: new object[] { 2, "Partizanska 39", 27, "Mario", "Zdravkovski", "marioBt", 2, "MarioZ" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Age", "FirstName", "LastName", "Password", "RoleId", "Username" },
                values: new object[] { 3, "Bela Cesma 10", 29, "Petar", "Todorovski", "peroVoVero", 2, "Peckata" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateOfOrder", "IsPaid", "Status", "UserId" },
                values: new object[] { 1, new DateTime(2021, 2, 25, 18, 37, 20, 279, DateTimeKind.Local).AddTicks(260), false, 0, 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateOfOrder", "IsPaid", "Status", "UserId" },
                values: new object[] { 2, new DateTime(2021, 2, 25, 18, 37, 20, 280, DateTimeKind.Local).AddTicks(7998), false, 1, 2 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateOfOrder", "IsPaid", "Status", "UserId" },
                values: new object[] { 3, new DateTime(2021, 2, 25, 18, 37, 20, 280, DateTimeKind.Local).AddTicks(8031), false, 2, 3 });

            migrationBuilder.InsertData(
                table: "ProductOrders",
                columns: new[] { "ProductId", "OrderId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 3, 2, 2 },
                    { 2, 3, 3 },
                    { 1, 3, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_OrderId",
                table: "ProductOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductOrders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
