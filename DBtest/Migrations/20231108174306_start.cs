using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBtest.Migrations
{
    /// <inheritdoc />
    public partial class start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bukets",
                columns: table => new
                {
                    Bulet_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bulet_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bulet_Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bukets", x => x.Bulet_Id);
                });

            migrationBuilder.CreateTable(
                name: "Prods",
                columns: table => new
                {
                    Prod_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prod_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prod_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prod_Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prods", x => x.Prod_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bukets");

            migrationBuilder.DropTable(
                name: "Prods");
        }
    }
}
