﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimeiroCrud.API.Migrations
{
    public partial class inserindoIMGUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Bandas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Bandas");
        }
    }
}
