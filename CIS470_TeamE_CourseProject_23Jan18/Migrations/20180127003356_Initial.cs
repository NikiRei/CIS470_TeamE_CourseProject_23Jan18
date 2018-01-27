using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CIS470_TeamE_CourseProject_23Jan18.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    orderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    designRequest = table.Column<string>(nullable: true),
                    insertedDateTime = table.Column<DateTime>(nullable: false),
                    jobType = table.Column<string>(nullable: true),
                    lastUpdated = table.Column<DateTime>(nullable: false),
                    lastUpdatedBy = table.Column<string>(nullable: true),
                    mediaCatalogNumber = table.Column<int>(nullable: false),
                    mediaType = table.Column<string>(nullable: true),
                    orderStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.orderID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
