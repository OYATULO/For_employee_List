using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace For_Employers.Migrations
{
    /// <inheritdoc />
    public partial class mymigration_lastupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employes_PDepartment_PDepartmentId",
                table: "Employes");

            migrationBuilder.DropIndex(
                name: "IX_Employes_PDepartmentId",
                table: "Employes");

            migrationBuilder.DropColumn(
                name: "PDepartmentId",
                table: "Employes");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "PDepartmentId",
                table: "Employes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employes_PDepartmentId",
                table: "Employes",
                column: "PDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employes_PDepartment_PDepartmentId",
                table: "Employes",
                column: "PDepartmentId",
                principalTable: "PDepartment",
                principalColumn: "Id");
        }
    }
}
