using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Abp.Northwind.Migrations
{
    public partial class shipper_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShipperId",
                table: "Order",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NWShippers",
                columns: table => new
                {
                    ShipperID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    CompanyName = table.Column<string>(maxLength: 40, nullable: false),
                    Phone = table.Column<string>(maxLength: 24, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NWShippers", x => x.ShipperID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShipperId",
                table: "Order",
                column: "ShipperId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_NWShippers_ShipperId",
                table: "Order",
                column: "ShipperId",
                principalTable: "NWShippers",
                principalColumn: "ShipperID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_NWShippers_ShipperId",
                table: "Order");

            migrationBuilder.DropTable(
                name: "NWShippers");

            migrationBuilder.DropIndex(
                name: "IX_Order_ShipperId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ShipperId",
                table: "Order");
        }
    }
}
