using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace For_Employers.Migrations
{
    /// <inheritdoc />
    public partial class mymigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CompanyDStructure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDStructure", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Accounting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompanyDStructureId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounting_CompanyDStructure_CompanyDStructureId",
                        column: x => x.CompanyDStructureId,
                        principalTable: "CompanyDStructure",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CServiceDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompanyDStructureId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CServiceDepartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CServiceDepartment_CompanyDStructure_CompanyDStructureId",
                        column: x => x.CompanyDStructureId,
                        principalTable: "CompanyDStructure",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompanyDStructureId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDepartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PDepartment_CompanyDStructure_CompanyDStructureId",
                        column: x => x.CompanyDStructureId,
                        principalTable: "CompanyDStructure",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SubMenu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CServiceDepartmentId = table.Column<int>(type: "int", nullable: true),
                    PDepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMenu", x => x.id);
                    table.ForeignKey(
                        name: "FK_SubMenu_CServiceDepartment_CServiceDepartmentId",
                        column: x => x.CServiceDepartmentId,
                        principalTable: "CServiceDepartment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubMenu_PDepartment_PDepartmentId",
                        column: x => x.PDepartmentId,
                        principalTable: "PDepartment",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Submenu2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubMenuid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submenu2", x => x.id);
                    table.ForeignKey(
                        name: "FK_Submenu2_SubMenu_SubMenuid",
                        column: x => x.SubMenuid,
                        principalTable: "SubMenu",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccountingId = table.Column<int>(type: "int", nullable: true),
                    PDepartmentId = table.Column<int>(type: "int", nullable: true),
                    SubMenuid = table.Column<int>(type: "int", nullable: true),
                    Submenu2id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employes_Accounting_AccountingId",
                        column: x => x.AccountingId,
                        principalTable: "Accounting",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employes_PDepartment_PDepartmentId",
                        column: x => x.PDepartmentId,
                        principalTable: "PDepartment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employes_SubMenu_SubMenuid",
                        column: x => x.SubMenuid,
                        principalTable: "SubMenu",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Employes_Submenu2_Submenu2id",
                        column: x => x.Submenu2id,
                        principalTable: "Submenu2",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Accounting_CompanyDStructureId",
                table: "Accounting",
                column: "CompanyDStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_CServiceDepartment_CompanyDStructureId",
                table: "CServiceDepartment",
                column: "CompanyDStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_Employes_AccountingId",
                table: "Employes",
                column: "AccountingId");

            migrationBuilder.CreateIndex(
                name: "IX_Employes_PDepartmentId",
                table: "Employes",
                column: "PDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employes_Submenu2id",
                table: "Employes",
                column: "Submenu2id");

            migrationBuilder.CreateIndex(
                name: "IX_Employes_SubMenuid",
                table: "Employes",
                column: "SubMenuid");

            migrationBuilder.CreateIndex(
                name: "IX_PDepartment_CompanyDStructureId",
                table: "PDepartment",
                column: "CompanyDStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_SubMenu_CServiceDepartmentId",
                table: "SubMenu",
                column: "CServiceDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubMenu_PDepartmentId",
                table: "SubMenu",
                column: "PDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Submenu2_SubMenuid",
                table: "Submenu2",
                column: "SubMenuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employes");

            migrationBuilder.DropTable(
                name: "Accounting");

            migrationBuilder.DropTable(
                name: "Submenu2");

            migrationBuilder.DropTable(
                name: "SubMenu");

            migrationBuilder.DropTable(
                name: "CServiceDepartment");

            migrationBuilder.DropTable(
                name: "PDepartment");

            migrationBuilder.DropTable(
                name: "CompanyDStructure");
        }
    }
}
