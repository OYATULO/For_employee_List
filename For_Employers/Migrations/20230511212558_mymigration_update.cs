using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace For_Employers.Migrations
{
    /// <inheritdoc />
    public partial class mymigration_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubMenu_PDepartment_PDepartmentId",
                table: "SubMenu");

            migrationBuilder.DropIndex(
                name: "IX_SubMenu_PDepartmentId",
                table: "SubMenu");

            migrationBuilder.DropColumn(
                name: "PDepartmentId",
                table: "SubMenu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PDepartmentId",
                table: "SubMenu",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubMenu_PDepartmentId",
                table: "SubMenu",
                column: "PDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubMenu_PDepartment_PDepartmentId",
                table: "SubMenu",
                column: "PDepartmentId",
                principalTable: "PDepartment",
                principalColumn: "Id");
        }
    }
}
