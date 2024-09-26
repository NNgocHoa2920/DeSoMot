using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeSoMot.Migrations
{
    public partial class hehe222333 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanMaPB",
                table: "NhanViens");

            migrationBuilder.AlterColumn<string>(
                name: "PhongBanMaPB",
                table: "NhanViens",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanMaPB",
                table: "NhanViens",
                column: "PhongBanMaPB",
                principalTable: "PhongBans",
                principalColumn: "MaPB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanMaPB",
                table: "NhanViens");

            migrationBuilder.AlterColumn<string>(
                name: "PhongBanMaPB",
                table: "NhanViens",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanMaPB",
                table: "NhanViens",
                column: "PhongBanMaPB",
                principalTable: "PhongBans",
                principalColumn: "MaPB",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
