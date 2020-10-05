using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_APATE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    AssetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetName = table.Column<string>(nullable: true),
                    PublicIP = table.Column<string>(nullable: true),
                    PrivateIP = table.Column<string>(nullable: true),
                    ConnectionStatus = table.Column<bool>(nullable: false),
                    PrivilegeID = table.Column<int>(nullable: false),
                    Hostname = table.Column<string>(nullable: true),
                    ProjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.AssetID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
