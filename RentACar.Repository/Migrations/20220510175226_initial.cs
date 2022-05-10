using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalIdentityNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5008), "BMW", null },
                    { 2, new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5029), "Mercedes", null },
                    { 3, new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5032), "Ford", null },
                    { 4, new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5033), "Range Rover", null },
                    { 5, new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5035), "Opel", null },
                    { 6, new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5039), "Fiat", null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BrandId", "Color", "CreatedDate", "FuelType", "ImageUrl", "LicensePlate", "ModelYear", "Price", "State", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, "Beyaz", new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5188), "Benzin", "test", "34ATO3474", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, true, null },
                    { 2, 2, "Siyah", new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5200), "Benzin", "test", "34ADM3452", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, true, null },
                    { 3, 3, "Kırmızı", new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5206), "Benzin", "test", "34TR1111", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, true, null },
                    { 4, 4, "Mavi", new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5211), "Dizel", "test", "34İST2222", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, true, null },
                    { 5, 5, "Siyah", new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5218), "Dizel", "test", "34BRT3333", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, true, null },
                    { 6, 6, "Beyaz", new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5225), "Benzin", "test", "34AS4444", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, true, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
