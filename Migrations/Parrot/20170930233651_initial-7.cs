using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication3.Migrations.Parrot
{
    public partial class initial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeceased",
                table: "Parrot");

            migrationBuilder.DropColumn(
                name: "IsNewWorld",
                table: "Parrot");

            migrationBuilder.DropColumn(
                name: "IsOldWorld",
                table: "Parrot");

            migrationBuilder.DropColumn(
                name: "IsSold",
                table: "Parrot");

            migrationBuilder.AddColumn<bool>(
                name: "Deceased",
                table: "Parrot",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NewWorld",
                table: "Parrot",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OldWorld",
                table: "Parrot",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sold",
                table: "Parrot",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deceased",
                table: "Parrot");

            migrationBuilder.DropColumn(
                name: "NewWorld",
                table: "Parrot");

            migrationBuilder.DropColumn(
                name: "OldWorld",
                table: "Parrot");

            migrationBuilder.DropColumn(
                name: "Sold",
                table: "Parrot");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeceased",
                table: "Parrot",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNewWorld",
                table: "Parrot",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOldWorld",
                table: "Parrot",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSold",
                table: "Parrot",
                nullable: false,
                defaultValue: false);
        }
    }
}
