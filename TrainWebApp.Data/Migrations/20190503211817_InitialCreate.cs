using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TrainWebApp.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StormTrooper",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: false),
                    desc = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StormTrooper", x => x.id);
                });

            migrationBuilder.CreateTable(
               name: "Fleet",
               columns: table => new
               {
                   id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                   name = table.Column<string>(nullable: false),
                   desc = table.Column<string>(nullable: true),
                   type = table.Column<string>(nullable: true),

               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Fleet", x => x.id);
               });

            migrationBuilder.CreateTable(
               name: "Vehicles",
               columns: table => new
               {
                   id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                   name = table.Column<string>(nullable: false),
                   desc = table.Column<string>(nullable: true),
                   type = table.Column<string>(nullable: true),

               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Vehicles", x => x.id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "StormTrooper");
            migrationBuilder.DropTable(name: "Fleet");
            migrationBuilder.DropTable(name: "Vehicles");
        }
    }
}
