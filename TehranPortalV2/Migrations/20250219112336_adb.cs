using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TehranPortalV2.Migrations
{
    /// <inheritdoc />
    public partial class adb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Branch",
                columns: table => new
                {
                    BRCode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    BRName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BRPhone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BRPhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BRPhone3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Branch", x => x.BRCode);
                });

            migrationBuilder.CreateTable(
                name: "TB_ITLabele",
                columns: table => new
                {
                    IT_CodeLable = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITLableStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ITLabele", x => x.IT_CodeLable);
                });

            migrationBuilder.CreateTable(
                name: "TB_UserPersonal",
                columns: table => new
                {
                    Id_Personal = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_UserPersonal", x => x.Id_Personal);
                });

            migrationBuilder.CreateTable(
                name: "TB_YLable",
                columns: table => new
                {
                    Y_LableCode = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    YLableStatus = table.Column<int>(type: "int", nullable: false),
                    IT_CodeLable = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_YLable", x => x.Y_LableCode);
                    table.ForeignKey(
                        name: "FK_TB_YLable_TB_ITLabele_IT_CodeLable",
                        column: x => x.IT_CodeLable,
                        principalTable: "TB_ITLabele",
                        principalColumn: "IT_CodeLable",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ClientPassword",
                columns: table => new
                {
                    Id_Personal = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ClientPassword", x => x.Id_Personal);
                    table.ForeignKey(
                        name: "FK_TB_ClientPassword_TB_UserPersonal_Id_Personal",
                        column: x => x.Id_Personal,
                        principalTable: "TB_UserPersonal",
                        principalColumn: "Id_Personal",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_CombinedLables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YLableCode = table.Column<string>(type: "nvarchar(7)", nullable: true),
                    ITLableCode = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CombinedLables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_CombinedLables_TB_ITLabele_ITLableCode",
                        column: x => x.ITLableCode,
                        principalTable: "TB_ITLabele",
                        principalColumn: "IT_CodeLable");
                    table.ForeignKey(
                        name: "FK_TB_CombinedLables_TB_YLable_YLableCode",
                        column: x => x.YLableCode,
                        principalTable: "TB_YLable",
                        principalColumn: "Y_LableCode");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_CombinedLables_ITLableCode",
                table: "TB_CombinedLables",
                column: "ITLableCode");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CombinedLables_YLableCode",
                table: "TB_CombinedLables",
                column: "YLableCode");

            migrationBuilder.CreateIndex(
                name: "IX_TB_YLable_IT_CodeLable",
                table: "TB_YLable",
                column: "IT_CodeLable");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Branch");

            migrationBuilder.DropTable(
                name: "TB_ClientPassword");

            migrationBuilder.DropTable(
                name: "TB_CombinedLables");

            migrationBuilder.DropTable(
                name: "TB_UserPersonal");

            migrationBuilder.DropTable(
                name: "TB_YLable");

            migrationBuilder.DropTable(
                name: "TB_ITLabele");
        }
    }
}
