using Microsoft.EntityFrameworkCore.Migrations;

namespace H_F_M_APPDATA.Migrations
{
    public partial class FirstMigrationCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permitions_Users_User_Id",
                table: "Permitions");

            migrationBuilder.DropIndex(
                name: "IX_Permitions_User_Id",
                table: "Permitions");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "Permitions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "User_Id",
                table: "Permitions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Permitions_User_Id",
                table: "Permitions",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Permitions_Users_User_Id",
                table: "Permitions",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
