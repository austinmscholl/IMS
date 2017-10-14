using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication3.Migrations.Finch
{
    public partial class initial8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeceased",
                table: "Finch");

            migrationBuilder.DropColumn(
                name: "IsSold",
                table: "Finch");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Finch",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<bool>(
                name: "Deceased",
                table: "Finch",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sold",
                table: "Finch",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deceased",
                table: "Finch");

            migrationBuilder.DropColumn(
                name: "Sold",
                table: "Finch");

            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Finch",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeceased",
                table: "Finch",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSold",
                table: "Finch",
                nullable: false,
                defaultValue: false);
        }
    }
}
