using Microsoft.EntityFrameworkCore.Migrations;

namespace VillainsWebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "villains",
                columns: table => new
                {
                    villain_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    firstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    lastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    gender = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    age = table.Column<short>(type: "smallint", nullable: true),
                    nemesis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    hometown = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    background = table.Column<string>(type: "text", nullable: true),
                    weapon_of_choice = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    description = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__villains__8D6B3A5AB7C6665B", x => x.villain_id);
                });

            migrationBuilder.CreateTable(
                name: "abilities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    villain_id = table.Column<int>(type: "int", nullable: false),
                    villain_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ability_name = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    level = table.Column<short>(type: "smallint", nullable: true),
                    Description = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abilities", x => x.id);
                    table.ForeignKey(
                        name: "FK_villain_name",
                        column: x => x.villain_id,
                        principalTable: "villains",
                        principalColumn: "villain_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "base_stats",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    villain_id = table.Column<int>(type: "int", nullable: false),
                    villain_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ego = table.Column<int>(type: "int", nullable: false),
                    fighting_spirit = table.Column<int>(type: "int", nullable: false),
                    mass = table.Column<int>(type: "int", nullable: false),
                    self_confidence = table.Column<int>(type: "int", nullable: false),
                    trickery = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_base_stats", x => x.id);
                    table.ForeignKey(
                        name: "FK_villain_id",
                        column: x => x.villain_id,
                        principalTable: "villains",
                        principalColumn: "villain_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_abilities_villain_id",
                table: "abilities",
                column: "villain_id");

            migrationBuilder.CreateIndex(
                name: "IX_base_stats_villain_id",
                table: "base_stats",
                column: "villain_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abilities");

            migrationBuilder.DropTable(
                name: "base_stats");

            migrationBuilder.DropTable(
                name: "villains");
        }
    }
}
