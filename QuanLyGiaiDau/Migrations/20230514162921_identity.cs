using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyGiaiDau.Migrations
{
    public partial class identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoiDaus",
                columns: table => new
                {
                    IdTranDau = table.Column<string>(type: "varchar(10)", nullable: false),
                    TenDoiDau = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(256)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoiDaus", x => x.IdTranDau);
                });

            migrationBuilder.CreateTable(
                name: "MonTheThaos",
                columns: table => new
                {
                    IdMonTheThao = table.Column<string>(type: "varchar(10)", nullable: false),
                    TenMonTheThao = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonTheThaos", x => x.IdMonTheThao);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<string>(type: "varchar(10)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(15)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "LoaiGiaiDau",
                columns: table => new
                {
                    IdloaiGiaiDau = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    MonTheThaoIdMonTheThao = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiGiaiDau", x => x.IdloaiGiaiDau);
                    table.ForeignKey(
                        name: "FK_LoaiGiaiDau_MonTheThaos_MonTheThaoIdMonTheThao",
                        column: x => x.MonTheThaoIdMonTheThao,
                        principalTable: "MonTheThaos",
                        principalColumn: "IdMonTheThao",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CT_DoiDaus",
                columns: table => new
                {
                    DoiDauIdTranDau = table.Column<string>(type: "varchar(10)", nullable: true),
                    UserIdUser = table.Column<string>(type: "varchar(10)", nullable: true),
                    TrangThaiTV = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CT_DoiDaus_DoiDaus_DoiDauIdTranDau",
                        column: x => x.DoiDauIdTranDau,
                        principalTable: "DoiDaus",
                        principalColumn: "IdTranDau",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CT_DoiDaus_Users_UserIdUser",
                        column: x => x.UserIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GiaiDaus",
                columns: table => new
                {
                    IdGiaiDau = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenGiaiDau = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "Datetime", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    DiaDiem = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    LoaiGiaiDauIdloaiGiaiDau = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaiDaus", x => x.IdGiaiDau);
                    table.ForeignKey(
                        name: "FK_GiaiDaus_LoaiGiaiDau_LoaiGiaiDauIdloaiGiaiDau",
                        column: x => x.LoaiGiaiDauIdloaiGiaiDau,
                        principalTable: "LoaiGiaiDau",
                        principalColumn: "IdloaiGiaiDau",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CT_TranDaus",
                columns: table => new
                {
                    GiaiDauIdGiaiDau = table.Column<int>(type: "int", nullable: true),
                    DoiDauIdTranDau = table.Column<string>(type: "varchar(10)", nullable: true),
                    ThoiGianBatDau = table.Column<DateTime>(type: "DateTime", nullable: false),
                    VongDau = table.Column<int>(type: "int", nullable: false),
                    SanDau = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    TiSo = table.Column<int>(type: "int", nullable: false),
                    KetQua = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CT_TranDaus_DoiDaus_DoiDauIdTranDau",
                        column: x => x.DoiDauIdTranDau,
                        principalTable: "DoiDaus",
                        principalColumn: "IdTranDau",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CT_TranDaus_GiaiDaus_GiaiDauIdGiaiDau",
                        column: x => x.GiaiDauIdGiaiDau,
                        principalTable: "GiaiDaus",
                        principalColumn: "IdGiaiDau",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CT_DoiDaus_DoiDauIdTranDau",
                table: "CT_DoiDaus",
                column: "DoiDauIdTranDau");

            migrationBuilder.CreateIndex(
                name: "IX_CT_DoiDaus_UserIdUser",
                table: "CT_DoiDaus",
                column: "UserIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CT_TranDaus_DoiDauIdTranDau",
                table: "CT_TranDaus",
                column: "DoiDauIdTranDau");

            migrationBuilder.CreateIndex(
                name: "IX_CT_TranDaus_GiaiDauIdGiaiDau",
                table: "CT_TranDaus",
                column: "GiaiDauIdGiaiDau");

            migrationBuilder.CreateIndex(
                name: "IX_GiaiDaus_LoaiGiaiDauIdloaiGiaiDau",
                table: "GiaiDaus",
                column: "LoaiGiaiDauIdloaiGiaiDau");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiGiaiDau_MonTheThaoIdMonTheThao",
                table: "LoaiGiaiDau",
                column: "MonTheThaoIdMonTheThao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CT_DoiDaus");

            migrationBuilder.DropTable(
                name: "CT_TranDaus");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DoiDaus");

            migrationBuilder.DropTable(
                name: "GiaiDaus");

            migrationBuilder.DropTable(
                name: "LoaiGiaiDau");

            migrationBuilder.DropTable(
                name: "MonTheThaos");
        }
    }
}
