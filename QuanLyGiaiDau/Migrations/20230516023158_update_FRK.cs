using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyGiaiDau.Migrations
{
    public partial class update_FRK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GiaiDaus_LoaiGiaiDau_LoaiGiaiDauIdloaiGiaiDau",
                table: "GiaiDaus");

            migrationBuilder.RenameColumn(
                name: "LoaiGiaiDauIdloaiGiaiDau",
                table: "GiaiDaus",
                newName: "IdLoaiGiaiDau");

            migrationBuilder.RenameIndex(
                name: "IX_GiaiDaus_LoaiGiaiDauIdloaiGiaiDau",
                table: "GiaiDaus",
                newName: "IX_GiaiDaus_IdLoaiGiaiDau");

            migrationBuilder.AddForeignKey(
                name: "FK_GiaiDaus_LoaiGiaiDau_IdLoaiGiaiDau",
                table: "GiaiDaus",
                column: "IdLoaiGiaiDau",
                principalTable: "LoaiGiaiDau",
                principalColumn: "IdloaiGiaiDau",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GiaiDaus_LoaiGiaiDau_IdLoaiGiaiDau",
                table: "GiaiDaus");

            migrationBuilder.RenameColumn(
                name: "IdLoaiGiaiDau",
                table: "GiaiDaus",
                newName: "LoaiGiaiDauIdloaiGiaiDau");

            migrationBuilder.RenameIndex(
                name: "IX_GiaiDaus_IdLoaiGiaiDau",
                table: "GiaiDaus",
                newName: "IX_GiaiDaus_LoaiGiaiDauIdloaiGiaiDau");

            migrationBuilder.AddForeignKey(
                name: "FK_GiaiDaus_LoaiGiaiDau_LoaiGiaiDauIdloaiGiaiDau",
                table: "GiaiDaus",
                column: "LoaiGiaiDauIdloaiGiaiDau",
                principalTable: "LoaiGiaiDau",
                principalColumn: "IdloaiGiaiDau",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
