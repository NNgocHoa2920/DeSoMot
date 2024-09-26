using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeSoMot.Migrations
{
    public partial class hehe222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanId",
                table: "NhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhongBans",
                table: "PhongBans");

            migrationBuilder.DropIndex(
                name: "IX_NhanViens_PhongBanId",
                table: "NhanViens");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhongBans");

            migrationBuilder.DropColumn(
                name: "PhongBanId",
                table: "NhanViens");

            migrationBuilder.AddColumn<string>(
                name: "MaPB",
                table: "PhongBans",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhongBanMaPB",
                table: "NhanViens",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhongBans",
                table: "PhongBans",
                column: "MaPB");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_PhongBanMaPB",
                table: "NhanViens",
                column: "PhongBanMaPB");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanMaPB",
                table: "NhanViens",
                column: "PhongBanMaPB",
                principalTable: "PhongBans",
                principalColumn: "MaPB",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanMaPB",
                table: "NhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhongBans",
                table: "PhongBans");

            migrationBuilder.DropIndex(
                name: "IX_NhanViens_PhongBanMaPB",
                table: "NhanViens");

            migrationBuilder.DropColumn(
                name: "MaPB",
                table: "PhongBans");

            migrationBuilder.DropColumn(
                name: "PhongBanMaPB",
                table: "NhanViens");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PhongBans",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PhongBanId",
                table: "NhanViens",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhongBans",
                table: "PhongBans",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_PhongBanId",
                table: "NhanViens",
                column: "PhongBanId");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanId",
                table: "NhanViens",
                column: "PhongBanId",
                principalTable: "PhongBans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
