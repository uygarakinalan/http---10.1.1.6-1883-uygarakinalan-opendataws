using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace opendataws.data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnvironmentData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IstasyonNo = table.Column<int>(type: "int", nullable: true),
                    IstasyonAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sicaklik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Basinc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gaz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pm25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pm10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayıtTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvironmentData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnvironmentData");
        }
    }
}
