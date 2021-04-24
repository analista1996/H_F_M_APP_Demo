using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace H_F_M_APPDATA.Migrations
{
    public partial class AddSpendsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spends",
                columns: table => new
                {
                    Spend_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Spend_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_M_Id = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spends", x => x.Spend_Id);
                    table.ForeignKey(
                        name: "FK_Spends_Payment_Methods_P_M_Id",
                        column: x => x.P_M_Id,
                        principalTable: "Payment_Methods",
                        principalColumn: "P_M_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spends_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spends_P_M_Id",
                table: "Spends",
                column: "P_M_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Spends_User_Id",
                table: "Spends",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spends");
        }
    }
}
