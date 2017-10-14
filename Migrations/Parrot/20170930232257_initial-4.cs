using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication3.Migrations.Parrot
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parrot",
                columns: table => new
                {
                    ParrotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Breeder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    IsDeceased = table.Column<bool>(type: "bit", nullable: false),
                    IsNewWorld = table.Column<bool>(type: "bit", nullable: false),
                    IsOldWorld = table.Column<bool>(type: "bit", nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parrot", x => x.ParrotId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parrot");
        }
    }
}
