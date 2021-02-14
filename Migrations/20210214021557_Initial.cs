using Microsoft.EntityFrameworkCore.Migrations;

namespace APIElectron.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Custumers",
                columns: table => new
                {
                    idCustumer = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    name = table.Column<string>(type: "varchar(45) CHARACTER SET utf8mb4", maxLength: 45, nullable: true),
                    phone = table.Column<int>(type: "int", nullable: false),
                    zip = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Custumers", x => x.idCustumer);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Custumers");
        }
    }
}
