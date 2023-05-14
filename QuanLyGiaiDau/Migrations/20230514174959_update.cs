using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyGiaiDau.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoaiGiaiDau_MonTheThaos_MonTheThaoIdMonTheThao",
                table: "LoaiGiaiDau");

            migrationBuilder.RenameColumn(
                name: "MonTheThaoIdMonTheThao",
                table: "LoaiGiaiDau",
                newName: "IdMonTheThao");

            migrationBuilder.RenameIndex(
                name: "IX_LoaiGiaiDau_MonTheThaoIdMonTheThao",
                table: "LoaiGiaiDau",
                newName: "IX_LoaiGiaiDau_IdMonTheThao");

            migrationBuilder.AddForeignKey(
                name: "FK_LoaiGiaiDau_MonTheThaos_IdMonTheThao",
                table: "LoaiGiaiDau",
                column: "IdMonTheThao",
                principalTable: "MonTheThaos",
                principalColumn: "IdMonTheThao",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoaiGiaiDau_MonTheThaos_IdMonTheThao",
                table: "LoaiGiaiDau");

            migrationBuilder.RenameColumn(
                name: "IdMonTheThao",
                table: "LoaiGiaiDau",
                newName: "MonTheThaoIdMonTheThao");

            migrationBuilder.RenameIndex(
                name: "IX_LoaiGiaiDau_IdMonTheThao",
                table: "LoaiGiaiDau",
                newName: "IX_LoaiGiaiDau_MonTheThaoIdMonTheThao");

            migrationBuilder.AddForeignKey(
                name: "FK_LoaiGiaiDau_MonTheThaos_MonTheThaoIdMonTheThao",
                table: "LoaiGiaiDau",
                column: "MonTheThaoIdMonTheThao",
                principalTable: "MonTheThaos",
                principalColumn: "IdMonTheThao",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
