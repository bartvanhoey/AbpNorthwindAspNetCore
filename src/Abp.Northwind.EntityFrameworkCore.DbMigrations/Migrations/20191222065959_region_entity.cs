using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Abp.Northwind.Migrations
{
    public partial class region_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NWEmployees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(maxLength: 10, nullable: false),
                    Title = table.Column<string>(maxLength: 30, nullable: true),
                    TitleOfCourtesy = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Address = table.Column<string>(maxLength: 60, nullable: true),
                    City = table.Column<string>(maxLength: 15, nullable: true),
                    Region = table.Column<string>(maxLength: 15, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 15, nullable: true),
                    HomePhone = table.Column<string>(maxLength: 24, nullable: true),
                    Extension = table.Column<string>(maxLength: 4, nullable: true),
                    Photo = table.Column<byte[]>(type: "image", nullable: true),
                    Notes = table.Column<string>(type: "ntext", nullable: true),
                    ReportsTo = table.Column<int>(nullable: true),
                    PhotoPath = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NWEmployees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Employees",
                        column: x => x.ReportsTo,
                        principalTable: "NWEmployees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NWRegions",
                columns: table => new
                {
                    RegionID = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    RegionDescription = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NWRegions", x => x.RegionID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "NWTerritories",
                columns: table => new
                {
                    TerritoryID = table.Column<string>(maxLength: 20, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    TerritoryDescription = table.Column<string>(maxLength: 50, nullable: false),
                    RegionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NWTerritories", x => x.TerritoryID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Territories_Region",
                        column: x => x.RegionID,
                        principalTable: "NWRegions",
                        principalColumn: "RegionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NWEmployeeTerritories",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false),
                    TerritoryID = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NWEmployeeTerritories", x => new { x.EmployeeID, x.TerritoryID })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_EmployeeTerritories_Employees",
                        column: x => x.EmployeeID,
                        principalTable: "NWEmployees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeTerritories_Territories",
                        column: x => x.TerritoryID,
                        principalTable: "NWTerritories",
                        principalColumn: "TerritoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_EmployeeId",
                table: "Order",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_NWEmployees_ReportsTo",
                table: "NWEmployees",
                column: "ReportsTo");

            migrationBuilder.CreateIndex(
                name: "IX_NWEmployeeTerritories_TerritoryID",
                table: "NWEmployeeTerritories",
                column: "TerritoryID");

            migrationBuilder.CreateIndex(
                name: "IX_NWTerritories_RegionID",
                table: "NWTerritories",
                column: "RegionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_NWEmployees_EmployeeId",
                table: "Order",
                column: "EmployeeId",
                principalTable: "NWEmployees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_NWEmployees_EmployeeId",
                table: "Order");

            migrationBuilder.DropTable(
                name: "NWEmployeeTerritories");

            migrationBuilder.DropTable(
                name: "NWEmployees");

            migrationBuilder.DropTable(
                name: "NWTerritories");

            migrationBuilder.DropTable(
                name: "NWRegions");

            migrationBuilder.DropIndex(
                name: "IX_Order_EmployeeId",
                table: "Order");
        }
    }
}
