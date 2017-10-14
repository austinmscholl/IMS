using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication3.Migrations.Canary
{
    public partial class initial9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeceased",
                table: "Canary");

            migrationBuilder.DropColumn(
                name: "IsSold",
                table: "Canary");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Canary",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<bool>(
                name: "Deceased",
                table: "Canary",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sold",
                table: "Canary",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deceased",
                table: "Canary");

            migrationBuilder.DropColumn(
                name: "Sold",
                table: "Canary");

            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Canary",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeceased",
                table: "Canary",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSold",
                table: "Canary",
                nullable: false,
                defaultValue: false);
        }
    }
}
