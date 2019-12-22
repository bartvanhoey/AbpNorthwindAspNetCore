using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Abp.Northwind.Migrations
{
    public partial class implement_multitenancy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "NWTerritories",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "NWSuppliers",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "NWShippers",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "NWRegions",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "NWProducts",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "NWOrders",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "NWOrderDetails",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "NWEmployeeTerritories",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "NWEmployees",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "NWCustomers",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "NWCategories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "NWTerritories");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "NWSuppliers");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "NWShippers");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "NWRegions");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "NWProducts");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "NWOrders");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "NWOrderDetails");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "NWEmployeeTerritories");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "NWEmployees");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "NWCustomers");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "NWCategories");
        }
    }
}
