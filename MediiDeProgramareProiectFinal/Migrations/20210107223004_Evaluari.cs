using Microsoft.EntityFrameworkCore.Migrations;

namespace MediiDeProgramareProiectFinal.Migrations
{
    public partial class Evaluari : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Evaluare",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: false),
                    Nota = table.Column<int>(nullable: false),
                    SpecializareID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluare", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Evaluare_Curs_CursID",
                        column: x => x.CursID,
                        principalTable: "Curs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluare_Specializare_SpecializareID",
                        column: x => x.SpecializareID,
                        principalTable: "Specializare",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluare_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evaluare_CursID",
                table: "Evaluare",
                column: "CursID");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluare_SpecializareID",
                table: "Evaluare",
                column: "SpecializareID");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluare_StudentID",
                table: "Evaluare",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluare");
        }
    }
}
